using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IMutingModel
	{
		public string id { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime? expiresAt { get; set; }
		public string muteeId { get; set; }
		public object mutee { get; set; }
	}
}
