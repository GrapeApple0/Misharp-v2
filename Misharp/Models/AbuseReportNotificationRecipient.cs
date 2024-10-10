using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IAbuseReportNotificationRecipientModel
	{
		public string id { get; set; }
		public bool isActive { get; set; }
		public DateTime updatedAt { get; set; }
		public string name { get; set; }
		public string method { get; set; }
		public string userId { get; set; }
		public object user { get; set; }
		public string systemWebhookId { get; set; }
		public object systemWebhook { get; set; }
	}
}
