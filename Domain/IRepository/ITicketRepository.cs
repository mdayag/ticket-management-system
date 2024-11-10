using Domain.DTO.Request;
using Domain.DTO.Response;
using Domain.Entities;

namespace Domain.IRepository
{
	public interface ITicketRepository : IGenericRepository<Ticket>
	{
		List<Ticket> GetTickets(GetTicketRequest request);

		List<ChartResponse> Last12MonthsTickets();

		List<ChartResponse> ChartByCategory(string category);

		List<ChartResponse> GetSummary();

		Ticket FindTicket(int ticketId);
	}
}