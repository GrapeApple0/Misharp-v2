using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IUserModel: IUserLiteModel, IUserDetailedModel
	{
	}


	public class UserModel: IUserModel
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
		public bool RequireSigninToViewContents { get; set; }
		public decimal? MakeNotesFollowersOnlyBefore { get; set; }
		public decimal? MakeNotesHiddenBefore { get; set; }
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
		public static implicit operator UserLiteModel(UserModel user)
		{
			return new UserLiteModel()
			{
				Id = user.Id,
				Name = user.Name,
				Username = user.Username,
				Host = user.Host,
				AvatarUrl = user.AvatarUrl,
				AvatarBlurhash = user.AvatarBlurhash,
				AvatarDecorations = user.AvatarDecorations,
				IsBot = user.IsBot,
				IsCat = user.IsCat,
				RequireSigninToViewContents = user.RequireSigninToViewContents,
				MakeNotesFollowersOnlyBefore = user.MakeNotesFollowersOnlyBefore,
				MakeNotesHiddenBefore = user.MakeNotesHiddenBefore,
				Instance = user.Instance,
				Emojis = user.Emojis,
				OnlineStatus = user.OnlineStatus,
				BadgeRoles = user.BadgeRoles,
			};
		}
		public static implicit operator UserDetailedModel(UserModel user)
		{
			return new UserDetailedModel()
			{
				Id = user.Id,
				Name = user.Name,
				Username = user.Username,
				Host = user.Host,
				AvatarUrl = user.AvatarUrl,
				AvatarBlurhash = user.AvatarBlurhash,
				AvatarDecorations = user.AvatarDecorations,
				IsBot = user.IsBot,
				IsCat = user.IsCat,
				RequireSigninToViewContents = user.RequireSigninToViewContents,
				MakeNotesFollowersOnlyBefore = user.MakeNotesFollowersOnlyBefore,
				MakeNotesHiddenBefore = user.MakeNotesHiddenBefore,
				Instance = user.Instance,
				Emojis = user.Emojis,
				OnlineStatus = user.OnlineStatus,
				BadgeRoles = user.BadgeRoles,
				Url = user.Url,
				Uri = user.Uri,
				MovedTo = user.MovedTo,
				AlsoKnownAs = user.AlsoKnownAs,
				CreatedAt = user.CreatedAt,
				UpdatedAt = user.UpdatedAt,
				LastFetchedAt = user.LastFetchedAt,
				BannerUrl = user.BannerUrl,
				BannerBlurhash = user.BannerBlurhash,
				IsLocked = user.IsLocked,
				IsSilenced = user.IsSilenced,
				IsSuspended = user.IsSuspended,
				Description = user.Description,
				Location = user.Location,
				Birthday = user.Birthday,
				Lang = user.Lang,
				Fields = user.Fields,
				VerifiedLinks = user.VerifiedLinks,
				FollowersCount = user.FollowersCount,
				FollowingCount = user.FollowingCount,
				NotesCount = user.NotesCount,
				PinnedNoteIds = user.PinnedNoteIds,
				PinnedNotes = user.PinnedNotes,
				PinnedPageId = user.PinnedPageId,
				PinnedPage = user.PinnedPage,
				PublicReactions = user.PublicReactions,
				FollowingVisibility = user.FollowingVisibility,
				FollowersVisibility = user.FollowersVisibility,
				Roles = user.Roles,
				FollowedMessage = user.FollowedMessage,
				Memo = user.Memo,
				ModerationNote = user.ModerationNote,
				TwoFactorEnabled = user.TwoFactorEnabled,
				UsePasswordLessLogin = user.UsePasswordLessLogin,
				SecurityKeys = user.SecurityKeys,
				IsFollowing = user.IsFollowing,
				IsFollowed = user.IsFollowed,
				HasPendingFollowRequestFromYou = user.HasPendingFollowRequestFromYou,
				HasPendingFollowRequestToYou = user.HasPendingFollowRequestToYou,
				IsBlocking = user.IsBlocking,
				IsBlocked = user.IsBlocked,
				IsMuted = user.IsMuted,
				IsRenoteMuted = user.IsRenoteMuted,
				Notify = user.Notify,
				WithReplies = user.WithReplies,
				AvatarId = user.AvatarId,
				BannerId = user.BannerId,
				IsModerator = user.IsModerator,
				IsAdmin = user.IsAdmin,
				InjectFeaturedNote = user.InjectFeaturedNote,
				ReceiveAnnouncementEmail = user.ReceiveAnnouncementEmail,
				AlwaysMarkNsfw = user.AlwaysMarkNsfw,
				AutoSensitive = user.AutoSensitive,
				CarefulBot = user.CarefulBot,
				AutoAcceptFollowed = user.AutoAcceptFollowed,
				NoCrawle = user.NoCrawle,
				PreventAiLearning = user.PreventAiLearning,
				IsExplorable = user.IsExplorable,
				IsDeleted = user.IsDeleted,
				TwoFactorBackupCodesStock = user.TwoFactorBackupCodesStock,
				HideOnlineStatus = user.HideOnlineStatus,
				HasUnreadSpecifiedNotes = user.HasUnreadSpecifiedNotes,
				HasUnreadMentions = user.HasUnreadMentions,
				HasUnreadAnnouncement = user.HasUnreadAnnouncement,
				UnreadAnnouncements = user.UnreadAnnouncements,
				HasUnreadAntenna = user.HasUnreadAntenna,
				HasUnreadChannel = user.HasUnreadChannel,
				HasUnreadNotification = user.HasUnreadNotification,
				HasPendingReceivedFollowRequest = user.HasPendingReceivedFollowRequest,
				UnreadNotificationsCount = user.UnreadNotificationsCount,
				MutedWords = user.MutedWords,
				HardMutedWords = user.HardMutedWords,
				MutedInstances = user.MutedInstances,
				NotificationRecieveConfig = user.NotificationRecieveConfig,
				EmailNotificationTypes = user.EmailNotificationTypes,
				Achievements = user.Achievements,
				LoggedInDays = user.LoggedInDays,
				Policies = user.Policies,
				Email = user.Email,
				EmailVerified = user.EmailVerified,
				SecurityKeysList = user.SecurityKeysList,
			};
		}
	}
}
