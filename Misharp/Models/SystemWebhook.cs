using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface ISystemWebhookModel
	{
		public string Id { get; set; }
		public bool IsActive { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public DateTime? LatestSentAt { get; set; }
		public decimal? LatestStatus { get; set; }
		public string Name { get; set; }
		public List<string> On { get; set; }
		public string Url { get; set; }
		public string Secret { get; set; }
	}


	public class SystemWebhookModel: ISystemWebhookModel
	{
		public string Id { get; set; }
		public bool IsActive { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public DateTime? LatestSentAt { get; set; }
		public decimal? LatestStatus { get; set; }
		public string Name { get; set; }
		public List<string> On { get; set; }
		public string Url { get; set; }
		public string Secret { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
