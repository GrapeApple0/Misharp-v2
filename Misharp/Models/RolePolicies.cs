using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IRolePoliciesModel
	{
		public bool gtlAvailable { get; set; }
		public bool ltlAvailable { get; set; }
		public bool canPublicNote { get; set; }
		public int mentionLimit { get; set; }
		public bool canInvite { get; set; }
		public int inviteLimit { get; set; }
		public int inviteLimitCycle { get; set; }
		public int inviteExpirationTime { get; set; }
		public bool canManageCustomEmojis { get; set; }
		public bool canManageAvatarDecorations { get; set; }
		public bool canSearchNotes { get; set; }
		public bool canUseTranslator { get; set; }
		public bool canHideAds { get; set; }
		public int driveCapacityMb { get; set; }
		public bool alwaysMarkNsfw { get; set; }
		public bool canUpdateBioMedia { get; set; }
		public int pinLimit { get; set; }
		public int antennaLimit { get; set; }
		public int wordMuteLimit { get; set; }
		public int webhookLimit { get; set; }
		public int clipLimit { get; set; }
		public int noteEachClipsLimit { get; set; }
		public int userListLimit { get; set; }
		public int userEachUserListsLimit { get; set; }
		public int rateLimitFactor { get; set; }
		public int avatarDecorationLimit { get; set; }
		public bool canImportAntennas { get; set; }
		public bool canImportBlocking { get; set; }
		public bool canImportFollowing { get; set; }
		public bool canImportMuting { get; set; }
		public bool canImportUserLists { get; set; }
	}
}
