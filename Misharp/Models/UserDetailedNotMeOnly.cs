using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IUserDetailedNotMeOnlyModel
	{
		public Uri? url { get; set; }
		public string? uri { get; set; }
		public string? movedTo { get; set; }
		public array? alsoKnownAs { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime? updatedAt { get; set; }
		public DateTime? lastFetchedAt { get; set; }
		public Uri? bannerUrl { get; set; }
		public string? bannerBlurhash { get; set; }
		public bool isLocked { get; set; }
		public bool isSilenced { get; set; }
		public bool isSuspended { get; set; }
		public string? description { get; set; }
		public string? location { get; set; }
		public string? birthday { get; set; }
		public string? lang { get; set; }
		public array fields { get; set; }
		public array verifiedLinks { get; set; }
		public decimal followersCount { get; set; }
		public decimal followingCount { get; set; }
		public decimal notesCount { get; set; }
		public array pinnedNoteIds { get; set; }
		public array pinnedNotes { get; set; }
		public string? pinnedPageId { get; set; }
		public object? pinnedPage { get; set; }
		public bool publicReactions { get; set; }
		public string followingVisibility { get; set; }
		public string followersVisibility { get; set; }
		public bool twoFactorEnabled { get; set; }
		public bool usePasswordLessLogin { get; set; }
		public bool securityKeys { get; set; }
		public array roles { get; set; }
		public string? followedMessage { get; set; }
		public string? memo { get; set; }
		public string moderationNote { get; set; }
		public bool isFollowing { get; set; }
		public bool isFollowed { get; set; }
		public bool hasPendingFollowRequestFromYou { get; set; }
		public bool hasPendingFollowRequestToYou { get; set; }
		public bool isBlocking { get; set; }
		public bool isBlocked { get; set; }
		public bool isMuted { get; set; }
		public bool isRenoteMuted { get; set; }
		public string notify { get; set; }
		public bool withReplies { get; set; }
	}
}
