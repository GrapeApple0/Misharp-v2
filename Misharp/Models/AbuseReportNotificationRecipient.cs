using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IAbuseReportNotificationRecipientModel
	{
		public string Id { get; set; }
		public bool IsActive { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string Name { get; set; }
		public AbuseReportNotificationRecipientMethodEnum Method { get; set; }
		public string UserId { get; set; }
		public UserLiteModel User { get; set; }
		public string SystemWebhookId { get; set; }
		public SystemWebhookModel SystemWebhook { get; set; }
	}

	public enum AbuseReportNotificationRecipientMethodEnum {
		[EnumMember(Value = "email")]
		Email,
		[EnumMember(Value = "webhook")]
		Webhook,
	}

	public class AbuseReportNotificationRecipientModel: IAbuseReportNotificationRecipientModel
	{
		public string Id { get; set; }
		public bool IsActive { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string Name { get; set; }
		public AbuseReportNotificationRecipientMethodEnum Method { get; set; }
		public string UserId { get; set; }
		public UserLiteModel User { get; set; }
		public string SystemWebhookId { get; set; }
		public SystemWebhookModel SystemWebhook { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
