using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IUserDetailedNotMeOnlyModel
	{
		public Uri? Url { get; set; }
		public string? Uri { get; set; }
		public string? MovedTo { get; set; }
		public List<string> AlsoKnownAs { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public DateTime? LastFetchedAt { get; set; }
		public Uri? BannerUrl { get; set; }
		public string? BannerBlurhash { get; set; }
		public bool IsLocked { get; set; }
		public bool IsSilenced { get; set; }
		public bool IsSuspended { get; set; }
		public string? Description { get; set; }
		public string? Location { get; set; }
		public string? Birthday { get; set; }
		public string? Lang { get; set; }
		public List<UserDetailedNotMeOnlyFieldsItemsModel> Fields { get; set; }
		public List<Uri> VerifiedLinks { get; set; }
		public decimal FollowersCount { get; set; }
		public decimal FollowingCount { get; set; }
		public decimal NotesCount { get; set; }
		public List<string> PinnedNoteIds { get; set; }
		public List<NoteModel> PinnedNotes { get; set; }
		public string? PinnedPageId { get; set; }
		public PageModel PinnedPage { get; set; }
		public bool PublicReactions { get; set; }
		public UserDetailedNotMeOnlyFollowingVisibilityEnum FollowingVisibility { get; set; }
		public UserDetailedNotMeOnlyFollowersVisibilityEnum FollowersVisibility { get; set; }
		public List<RoleLiteModel> Roles { get; set; }
		public string? FollowedMessage { get; set; }
		public string? Memo { get; set; }
		public string ModerationNote { get; set; }
		public bool TwoFactorEnabled { get; set; }
		public bool UsePasswordLessLogin { get; set; }
		public bool SecurityKeys { get; set; }
		public bool IsFollowing { get; set; }
		public bool IsFollowed { get; set; }
		public bool HasPendingFollowRequestFromYou { get; set; }
		public bool HasPendingFollowRequestToYou { get; set; }
		public bool IsBlocking { get; set; }
		public bool IsBlocked { get; set; }
		public bool IsMuted { get; set; }
		public bool IsRenoteMuted { get; set; }
		public UserDetailedNotMeOnlyNotifyEnum Notify { get; set; }
		public bool WithReplies { get; set; }
	}

	public interface IUserDetailedNotMeOnlyFieldsItemsModel
	{
		public string Name { get; set; }
		public string Value { get; set; }
	}
	public class UserDetailedNotMeOnlyFieldsItemsModel: IUserDetailedNotMeOnlyFieldsItemsModel
	{
		public string Name { get; set; }
		public string Value { get; set; }
	}
	public enum UserDetailedNotMeOnlyFollowingVisibilityEnum {
		[EnumMember(Value = "public")]
		Public,
		[EnumMember(Value = "followers")]
		Followers,
		[EnumMember(Value = "private")]
		Private,
	}
	public enum UserDetailedNotMeOnlyFollowersVisibilityEnum {
		[EnumMember(Value = "public")]
		Public,
		[EnumMember(Value = "followers")]
		Followers,
		[EnumMember(Value = "private")]
		Private,
	}
	public enum UserDetailedNotMeOnlyNotifyEnum {
		[EnumMember(Value = "normal")]
		Normal,
		[EnumMember(Value = "none")]
		None,
	}

	public class UserDetailedNotMeOnlyModel: IUserDetailedNotMeOnlyModel
	{
		public Uri? Url { get; set; }
		public string? Uri { get; set; }
		public string? MovedTo { get; set; }
		public List<string> AlsoKnownAs { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public DateTime? LastFetchedAt { get; set; }
		public Uri? BannerUrl { get; set; }
		public string? BannerBlurhash { get; set; }
		public bool IsLocked { get; set; }
		public bool IsSilenced { get; set; }
		public bool IsSuspended { get; set; }
		public string? Description { get; set; }
		public string? Location { get; set; }
		public string? Birthday { get; set; }
		public string? Lang { get; set; }
		public List<UserDetailedNotMeOnlyFieldsItemsModel> Fields { get; set; }
		public List<Uri> VerifiedLinks { get; set; }
		public decimal FollowersCount { get; set; }
		public decimal FollowingCount { get; set; }
		public decimal NotesCount { get; set; }
		public List<string> PinnedNoteIds { get; set; }
		public List<NoteModel> PinnedNotes { get; set; }
		public string? PinnedPageId { get; set; }
		public PageModel PinnedPage { get; set; }
		public bool PublicReactions { get; set; }
		public UserDetailedNotMeOnlyFollowingVisibilityEnum FollowingVisibility { get; set; }
		public UserDetailedNotMeOnlyFollowersVisibilityEnum FollowersVisibility { get; set; }
		public List<RoleLiteModel> Roles { get; set; }
		public string? FollowedMessage { get; set; }
		public string? Memo { get; set; }
		public string ModerationNote { get; set; }
		public bool TwoFactorEnabled { get; set; }
		public bool UsePasswordLessLogin { get; set; }
		public bool SecurityKeys { get; set; }
		public bool IsFollowing { get; set; }
		public bool IsFollowed { get; set; }
		public bool HasPendingFollowRequestFromYou { get; set; }
		public bool HasPendingFollowRequestToYou { get; set; }
		public bool IsBlocking { get; set; }
		public bool IsBlocked { get; set; }
		public bool IsMuted { get; set; }
		public bool IsRenoteMuted { get; set; }
		public UserDetailedNotMeOnlyNotifyEnum Notify { get; set; }
		public bool WithReplies { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
