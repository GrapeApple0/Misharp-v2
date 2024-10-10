using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IInviteCodeModel
	{
		public string id { get; set; }
		public string code { get; set; }
		public DateTime? expiresAt { get; set; }
		public DateTime createdAt { get; set; }
		public object? createdBy { get; set; }
		public object? usedBy { get; set; }
		public DateTime? usedAt { get; set; }
		public bool used { get; set; }
	}
}
