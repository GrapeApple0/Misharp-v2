using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface INoteModel
	{
		public string id { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime? deletedAt { get; set; }
		public string? text { get; set; }
		public string? cw { get; set; }
		public string userId { get; set; }
		public object user { get; set; }
		public string? replyId { get; set; }
		public string? renoteId { get; set; }
		public object? reply { get; set; }
		public object? renote { get; set; }
		public bool isHidden { get; set; }
		public string visibility { get; set; }
		public array mentions { get; set; }
		public array visibleUserIds { get; set; }
		public array fileIds { get; set; }
		public array files { get; set; }
		public array tags { get; set; }
		public object? poll { get; set; }
		public object emojis { get; set; }
		public string? channelId { get; set; }
		public object? channel { get; set; }
		public bool localOnly { get; set; }
		public string? reactionAcceptance { get; set; }
		public object reactionEmojis { get; set; }
		public object reactions { get; set; }
		public decimal reactionCount { get; set; }
		public decimal renoteCount { get; set; }
		public decimal repliesCount { get; set; }
		public string uri { get; set; }
		public string url { get; set; }
		public array reactionAndUserPairCache { get; set; }
		public decimal clippedCount { get; set; }
		public string? myReaction { get; set; }
	}
}
