using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface INoteModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? DeletedAt { get; set; }
		public string? Text { get; set; }
		public string? Cw { get; set; }
		public string UserId { get; set; }
		public UserLiteModel User { get; set; }
		public string? ReplyId { get; set; }
		public string? RenoteId { get; set; }
		public NoteModel Reply { get; set; }
		public NoteModel Renote { get; set; }
		public bool IsHidden { get; set; }
		public NoteVisibilityEnum Visibility { get; set; }
		public List<string> Mentions { get; set; }
		public List<string> VisibleUserIds { get; set; }
		public List<string> FileIds { get; set; }
		public List<DriveFileModel> Files { get; set; }
		public List<string> Tags { get; set; }
		public NotePollModel Poll { get; set; }
		public Dictionary<string, string> Emojis { get; set; }
		public string? ChannelId { get; set; }
		public NoteChannelModel Channel { get; set; }
		public bool LocalOnly { get; set; }
		public NoteReactionAcceptanceEnum? ReactionAcceptance { get; set; }
		public Dictionary<string, string> ReactionEmojis { get; set; }
		public Dictionary<string, decimal> Reactions { get; set; }
		public decimal ReactionCount { get; set; }
		public decimal RenoteCount { get; set; }
		public decimal RepliesCount { get; set; }
		public string Uri { get; set; }
		public string Url { get; set; }
		public List<string> ReactionAndUserPairCache { get; set; }
		public decimal ClippedCount { get; set; }
		public string? MyReaction { get; set; }
	}

	public enum NoteVisibilityEnum {
		[EnumMember(Value = "public")]
		Public,
		[EnumMember(Value = "home")]
		Home,
		[EnumMember(Value = "followers")]
		Followers,
		[EnumMember(Value = "specified")]
		Specified,
	}
	public interface INotePollChoicesItemsModel
	{
		public bool IsVoted { get; set; }
		public string Text { get; set; }
		public decimal Votes { get; set; }
	}
	public class NotePollChoicesItemsModel: INotePollChoicesItemsModel
	{
		public bool IsVoted { get; set; }
		public string Text { get; set; }
		public decimal Votes { get; set; }
	}
	public interface INotePollModel
	{
		public DateTime? ExpiresAt { get; set; }
		public bool Multiple { get; set; }
		public List<NotePollChoicesItemsModel> Choices { get; set; }
	}
	public class NotePollModel: INotePollModel
	{
		public DateTime? ExpiresAt { get; set; }
		public bool Multiple { get; set; }
		public List<NotePollChoicesItemsModel> Choices { get; set; }
	}
	public interface INoteChannelModel
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Color { get; set; }
		public bool IsSensitive { get; set; }
		public bool AllowRenoteToExternal { get; set; }
		public string? UserId { get; set; }
	}
	public class NoteChannelModel: INoteChannelModel
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Color { get; set; }
		public bool IsSensitive { get; set; }
		public bool AllowRenoteToExternal { get; set; }
		public string? UserId { get; set; }
	}
	public enum NoteReactionAcceptanceEnum {
		[EnumMember(Value = "likeOnly")]
		LikeOnly,
		[EnumMember(Value = "likeOnlyForRemote")]
		LikeOnlyForRemote,
		[EnumMember(Value = "nonSensitiveOnly")]
		NonSensitiveOnly,
		[EnumMember(Value = "nonSensitiveOnlyForLocalLikeOnlyForRemote")]
		NonSensitiveOnlyForLocalLikeOnlyForRemote,
	}

	public class NoteModel: INoteModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? DeletedAt { get; set; }
		public string? Text { get; set; }
		public string? Cw { get; set; }
		public string UserId { get; set; }
		public UserLiteModel User { get; set; }
		public string? ReplyId { get; set; }
		public string? RenoteId { get; set; }
		public NoteModel Reply { get; set; }
		public NoteModel Renote { get; set; }
		public bool IsHidden { get; set; }
		public NoteVisibilityEnum Visibility { get; set; }
		public List<string> Mentions { get; set; }
		public List<string> VisibleUserIds { get; set; }
		public List<string> FileIds { get; set; }
		public List<DriveFileModel> Files { get; set; }
		public List<string> Tags { get; set; }
		public NotePollModel Poll { get; set; }
		public Dictionary<string, string> Emojis { get; set; }
		public string? ChannelId { get; set; }
		public NoteChannelModel Channel { get; set; }
		public bool LocalOnly { get; set; }
		public NoteReactionAcceptanceEnum? ReactionAcceptance { get; set; }
		public Dictionary<string, string> ReactionEmojis { get; set; }
		public Dictionary<string, decimal> Reactions { get; set; }
		public decimal ReactionCount { get; set; }
		public decimal RenoteCount { get; set; }
		public decimal RepliesCount { get; set; }
		public string Uri { get; set; }
		public string Url { get; set; }
		public List<string> ReactionAndUserPairCache { get; set; }
		public decimal ClippedCount { get; set; }
		public string? MyReaction { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
