using Domain.Entities;
using Domain.IRepository;
using Domain.IService;

namespace Infrastructure.Services
{
	public class CriteriaService : ICriteriaService
	{
		private readonly IUnitOfWork _unitOfWork;

		public CriteriaService(IUnitOfWork unitOfWork)
        {
			_unitOfWork = unitOfWork;
		}

		public List<Category> GetCategories()
		{
			return _unitOfWork.Repository<Category>().GetAll();
		}

		public List<Priority> GetPriorities()
		{
			return _unitOfWork.Repository<Priority>().GetAll();
		}

		public List<Product> GetProducts()
		{
			return _unitOfWork.Repository<Product>().GetAll();
		}

		public List<string> GetStatus()
		{
			return
			[
				"NEW",
				"OPEN",
				"CLOSED"
			];
		}
	}
}
