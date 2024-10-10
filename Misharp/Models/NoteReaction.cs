using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface INoteReactionModel
	{
		public string id { get; set; }
		public DateTime createdAt { get; set; }
		public object user { get; set; }
		public string type { get; set; }
	}
}
