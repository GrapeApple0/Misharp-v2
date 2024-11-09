using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IUserDetailedModel: IUserDetailedNotMeModel, IMeDetailedModel
	{
	}


	public class UserDetailedModel: IUserDetailedModel
	{
		public string Id { get; set; }
		public string? Name { get; set; }
		public string Username { get; set; }
		public string? Host { get; set; }
		public Uri? AvatarUrl { get; set; }
		public string? AvatarBlurhash { get; set; }
		public List<UserLiteAvatarDecorationsItemsModel> AvatarDecorations { get; set; }
		public bool IsBot { get; set; }
		public bool IsCat { get; set; }
		public UserLiteInstanceModel Instance { get; set; }
		public Dictionary<string, string> Emojis { get; set; }
		public UserLiteOnlineStatusEnum OnlineStatus { get; set; }
		public List<UserLiteBadgeRolesItemsModel> BadgeRoles { get; set; }
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
		public string? AvatarId { get; set; }
		public string? BannerId { get; set; }
		public bool? IsModerator { get; set; }
		public bool? IsAdmin { get; set; }
		public bool InjectFeaturedNote { get; set; }
		public bool ReceiveAnnouncementEmail { get; set; }
		public bool AlwaysMarkNsfw { get; set; }
		public bool AutoSensitive { get; set; }
		public bool CarefulBot { get; set; }
		public bool AutoAcceptFollowed { get; set; }
		public bool NoCrawle { get; set; }
		public bool PreventAiLearning { get; set; }
		public bool IsExplorable { get; set; }
		public bool IsDeleted { get; set; }
		public MeDetailedOnlyTwoFactorBackupCodesStockEnum TwoFactorBackupCodesStock { get; set; }
		public bool HideOnlineStatus { get; set; }
		public bool HasUnreadSpecifiedNotes { get; set; }
		public bool HasUnreadMentions { get; set; }
		public bool HasUnreadAnnouncement { get; set; }
		public List<AnnouncementModel> UnreadAnnouncements { get; set; }
		public bool HasUnreadAntenna { get; set; }
		public bool HasUnreadChannel { get; set; }
		public bool HasUnreadNotification { get; set; }
		public bool HasPendingReceivedFollowRequest { get; set; }
		public decimal UnreadNotificationsCount { get; set; }
		public List<List<List<string>>> MutedWords { get; set; }
		public List<List<List<string>>> HardMutedWords { get; set; }
		public List<string> MutedInstances { get; set; }
		public MeDetailedOnlyNotificationRecieveConfigModel NotificationRecieveConfig { get; set; }
		public List<string> EmailNotificationTypes { get; set; }
		public List<MeDetailedOnlyAchievementsItemsModel> Achievements { get; set; }
		public decimal LoggedInDays { get; set; }
		public RolePoliciesModel Policies { get; set; }
		public string? Email { get; set; }
		public bool? EmailVerified { get; set; }
		public List<MeDetailedOnlySecurityKeysListItemsModel> SecurityKeysList { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
