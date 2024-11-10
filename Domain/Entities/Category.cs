using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
	public class Category
	{
		[Key]
		public int CategoryId { get; set; }

		public string CategoryName { get; set; } = string.Empty;
	}
}
