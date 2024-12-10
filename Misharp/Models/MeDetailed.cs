using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IMeDetailedModel: IUserLiteModel, IUserDetailedNotMeOnlyModel, IMeDetailedOnlyModel
	{
	}


	public class MeDetailedModel: IMeDetailedModel
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
		public static implicit operator UserLiteModel(MeDetailedModel meDetailed)
		{
			return new UserLiteModel()
			{
				Id = meDetailed.Id,
				Name = meDetailed.Name,
				Username = meDetailed.Username,
				Host = meDetailed.Host,
				AvatarUrl = meDetailed.AvatarUrl,
				AvatarBlurhash = meDetailed.AvatarBlurhash,
				AvatarDecorations = meDetailed.AvatarDecorations,
				IsBot = meDetailed.IsBot,
				IsCat = meDetailed.IsCat,
				RequireSigninToViewContents = meDetailed.RequireSigninToViewContents,
				MakeNotesFollowersOnlyBefore = meDetailed.MakeNotesFollowersOnlyBefore,
				MakeNotesHiddenBefore = meDetailed.MakeNotesHiddenBefore,
				Instance = meDetailed.Instance,
				Emojis = meDetailed.Emojis,
				OnlineStatus = meDetailed.OnlineStatus,
				BadgeRoles = meDetailed.BadgeRoles,
			};
		}
		public static implicit operator UserDetailedNotMeOnlyModel(MeDetailedModel meDetailed)
		{
			return new UserDetailedNotMeOnlyModel()
			{
				Url = meDetailed.Url,
				Uri = meDetailed.Uri,
				MovedTo = meDetailed.MovedTo,
				AlsoKnownAs = meDetailed.AlsoKnownAs,
				CreatedAt = meDetailed.CreatedAt,
				UpdatedAt = meDetailed.UpdatedAt,
				LastFetchedAt = meDetailed.LastFetchedAt,
				BannerUrl = meDetailed.BannerUrl,
				BannerBlurhash = meDetailed.BannerBlurhash,
				IsLocked = meDetailed.IsLocked,
				IsSilenced = meDetailed.IsSilenced,
				IsSuspended = meDetailed.IsSuspended,
				Description = meDetailed.Description,
				Location = meDetailed.Location,
				Birthday = meDetailed.Birthday,
				Lang = meDetailed.Lang,
				Fields = meDetailed.Fields,
				VerifiedLinks = meDetailed.VerifiedLinks,
				FollowersCount = meDetailed.FollowersCount,
				FollowingCount = meDetailed.FollowingCount,
				NotesCount = meDetailed.NotesCount,
				PinnedNoteIds = meDetailed.PinnedNoteIds,
				PinnedNotes = meDetailed.PinnedNotes,
				PinnedPageId = meDetailed.PinnedPageId,
				PinnedPage = meDetailed.PinnedPage,
				PublicReactions = meDetailed.PublicReactions,
				FollowingVisibility = meDetailed.FollowingVisibility,
				FollowersVisibility = meDetailed.FollowersVisibility,
				Roles = meDetailed.Roles,
				FollowedMessage = meDetailed.FollowedMessage,
				Memo = meDetailed.Memo,
				ModerationNote = meDetailed.ModerationNote,
				TwoFactorEnabled = meDetailed.TwoFactorEnabled,
				UsePasswordLessLogin = meDetailed.UsePasswordLessLogin,
				SecurityKeys = meDetailed.SecurityKeys,
				IsFollowing = meDetailed.IsFollowing,
				IsFollowed = meDetailed.IsFollowed,
				HasPendingFollowRequestFromYou = meDetailed.HasPendingFollowRequestFromYou,
				HasPendingFollowRequestToYou = meDetailed.HasPendingFollowRequestToYou,
				IsBlocking = meDetailed.IsBlocking,
				IsBlocked = meDetailed.IsBlocked,
				IsMuted = meDetailed.IsMuted,
				IsRenoteMuted = meDetailed.IsRenoteMuted,
				Notify = meDetailed.Notify,
				WithReplies = meDetailed.WithReplies,
			};
		}
		public static implicit operator MeDetailedOnlyModel(MeDetailedModel meDetailed)
		{
			return new MeDetailedOnlyModel()
			{
				AvatarId = meDetailed.AvatarId,
				BannerId = meDetailed.BannerId,
				FollowedMessage = meDetailed.FollowedMessage,
				IsModerator = meDetailed.IsModerator,
				IsAdmin = meDetailed.IsAdmin,
				InjectFeaturedNote = meDetailed.InjectFeaturedNote,
				ReceiveAnnouncementEmail = meDetailed.ReceiveAnnouncementEmail,
				AlwaysMarkNsfw = meDetailed.AlwaysMarkNsfw,
				AutoSensitive = meDetailed.AutoSensitive,
				CarefulBot = meDetailed.CarefulBot,
				AutoAcceptFollowed = meDetailed.AutoAcceptFollowed,
				NoCrawle = meDetailed.NoCrawle,
				PreventAiLearning = meDetailed.PreventAiLearning,
				IsExplorable = meDetailed.IsExplorable,
				IsDeleted = meDetailed.IsDeleted,
				TwoFactorBackupCodesStock = meDetailed.TwoFactorBackupCodesStock,
				HideOnlineStatus = meDetailed.HideOnlineStatus,
				HasUnreadSpecifiedNotes = meDetailed.HasUnreadSpecifiedNotes,
				HasUnreadMentions = meDetailed.HasUnreadMentions,
				HasUnreadAnnouncement = meDetailed.HasUnreadAnnouncement,
				UnreadAnnouncements = meDetailed.UnreadAnnouncements,
				HasUnreadAntenna = meDetailed.HasUnreadAntenna,
				HasUnreadChannel = meDetailed.HasUnreadChannel,
				HasUnreadNotification = meDetailed.HasUnreadNotification,
				HasPendingReceivedFollowRequest = meDetailed.HasPendingReceivedFollowRequest,
				UnreadNotificationsCount = meDetailed.UnreadNotificationsCount,
				MutedWords = meDetailed.MutedWords,
				HardMutedWords = meDetailed.HardMutedWords,
				MutedInstances = meDetailed.MutedInstances,
				NotificationRecieveConfig = meDetailed.NotificationRecieveConfig,
				EmailNotificationTypes = meDetailed.EmailNotificationTypes,
				Achievements = meDetailed.Achievements,
				LoggedInDays = meDetailed.LoggedInDays,
				Policies = meDetailed.Policies,
				TwoFactorEnabled = meDetailed.TwoFactorEnabled,
				UsePasswordLessLogin = meDetailed.UsePasswordLessLogin,
				SecurityKeys = meDetailed.SecurityKeys,
				Email = meDetailed.Email,
				EmailVerified = meDetailed.EmailVerified,
				SecurityKeysList = meDetailed.SecurityKeysList,
			};
		}
	}
}
