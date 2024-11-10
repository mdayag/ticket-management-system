using Domain.Entities;

namespace Domain.IService
{
	public interface ICriteriaService
	{
		List<Category> GetCategories();

		List<Product> GetProducts();

		List<Priority> GetPriorities();

		List<string> GetStatus();
	}
}
