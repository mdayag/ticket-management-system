using Domain.DTO.Request;
using Domain.DTO.Response;

namespace Domain.IService
{
    public interface IDiscussionService
    {
        List<DiscussionResponse> GetDiscussions(int ticketId);

        Task<BaseResponse> Create(CreateDiscussionRequest request);
    }
}
