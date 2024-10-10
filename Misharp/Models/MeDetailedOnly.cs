using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IMeDetailedOnlyModel
	{
		public string? avatarId { get; set; }
		public string? bannerId { get; set; }
		public string? followedMessage { get; set; }
		public bool? isModerator { get; set; }
		public bool? isAdmin { get; set; }
		public bool injectFeaturedNote { get; set; }
		public bool receiveAnnouncementEmail { get; set; }
		public bool alwaysMarkNsfw { get; set; }
		public bool autoSensitive { get; set; }
		public bool carefulBot { get; set; }
		public bool autoAcceptFollowed { get; set; }
		public bool noCrawle { get; set; }
		public bool preventAiLearning { get; set; }
		public bool isExplorable { get; set; }
		public bool isDeleted { get; set; }
		public string twoFactorBackupCodesStock { get; set; }
		public bool hideOnlineStatus { get; set; }
		public bool hasUnreadSpecifiedNotes { get; set; }
		public bool hasUnreadMentions { get; set; }
		public bool hasUnreadAnnouncement { get; set; }
		public array unreadAnnouncements { get; set; }
		public bool hasUnreadAntenna { get; set; }
		public bool hasUnreadChannel { get; set; }
		public bool hasUnreadNotification { get; set; }
		public bool hasPendingReceivedFollowRequest { get; set; }
		public decimal unreadNotificationsCount { get; set; }
		public array mutedWords { get; set; }
		public array hardMutedWords { get; set; }
		public array? mutedInstances { get; set; }
		public object notificationRecieveConfig { get; set; }
		public array emailNotificationTypes { get; set; }
		public array achievements { get; set; }
		public decimal loggedInDays { get; set; }
		public object policies { get; set; }
		public string? email { get; set; }
		public bool? emailVerified { get; set; }
		public array securityKeysList { get; set; }
	}
}
