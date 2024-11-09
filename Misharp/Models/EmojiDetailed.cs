using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IEmojiDetailedModel
	{
		public string Id { get; set; }
		public List<string> Aliases { get; set; }
		public string Name { get; set; }
		public string? Category { get; set; }
		public string? Host { get; set; }
		public string Url { get; set; }
		public string? License { get; set; }
		public bool IsSensitive { get; set; }
		public bool LocalOnly { get; set; }
		public List<string> RoleIdsThatCanBeUsedThisEmojiAsReaction { get; set; }
	}


	public class EmojiDetailedModel: IEmojiDetailedModel
	{
		public string Id { get; set; }
		public List<string> Aliases { get; set; }
		public string Name { get; set; }
		public string? Category { get; set; }
		public string? Host { get; set; }
		public string Url { get; set; }
		public string? License { get; set; }
		public bool IsSensitive { get; set; }
		public bool LocalOnly { get; set; }
		public List<string> RoleIdsThatCanBeUsedThisEmojiAsReaction { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
