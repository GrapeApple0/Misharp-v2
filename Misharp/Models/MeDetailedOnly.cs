using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IMeDetailedOnlyModel
	{
		public string? AvatarId { get; set; }
		public string? BannerId { get; set; }
		public string? FollowedMessage { get; set; }
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
		public bool TwoFactorEnabled { get; set; }
		public bool UsePasswordLessLogin { get; set; }
		public bool SecurityKeys { get; set; }
		public string? Email { get; set; }
		public bool? EmailVerified { get; set; }
		public List<MeDetailedOnlySecurityKeysListItemsModel> SecurityKeysList { get; set; }
	}

	public enum MeDetailedOnlyTwoFactorBackupCodesStockEnum {
		[EnumMember(Value = "full")]
		Full,
		[EnumMember(Value = "partial")]
		Partial,
		[EnumMember(Value = "none")]
		None,
	}
	public interface IMeDetailedOnlyNotificationRecieveConfigModel
	{
		public object Note { get; set; }
		public object Follow { get; set; }
		public object Mention { get; set; }
		public object Reply { get; set; }
		public object Renote { get; set; }
		public object Quote { get; set; }
		public object Reaction { get; set; }
		public object PollEnded { get; set; }
		public object ReceiveFollowRequest { get; set; }
		public object FollowRequestAccepted { get; set; }
		public object RoleAssigned { get; set; }
		public object AchievementEarned { get; set; }
		public object App { get; set; }
		public object Test { get; set; }
	}
	public class MeDetailedOnlyNotificationRecieveConfigModel: IMeDetailedOnlyNotificationRecieveConfigModel
	{
		public object Note { get; set; }
		public object Follow { get; set; }
		public object Mention { get; set; }
		public object Reply { get; set; }
		public object Renote { get; set; }
		public object Quote { get; set; }
		public object Reaction { get; set; }
		public object PollEnded { get; set; }
		public object ReceiveFollowRequest { get; set; }
		public object FollowRequestAccepted { get; set; }
		public object RoleAssigned { get; set; }
		public object AchievementEarned { get; set; }
		public object App { get; set; }
		public object Test { get; set; }
	}
	public interface IMeDetailedOnlyAchievementsItemsModel
	{
		public string Name { get; set; }
		public decimal UnlockedAt { get; set; }
	}
	public class MeDetailedOnlyAchievementsItemsModel: IMeDetailedOnlyAchievementsItemsModel
	{
		public string Name { get; set; }
		public decimal UnlockedAt { get; set; }
	}
	public interface IMeDetailedOnlySecurityKeysListItemsModel
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public DateTime? LastUsed { get; set; }
	}
	public class MeDetailedOnlySecurityKeysListItemsModel: IMeDetailedOnlySecurityKeysListItemsModel
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public DateTime? LastUsed { get; set; }
	}

	public class MeDetailedOnlyModel: IMeDetailedOnlyModel
	{
		public string? AvatarId { get; set; }
		public string? BannerId { get; set; }
		public string? FollowedMessage { get; set; }
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
		public bool TwoFactorEnabled { get; set; }
		public bool UsePasswordLessLogin { get; set; }
		public bool SecurityKeys { get; set; }
		public string? Email { get; set; }
		public bool? EmailVerified { get; set; }
		public List<MeDetailedOnlySecurityKeysListItemsModel> SecurityKeysList { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
