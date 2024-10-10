using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IEmojiSimpleModel
	{
		public array aliases { get; set; }
		public string name { get; set; }
		public string? category { get; set; }
		public string url { get; set; }
		public bool localOnly { get; set; }
		public bool isSensitive { get; set; }
		public array roleIdsThatCanBeUsedThisEmojiAsReaction { get; set; }
	}
}
