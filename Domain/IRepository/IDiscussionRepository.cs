using Domain.Entities;

namespace Domain.IRepository
{
    public interface IDiscussionRepository : IGenericRepository<Discussion>
    {
        List<Discussion> GetDiscussions(int ticketId);
    }
}
