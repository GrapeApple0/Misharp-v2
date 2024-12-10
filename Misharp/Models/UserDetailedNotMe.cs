using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IUserDetailedNotMeModel: IUserLiteModel, IUserDetailedNotMeOnlyModel
	{
	}


	public class UserDetailedNotMeModel: IUserDetailedNotMeModel
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
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
		public static implicit operator UserLiteModel(UserDetailedNotMeModel userDetailedNotMe)
		{
			return new UserLiteModel()
			{
				Id = userDetailedNotMe.Id,
				Name = userDetailedNotMe.Name,
				Username = userDetailedNotMe.Username,
				Host = userDetailedNotMe.Host,
				AvatarUrl = userDetailedNotMe.AvatarUrl,
				AvatarBlurhash = userDetailedNotMe.AvatarBlurhash,
				AvatarDecorations = userDetailedNotMe.AvatarDecorations,
				IsBot = userDetailedNotMe.IsBot,
				IsCat = userDetailedNotMe.IsCat,
				RequireSigninToViewContents = userDetailedNotMe.RequireSigninToViewContents,
				MakeNotesFollowersOnlyBefore = userDetailedNotMe.MakeNotesFollowersOnlyBefore,
				MakeNotesHiddenBefore = userDetailedNotMe.MakeNotesHiddenBefore,
				Instance = userDetailedNotMe.Instance,
				Emojis = userDetailedNotMe.Emojis,
				OnlineStatus = userDetailedNotMe.OnlineStatus,
				BadgeRoles = userDetailedNotMe.BadgeRoles,
			};
		}
		public static implicit operator UserDetailedNotMeOnlyModel(UserDetailedNotMeModel userDetailedNotMe)
		{
			return new UserDetailedNotMeOnlyModel()
			{
				Url = userDetailedNotMe.Url,
				Uri = userDetailedNotMe.Uri,
				MovedTo = userDetailedNotMe.MovedTo,
				AlsoKnownAs = userDetailedNotMe.AlsoKnownAs,
				CreatedAt = userDetailedNotMe.CreatedAt,
				UpdatedAt = userDetailedNotMe.UpdatedAt,
				LastFetchedAt = userDetailedNotMe.LastFetchedAt,
				BannerUrl = userDetailedNotMe.BannerUrl,
				BannerBlurhash = userDetailedNotMe.BannerBlurhash,
				IsLocked = userDetailedNotMe.IsLocked,
				IsSilenced = userDetailedNotMe.IsSilenced,
				IsSuspended = userDetailedNotMe.IsSuspended,
				Description = userDetailedNotMe.Description,
				Location = userDetailedNotMe.Location,
				Birthday = userDetailedNotMe.Birthday,
				Lang = userDetailedNotMe.Lang,
				Fields = userDetailedNotMe.Fields,
				VerifiedLinks = userDetailedNotMe.VerifiedLinks,
				FollowersCount = userDetailedNotMe.FollowersCount,
				FollowingCount = userDetailedNotMe.FollowingCount,
				NotesCount = userDetailedNotMe.NotesCount,
				PinnedNoteIds = userDetailedNotMe.PinnedNoteIds,
				PinnedNotes = userDetailedNotMe.PinnedNotes,
				PinnedPageId = userDetailedNotMe.PinnedPageId,
				PinnedPage = userDetailedNotMe.PinnedPage,
				PublicReactions = userDetailedNotMe.PublicReactions,
				FollowingVisibility = userDetailedNotMe.FollowingVisibility,
				FollowersVisibility = userDetailedNotMe.FollowersVisibility,
				Roles = userDetailedNotMe.Roles,
				FollowedMessage = userDetailedNotMe.FollowedMessage,
				Memo = userDetailedNotMe.Memo,
				ModerationNote = userDetailedNotMe.ModerationNote,
				TwoFactorEnabled = userDetailedNotMe.TwoFactorEnabled,
				UsePasswordLessLogin = userDetailedNotMe.UsePasswordLessLogin,
				SecurityKeys = userDetailedNotMe.SecurityKeys,
				IsFollowing = userDetailedNotMe.IsFollowing,
				IsFollowed = userDetailedNotMe.IsFollowed,
				HasPendingFollowRequestFromYou = userDetailedNotMe.HasPendingFollowRequestFromYou,
				HasPendingFollowRequestToYou = userDetailedNotMe.HasPendingFollowRequestToYou,
				IsBlocking = userDetailedNotMe.IsBlocking,
				IsBlocked = userDetailedNotMe.IsBlocked,
				IsMuted = userDetailedNotMe.IsMuted,
				IsRenoteMuted = userDetailedNotMe.IsRenoteMuted,
				Notify = userDetailedNotMe.Notify,
				WithReplies = userDetailedNotMe.WithReplies,
			};
		}
	}
}
