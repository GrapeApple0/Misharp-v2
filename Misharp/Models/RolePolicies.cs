using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IRolePoliciesModel
	{
		public bool GtlAvailable { get; set; }
		public bool LtlAvailable { get; set; }
		public bool CanPublicNote { get; set; }
		public int MentionLimit { get; set; }
		public bool CanInvite { get; set; }
		public int InviteLimit { get; set; }
		public int InviteLimitCycle { get; set; }
		public int InviteExpirationTime { get; set; }
		public bool CanManageCustomEmojis { get; set; }
		public bool CanManageAvatarDecorations { get; set; }
		public bool CanSearchNotes { get; set; }
		public bool CanUseTranslator { get; set; }
		public bool CanHideAds { get; set; }
		public int DriveCapacityMb { get; set; }
		public bool AlwaysMarkNsfw { get; set; }
		public bool CanUpdateBioMedia { get; set; }
		public int PinLimit { get; set; }
		public int AntennaLimit { get; set; }
		public int WordMuteLimit { get; set; }
		public int WebhookLimit { get; set; }
		public int ClipLimit { get; set; }
		public int NoteEachClipsLimit { get; set; }
		public int UserListLimit { get; set; }
		public int UserEachUserListsLimit { get; set; }
		public int RateLimitFactor { get; set; }
		public int AvatarDecorationLimit { get; set; }
		public bool CanImportAntennas { get; set; }
		public bool CanImportBlocking { get; set; }
		public bool CanImportFollowing { get; set; }
		public bool CanImportMuting { get; set; }
		public bool CanImportUserLists { get; set; }
	}


	public class RolePoliciesModel: IRolePoliciesModel
	{
		public bool GtlAvailable { get; set; }
		public bool LtlAvailable { get; set; }
		public bool CanPublicNote { get; set; }
		public int MentionLimit { get; set; }
		public bool CanInvite { get; set; }
		public int InviteLimit { get; set; }
		public int InviteLimitCycle { get; set; }
		public int InviteExpirationTime { get; set; }
		public bool CanManageCustomEmojis { get; set; }
		public bool CanManageAvatarDecorations { get; set; }
		public bool CanSearchNotes { get; set; }
		public bool CanUseTranslator { get; set; }
		public bool CanHideAds { get; set; }
		public int DriveCapacityMb { get; set; }
		public bool AlwaysMarkNsfw { get; set; }
		public bool CanUpdateBioMedia { get; set; }
		public int PinLimit { get; set; }
		public int AntennaLimit { get; set; }
		public int WordMuteLimit { get; set; }
		public int WebhookLimit { get; set; }
		public int ClipLimit { get; set; }
		public int NoteEachClipsLimit { get; set; }
		public int UserListLimit { get; set; }
		public int UserEachUserListsLimit { get; set; }
		public int RateLimitFactor { get; set; }
		public int AvatarDecorationLimit { get; set; }
		public bool CanImportAntennas { get; set; }
		public bool CanImportBlocking { get; set; }
		public bool CanImportFollowing { get; set; }
		public bool CanImportMuting { get; set; }
		public bool CanImportUserLists { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
