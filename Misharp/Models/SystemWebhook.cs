using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface ISystemWebhookModel
	{
		public string id { get; set; }
		public bool isActive { get; set; }
		public DateTime updatedAt { get; set; }
		public DateTime? latestSentAt { get; set; }
		public decimal? latestStatus { get; set; }
		public string name { get; set; }
		public array on { get; set; }
		public string url { get; set; }
		public string secret { get; set; }
	}
}
