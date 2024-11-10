using Domain.DTO.Request;
using Domain.DTO.Response;

namespace Domain.IService
{
	public interface ITicketService
	{
		List<GetTicketResponse> GetTickets(GetTicketRequest request);

		GetTicketResponse FindTicket(int ticketId);

		Task<BaseResponse> UpdateTicket(UpdateTicketRequest request);

		Task<BaseResponse<int>> CreateTicket(CreateTicketRequest request);

		List<ChartResponse> Last12MonthsTickets();

		List<ChartResponse> ChartByCategory(string category);

		List<ChartResponse> GetSummary();
	}
}
