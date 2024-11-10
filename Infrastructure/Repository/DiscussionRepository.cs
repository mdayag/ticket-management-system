using Domain.Entities;
using Domain.IRepository;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class DiscussionRepository : GenericRepository<Discussion>, IDiscussionRepository
    {
        public DiscussionRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public List<Discussion> GetDiscussions(int ticketId)
        {
            return _dbContext.Set<Discussion>()
                .Include(x => x.Attachments)
                .Include(x => x.User)
                .Where(x => x.TicketId == ticketId)
                .OrderBy(x => x.CreatedDate)
                .ToList();
        }
    }
}
