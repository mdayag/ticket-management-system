﻿using Domain.Entities;

namespace Domain.DTO.Response
{
	public class GetTicketResponse
	{
		public int TicketId { get; set; }

        public string TicketIdView
		{
			get
			{
				return string.Concat("T", TicketId.ToString().PadLeft(5, '0'));
			}
		}

		public string Summary { get; set; }

		public string Description { get; set; }
		public string Product { get; set; }

		public int ProductId { get; set; }

		public string Category { get; set; }

		public int CategoryId { get; set; }

		public string Priority { get; set; }

		public int PriorityId { get; set; }

		public string Status { get; set; }

        public string AssignedToId { get; set; }

        public string RaisedBy { get; set; }

        public string RaisedByName { get; set; }

        public string? RaisedByAvatar { get; set; }

        public DateTime ExpectedDate { get; set; }

		public DateTime CreatedDate { get; set; }

        public string? ClosedBy { get; set; }

        public DateTime? ClosedDate { get; set; }

        public IList<AttachmentResponse> Attachments { get; set; }
    }

	public class AttachmentResponse()
	{
        public string FileName { get; set; }

        public string ServerFileName { get; set; }
    }
}
