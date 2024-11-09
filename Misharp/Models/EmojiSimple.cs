using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IEmojiSimpleModel
	{
		public List<string> Aliases { get; set; }
		public string Name { get; set; }
		public string? Category { get; set; }
		public string Url { get; set; }
		public bool LocalOnly { get; set; }
		public bool IsSensitive { get; set; }
		public List<string> RoleIdsThatCanBeUsedThisEmojiAsReaction { get; set; }
	}


	public class EmojiSimpleModel: IEmojiSimpleModel
	{
		public List<string> Aliases { get; set; }
		public string Name { get; set; }
		public string? Category { get; set; }
		public string Url { get; set; }
		public bool LocalOnly { get; set; }
		public bool IsSensitive { get; set; }
		public List<string> RoleIdsThatCanBeUsedThisEmojiAsReaction { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
