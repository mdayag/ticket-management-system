using Jose;
using Newtonsoft.Json;
using System.Text;

namespace TicketManagementUI.Security
{
	public class EncryptionHelper<T> where T : class
	{
		byte[] _secretKey;
		private readonly IConfiguration _configuration;

		public EncryptionHelper(IConfiguration configuration)
		{
			_configuration = configuration;
			_secretKey = Encoding.UTF8.GetBytes(configuration["JWEKey"]);
		}

		public string Encode(Object obj)
		{
			return JWT.Encode(obj, _secretKey, JweAlgorithm.A256KW, JweEncryption.A256CBC_HS512);
		}

		public T Decode(string token)
		{
			var result = JWT.Decode(token, _secretKey);
			return JsonConvert.DeserializeObject<T>(result);
		}
	}
}
