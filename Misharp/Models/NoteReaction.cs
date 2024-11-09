using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface INoteReactionModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public UserLiteModel User { get; set; }
		public string Type { get; set; }
	}


	public class NoteReactionModel: INoteReactionModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public UserLiteModel User { get; set; }
		public string Type { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
