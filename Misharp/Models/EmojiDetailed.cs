using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IEmojiDetailedModel
	{
		public string id { get; set; }
		public array aliases { get; set; }
		public string name { get; set; }
		public string? category { get; set; }
		public string? host { get; set; }
		public string url { get; set; }
		public string? license { get; set; }
		public bool isSensitive { get; set; }
		public bool localOnly { get; set; }
		public array roleIdsThatCanBeUsedThisEmojiAsReaction { get; set; }
	}
}
