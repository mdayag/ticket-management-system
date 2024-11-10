using Domain.DTO.Request;
using Domain.DTO.Response;
using Domain.Entities;
using Domain.IRepository;
using Domain.IService;
using Infrastructure.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Infrastructure.Services
{
	public class TicketService : ITicketService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IHttpContextAccessor _httpContextAccessor;
		private readonly IWebHostEnvironment _webHostEnvironment;

        public TicketService(IUnitOfWork unitOfWork, 
			IHttpContextAccessor httpContextAccessor,
            IWebHostEnvironment webHostEnvironment
            )
        {
			_unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
            _webHostEnvironment = webHostEnvironment;
        }

		public async Task<BaseResponse<int>> CreateTicket(CreateTicketRequest request)
        {
			var createTicketResult = new BaseResponse<int>() { IsSuccess = false };
			var uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads", "attachments");

			try
			{
				var currentUser = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;

				if (currentUser == null)
				{
                    createTicketResult.ErrorMessage = "User is not valid, please re-login";

                    return createTicketResult;
                }

				var priority = _unitOfWork.Repository<Priority>().GetByIdAsync(request.PriorityId.Value);

                Ticket ticket = new()
                {
					Summary = request.Summary,
					Description = request.Description,
					ProductId = request.ProductId.Value,
					CategoryId = request.CategoryId.Value,
					PriorityId = request.PriorityId.Value,
					AssignedToId = request.AssignedToId,
					RaisedBy = currentUser,
					Status = Constants.STATUS_NEW,
					ExpectedDate = priority != null ? DateTime.Now.AddDays(priority.ExpectedDays): DateTime.Now
				};

				_unitOfWork.TicketRepository.Add(ticket);

				if (request.files != null && request.files.Count > 0)
				{
					foreach(var file in request.files)
					{
						var fileExt = Path.GetExtension(file.Name);
						var actualName = Path.GetFileNameWithoutExtension(file.Name);
						var fileName = $"{actualName}-{Guid.NewGuid().ToString()}{fileExt}";
						var filePath = Path.Combine(uploadPath, fileName);

						using (var fileStream = new FileStream(filePath, FileMode.Create))
						{
							await file.OpenReadStream().CopyToAsync(fileStream);
						}

						Attachment attachment = new()
						{
							Ticket = ticket,
							FileName = Path.GetFileName(file.Name),
							ServerFileName = fileName,
							FileSize = file.Size,
							CreatedDate = DateTime.Now
						};

						_unitOfWork.Repository<Attachment>().Add(attachment);
					}
				}

				var result = await _unitOfWork.SaveChanges() > 0;

				if (result)
				{
                    createTicketResult.IsSuccess = true;
					createTicketResult.Value = ticket.TicketId;
                }
				else
				{
					createTicketResult.ErrorMessage = "Failed to create ticket!";
                }
			}
			catch(Exception ex)
			{
				createTicketResult.ErrorMessage = string.Concat("Failed: ", ex.Message);

				return createTicketResult;
			}

            return createTicketResult;
        }

        public GetTicketResponse FindTicket(int ticketId)
		{
			var result = _unitOfWork.TicketRepository.FindTicket(ticketId);

			if (result is null) return null;

			var attachmentPath = Path.Combine("uploads", "attachments");

			return new GetTicketResponse
			{
				TicketId = result.TicketId,
				Summary = result.Summary,
				Description = result.Description,
				ProductId = result.ProductId,
				PriorityId = result.PriorityId,
				CategoryId = result.CategoryId,
				Status = result.Status,
				AssignedToId = result.AssignedToId,
				RaisedBy = result.User?.Id,
				RaisedByName = result.User?.Email,
				RaisedByAvatar = result.User?.Avatar,
				CreatedDate = result.RaisedDate,
				ExpectedDate = result.ExpectedDate,
				ClosedBy = result.ClosedBy,
				ClosedDate = result.ClosedDate,
				Attachments = result.Attachments.Select(x => new AttachmentResponse
				{
					FileName = x.FileName,
					ServerFileName = Path.Combine(attachmentPath, x.ServerFileName)
                }).ToList()
			};
		}

		public List<GetTicketResponse> GetTickets(GetTicketRequest request)
		{
			var result = _unitOfWork.TicketRepository.GetTickets(request);

			return result.Select(x => new GetTicketResponse 
			{
				TicketId = x.TicketId,
				Summary = x.Summary,
				Product = x.Product?.ProductName,
				Priority = x.Priority?.PriorityName,
				Category = x.Category?.CategoryName,
				Status = x.Status,
				RaisedBy = x.User?.Email,
				CreatedDate = x.RaisedDate,
				ExpectedDate = x.ExpectedDate
			}).ToList();
		}

		public async Task<BaseResponse> UpdateTicket(UpdateTicketRequest request)
        {
            var result = new BaseResponse();
			result.IsSuccess = false;

			var currentTicket = _unitOfWork.TicketRepository.GetByIdAsync(request.TicketId);

            if (currentTicket == null)
            {
				result.ErrorMessage = "Ticket Not Found!";

				return result;
            }

			currentTicket.ProductId = request.ProductId.Value;
            currentTicket.CategoryId = request.CategoryId.Value;
            currentTicket.PriorityId = request.PriorityId.Value;
            currentTicket.AssignedToId = request.AssignedToId;

			currentTicket.Status = request.Status;
			currentTicket.LastUpdateDate = DateTime.Now;

			if (request.Status == Constants.STATUS_CLOSED)
			{
				currentTicket.ClosedDate = DateTime.Now;

                var currentUser = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name).Value;

                if (currentUser != null)
                {
                    result.ErrorMessage = "User is not valid, please re-login";

                    return result;
                }

				currentTicket.ClosedBy = currentUser;
            }

			_unitOfWork.TicketRepository.Update(currentTicket);

			var dbResult = await _unitOfWork.SaveChanges() > 0;

			if(dbResult)
			{
				result.IsSuccess = true;
			}
			else
			{
				result.ErrorMessage = "Failed saving to database!";
			}

			return result;
        }

		public List<ChartResponse> Last12MonthsTickets()
		{
			return _unitOfWork.TicketRepository.Last12MonthsTickets();
		}

		public List<ChartResponse> ChartByCategory(string category)
		{
			return _unitOfWork.TicketRepository.ChartByCategory(category);
		}

		public List<ChartResponse> GetSummary()
		{
			return _unitOfWork.TicketRepository.GetSummary();
		}
	}
}
