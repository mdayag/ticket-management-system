using Domain.DTO.Request;
using Domain.DTO.Response;
using Domain.Entities;
using Domain.IRepository;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
	public class TicketRepository : GenericRepository<Ticket>, ITicketRepository
	{
		public TicketRepository(AppDbContext dbContext) : base(dbContext)
		{
		}

		public List<Ticket> GetTickets(GetTicketRequest request)
		{
			IQueryable<Ticket> query = _dbContext.Set<Ticket>()
										.Include(x => x.Category)
										.Include(x => x.Priority)
										.Include(x => x.Product)
										.Include(x => x.User)
										.Include(x => x.AssignedTo);

			if (request is null) return query.ToList();

			if (!string.IsNullOrEmpty(request.Summary))
			{
				query = query.Where(x => (EF.Functions.Like(x.Summary, $"%{ request.Summary}%")));
			}

			if (request.ProductId != null && request.ProductId.Count() > 0)
			{
				query = query.Where(x => request.ProductId.Contains(x.ProductId));
			}

			if (request.CategoryId != null && request.CategoryId.Count() > 0)
			{
				query = query.Where(x => request.CategoryId.Contains(x.CategoryId));
			}

			if (request.PriorityId != null && request.PriorityId.Count() > 0)
			{
				query = query.Where(x => request.PriorityId.Contains(x.PriorityId));
			}

			if (request.Status != null && request.Status.Count() > 0)
			{
				query = query.Where(x => request.Status.Contains(x.Status));
			}

			if (request.RaisedBy != null && request.RaisedBy.Count() > 0)
			{
				query = query.Where(x => request.RaisedBy.Contains(x.RaisedBy));
			}

			return query.OrderByDescending(x => x.RaisedDate).ToList();
		}

		public List<ChartResponse> Last12MonthsTickets()
		{
			var startMonth = DateTime.Now.AddMonths(-11);

			var query = _dbContext.Set<Ticket>()
						.Where(x => x.RaisedDate >= startMonth)
						.GroupBy(x => new { x.RaisedDate.Month, x.RaisedDate.Year })
						.Select(g => new
						{
							g.Key.Month,
							g.Key.Year,
							Count = g.Count()
						})
						.OrderBy(x => x.Year).ThenBy(x => x.Month)
						.ToList();

			return query.Select(x => new ChartResponse
						{
							Label = new DateTime(x.Year, x.Month, 1).ToString("MMM yyyy"),
							Value = x.Count
						}).ToList();
		}

		public List<ChartResponse> ChartByCategory(string category)
		{
			IQueryable<IGrouping<string, Ticket>> data;

			category = category.ToLower();

			switch(category)
			{
				case "category":
					data = _dbContext.Set<Ticket>().Include(x => x.Category).GroupBy(x => x.Category.CategoryName);
					break;
                case "product":
                    data = _dbContext.Set<Ticket>().Include(x => x.Product).GroupBy(x => x.Product.ProductName);
                    break;
                case "priority":
                    data = _dbContext.Set<Ticket>().Include(x => x.PriorityId).GroupBy(x => x.Priority.PriorityName);
                    break;
                default:
					return null;
			}

			return data.Select(x => new ChartResponse
						{
							Label = x.Key,
							Value = x.Count()
						}).ToList();
		}

		public List<ChartResponse> GetSummary()
		{
			return _dbContext.Set<Ticket>()
					.GroupBy(x => x.Status)
					.Select(x => new ChartResponse
					{
						Label = x.Key,
						Value = x.Count()
					}).ToList();
		}

        public Ticket FindTicket(int ticketId)
        {
			return _dbContext.Set<Ticket>()
				.Include(x => x.User)
				.Include(x => x.Attachments)
				.FirstOrDefault(x => x.TicketId == ticketId);
        }
    }
}
