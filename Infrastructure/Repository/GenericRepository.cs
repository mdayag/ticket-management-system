using Domain.IRepository;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		protected readonly AppDbContext _dbContext;

		public GenericRepository(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public void Add(T entity)
		{
			_dbContext.Set<T>().Add(entity);
		}

		public void Delete(T entity)
		{
			_dbContext.Set<T>().Remove(entity);
		}

		public void Delete(int id)
		{
			T entity = _dbContext.Set<T>().Find(id);
			Delete(entity);
		}

		public List<T> GetAll()
		{
			return [.. _dbContext.Set<T>()];
		}

		public T GetByIdAsync(int id)
		{
			return _dbContext.Set<T>().Find(id);
		}

		public void Update(T entity)
		{
			_dbContext.Set<T>().Attach(entity);
			_dbContext.Entry(entity).State = EntityState.Modified;
		}

		public void SaveChanges()
		{
			_dbContext.SaveChanges();
		}
	}
}
