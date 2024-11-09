using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IInviteCodeModel
	{
		public string Id { get; set; }
		public string Code { get; set; }
		public DateTime? ExpiresAt { get; set; }
		public DateTime? CreatedAt { get; set; }
		public UserLiteModel CreatedBy { get; set; }
		public UserLiteModel UsedBy { get; set; }
		public DateTime? UsedAt { get; set; }
		public bool Used { get; set; }
	}


	public class InviteCodeModel: IInviteCodeModel
	{
		public string Id { get; set; }
		public string Code { get; set; }
		public DateTime? ExpiresAt { get; set; }
		public DateTime? CreatedAt { get; set; }
		public UserLiteModel CreatedBy { get; set; }
		public UserLiteModel UsedBy { get; set; }
		public DateTime? UsedAt { get; set; }
		public bool Used { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
