using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class Attachment
	{
		[Key]
		public int AttachmentId { get; set; }

		public string FileName { get; set; } = string.Empty;

		public string ServerFileName { get; set; } = string.Empty;

		public long FileSize { get; set; }

		public DateTime CreatedDate { get; set; }

		[ForeignKey(nameof(Ticket))]
		public int? TicketId { get; set; }

		public Ticket Ticket { get; set; }

		[ForeignKey(nameof(Discussion))]
		public int? DiscussionId { get; set; }

		public Discussion Discussion { get; set; }
	}
}
