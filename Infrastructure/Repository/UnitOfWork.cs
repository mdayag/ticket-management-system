using Domain.IRepository;
using Infrastructure.Data;
using System.Collections;

namespace Infrastructure.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly AppDbContext _dbContext;
		private Hashtable _repositories;

		public ITicketRepository TicketRepository {  get; }

        public IDiscussionRepository DiscussionRepository { get; }

        public UnitOfWork(AppDbContext dbContext,
			ITicketRepository ticketRepository,
            IDiscussionRepository discussionRepository) 
		{
			_dbContext = dbContext;
			TicketRepository = ticketRepository;
			DiscussionRepository = discussionRepository;
        }

		public void Dispose()
		{
			_dbContext.Dispose();
		}

		public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
		{
			if (_repositories == null) _repositories = new Hashtable();
			
			var type = typeof(TEntity).Name;

			if (!_repositories.ContainsKey(type))
			{
				var repositoryType = typeof(GenericRepository<>);
				var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _dbContext);

				_repositories.Add(type, repositoryInstance);
			}

			return (IGenericRepository<TEntity>)_repositories[type];
		}

		public async Task<int> SaveChanges()
		{
			return await _dbContext.SaveChangesAsync();
		}

		public async Task<bool> SaveChangesReturnedBool()
		{
			return await _dbContext.SaveChangesAsync() > 0;
		}
	}
}
