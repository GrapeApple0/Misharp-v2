using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class IApi
	{
		private readonly App _app;
		public async Task<Response<MeDetailedModel>> I()
		{
			var result = await _app.Request<MeDetailedModel>(
				"i", 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<IAppsItemsModel>>> Apps(IAppsPropertiesSortEnum sort)
		{
			var param = new Dictionary<string, object?>
			{
				{ "sort", sort },
			};
			var result = await _app.Request<List<IAppsItemsModel>>(
				"i/apps", 
				param, 
				needToken: true
			);
			return result;
		}

		public enum IAppsPropertiesSortEnum {
			[EnumMember(Value = "+createdAt")]
			PluscreatedAt,
			[EnumMember(Value = "-createdAt")]
			MinuscreatedAt,
			[EnumMember(Value = "+lastUsedAt")]
			PluslastUsedAt,
			[EnumMember(Value = "-lastUsedAt")]
			MinuslastUsedAt,
		}
		public interface IIAppsItemsModel
		{
			public string Id { get; set; }
			public string Name { get; set; }
			public DateTime? CreatedAt { get; set; }
			public DateTime? LastUsedAt { get; set; }
			public List<string> Permission { get; set; }
		}
		public class IAppsItemsModel: IIAppsItemsModel
		{
			public string Id { get; set; }
			public string Name { get; set; }
			public DateTime? CreatedAt { get; set; }
			public DateTime? LastUsedAt { get; set; }
			public List<string> Permission { get; set; }
		}
		public async Task<Response<List<IAuthorizedAppsItemsModel>>> AuthorizedApps(int limit = 10,int offset = 0,IAuthorizedAppsPropertiesSortEnum sort = IAuthorizedAppsPropertiesSortEnum.Desc)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "offset", offset },
				{ "sort", sort },
			};
			var result = await _app.Request<List<IAuthorizedAppsItemsModel>>(
				"i/authorized-apps", 
				param, 
				needToken: true
			);
			return result;
		}

		public enum IAuthorizedAppsPropertiesSortEnum {
			[EnumMember(Value = "desc")]
			Desc,
			[EnumMember(Value = "asc")]
			Asc,
		}
		public interface IIAuthorizedAppsItemsModel
		{
			public string Id { get; set; }
			public string Name { get; set; }
			public string? CallbackUrl { get; set; }
			public List<string> Permission { get; set; }
			public bool IsAuthorized { get; set; }
		}
		public class IAuthorizedAppsItemsModel: IIAuthorizedAppsItemsModel
		{
			public string Id { get; set; }
			public string Name { get; set; }
			public string? CallbackUrl { get; set; }
			public List<string> Permission { get; set; }
			public bool IsAuthorized { get; set; }
		}
		public async Task<Response<EmptyResponse>> ClaimAchievement(IClaimAchievementPropertiesNameEnum name)
		{
			var param = new Dictionary<string, object?>
			{
				{ "name", name },
			};
			var result = await _app.Request<EmptyResponse>(
				"i/claim-achievement", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public enum IClaimAchievementPropertiesNameEnum {
			[EnumMember(Value = "notes1")]
			Notes1,
			[EnumMember(Value = "notes10")]
			Notes10,
			[EnumMember(Value = "notes100")]
			Notes100,
			[EnumMember(Value = "notes500")]
			Notes500,
			[EnumMember(Value = "notes1000")]
			Notes1000,
			[EnumMember(Value = "notes5000")]
			Notes5000,
			[EnumMember(Value = "notes10000")]
			Notes10000,
			[EnumMember(Value = "notes20000")]
			Notes20000,
			[EnumMember(Value = "notes30000")]
			Notes30000,
			[EnumMember(Value = "notes40000")]
			Notes40000,
			[EnumMember(Value = "notes50000")]
			Notes50000,
			[EnumMember(Value = "notes60000")]
			Notes60000,
			[EnumMember(Value = "notes70000")]
			Notes70000,
			[EnumMember(Value = "notes80000")]
			Notes80000,
			[EnumMember(Value = "notes90000")]
			Notes90000,
			[EnumMember(Value = "notes100000")]
			Notes100000,
			[EnumMember(Value = "login3")]
			Login3,
			[EnumMember(Value = "login7")]
			Login7,
			[EnumMember(Value = "login15")]
			Login15,
			[EnumMember(Value = "login30")]
			Login30,
			[EnumMember(Value = "login60")]
			Login60,
			[EnumMember(Value = "login100")]
			Login100,
			[EnumMember(Value = "login200")]
			Login200,
			[EnumMember(Value = "login300")]
			Login300,
			[EnumMember(Value = "login400")]
			Login400,
			[EnumMember(Value = "login500")]
			Login500,
			[EnumMember(Value = "login600")]
			Login600,
			[EnumMember(Value = "login700")]
			Login700,
			[EnumMember(Value = "login800")]
			Login800,
			[EnumMember(Value = "login900")]
			Login900,
			[EnumMember(Value = "login1000")]
			Login1000,
			[EnumMember(Value = "passedSinceAccountCreated1")]
			PassedSinceAccountCreated1,
			[EnumMember(Value = "passedSinceAccountCreated2")]
			PassedSinceAccountCreated2,
			[EnumMember(Value = "passedSinceAccountCreated3")]
			PassedSinceAccountCreated3,
			[EnumMember(Value = "loggedInOnBirthday")]
			LoggedInOnBirthday,
			[EnumMember(Value = "loggedInOnNewYearsDay")]
			LoggedInOnNewYearsDay,
			[EnumMember(Value = "noteClipped1")]
			NoteClipped1,
			[EnumMember(Value = "noteFavorited1")]
			NoteFavorited1,
			[EnumMember(Value = "myNoteFavorited1")]
			MyNoteFavorited1,
			[EnumMember(Value = "profileFilled")]
			ProfileFilled,
			[EnumMember(Value = "markedAsCat")]
			MarkedAsCat,
			[EnumMember(Value = "following1")]
			Following1,
			[EnumMember(Value = "following10")]
			Following10,
			[EnumMember(Value = "following50")]
			Following50,
			[EnumMember(Value = "following100")]
			Following100,
			[EnumMember(Value = "following300")]
			Following300,
			[EnumMember(Value = "followers1")]
			Followers1,
			[EnumMember(Value = "followers10")]
			Followers10,
			[EnumMember(Value = "followers50")]
			Followers50,
			[EnumMember(Value = "followers100")]
			Followers100,
			[EnumMember(Value = "followers300")]
			Followers300,
			[EnumMember(Value = "followers500")]
			Followers500,
			[EnumMember(Value = "followers1000")]
			Followers1000,
			[EnumMember(Value = "collectAchievements30")]
			CollectAchievements30,
			[EnumMember(Value = "viewAchievements3min")]
			ViewAchievements3min,
			[EnumMember(Value = "iLoveMisskey")]
			ILoveMisskey,
			[EnumMember(Value = "foundTreasure")]
			FoundTreasure,
			[EnumMember(Value = "client30min")]
			Client30min,
			[EnumMember(Value = "client60min")]
			Client60min,
			[EnumMember(Value = "noteDeletedWithin1min")]
			NoteDeletedWithin1min,
			[EnumMember(Value = "postedAtLateNight")]
			PostedAtLateNight,
			[EnumMember(Value = "postedAt0min0sec")]
			PostedAt0min0sec,
			[EnumMember(Value = "selfQuote")]
			SelfQuote,
			[EnumMember(Value = "htl20npm")]
			Htl20npm,
			[EnumMember(Value = "viewInstanceChart")]
			ViewInstanceChart,
			[EnumMember(Value = "outputHelloWorldOnScratchpad")]
			OutputHelloWorldOnScratchpad,
			[EnumMember(Value = "open3windows")]
			Open3windows,
			[EnumMember(Value = "driveFolderCircularReference")]
			DriveFolderCircularReference,
			[EnumMember(Value = "reactWithoutRead")]
			ReactWithoutRead,
			[EnumMember(Value = "clickedClickHere")]
			ClickedClickHere,
			[EnumMember(Value = "justPlainLucky")]
			JustPlainLucky,
			[EnumMember(Value = "setNameToSyuilo")]
			SetNameToSyuilo,
			[EnumMember(Value = "cookieClicked")]
			CookieClicked,
			[EnumMember(Value = "brainDiver")]
			BrainDiver,
			[EnumMember(Value = "smashTestNotificationButton")]
			SmashTestNotificationButton,
			[EnumMember(Value = "tutorialCompleted")]
			TutorialCompleted,
			[EnumMember(Value = "bubbleGameExplodingHead")]
			BubbleGameExplodingHead,
			[EnumMember(Value = "bubbleGameDoubleExplodingHead")]
			BubbleGameDoubleExplodingHead,
		}
		public async Task<Response<EmptyResponse>> ChangePassword(string currentPassword,string newPassword,string? token = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "currentPassword", currentPassword },
				{ "newPassword", newPassword },
				{ "token", token },
			};
			var result = await _app.Request<EmptyResponse>(
				"i/change-password", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> DeleteAccount(string password,string? token = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "password", password },
				{ "token", token },
			};
			var result = await _app.Request<EmptyResponse>(
				"i/delete-account", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> ExportBlocking()
		{
			var result = await _app.Request<EmptyResponse>(
				"i/export-blocking", 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> ExportFollowing(bool excludeMuting = false,bool excludeInactive = false)
		{
			var param = new Dictionary<string, object?>
			{
				{ "excludeMuting", excludeMuting },
				{ "excludeInactive", excludeInactive },
			};
			var result = await _app.Request<EmptyResponse>(
				"i/export-following", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> ExportMute()
		{
			var result = await _app.Request<EmptyResponse>(
				"i/export-mute", 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> ExportNotes()
		{
			var result = await _app.Request<EmptyResponse>(
				"i/export-notes", 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> ExportClips()
		{
			var result = await _app.Request<EmptyResponse>(
				"i/export-clips", 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> ExportFavorites()
		{
			var result = await _app.Request<EmptyResponse>(
				"i/export-favorites", 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> ExportUserLists()
		{
			var result = await _app.Request<EmptyResponse>(
				"i/export-user-lists", 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> ExportAntennas()
		{
			var result = await _app.Request<EmptyResponse>(
				"i/export-antennas", 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<NoteFavoriteModel>>> Favorites(int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<NoteFavoriteModel>>(
				"i/favorites", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> ImportBlocking(string fileId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "fileId", fileId },
			};
			var result = await _app.Request<EmptyResponse>(
				"i/import-blocking", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> ImportFollowing(string fileId,bool withReplies)
		{
			var param = new Dictionary<string, object?>
			{
				{ "fileId", fileId },
				{ "withReplies", withReplies },
			};
			var result = await _app.Request<EmptyResponse>(
				"i/import-following", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> ImportMuting(string fileId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "fileId", fileId },
			};
			var result = await _app.Request<EmptyResponse>(
				"i/import-muting", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> ImportUserLists(string fileId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "fileId", fileId },
			};
			var result = await _app.Request<EmptyResponse>(
				"i/import-user-lists", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> ImportAntennas(string fileId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "fileId", fileId },
			};
			var result = await _app.Request<EmptyResponse>(
				"i/import-antennas", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<NotificationModel>>> Notifications(int limit = 10,string? sinceId = null,string? untilId = null,bool markAsRead = true,List<string>? includeTypes = null,List<string>? excludeTypes = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "markAsRead", markAsRead },
				{ "includeTypes", includeTypes },
				{ "excludeTypes", excludeTypes },
			};
			var result = await _app.Request<List<NotificationModel>>(
				"i/notifications", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<NotificationModel>>> NotificationsGrouped(int limit = 10,string? sinceId = null,string? untilId = null,bool markAsRead = true,List<string>? includeTypes = null,List<string>? excludeTypes = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "markAsRead", markAsRead },
				{ "includeTypes", includeTypes },
				{ "excludeTypes", excludeTypes },
			};
			var result = await _app.Request<List<NotificationModel>>(
				"i/notifications-grouped", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<IPageLikesItemsModel>>> PageLikes(int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<IPageLikesItemsModel>>(
				"i/page-likes", 
				param, 
				needToken: true
			);
			return result;
		}

		public interface IIPageLikesItemsModel
		{
			public string Id { get; set; }
			public PageModel Page { get; set; }
		}
		public class IPageLikesItemsModel: IIPageLikesItemsModel
		{
			public string Id { get; set; }
			public PageModel Page { get; set; }
		}
		public async Task<Response<List<PageModel>>> Pages(int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<PageModel>>(
				"i/pages", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<MeDetailedModel>> Pin(string noteId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<MeDetailedModel>(
				"i/pin", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> ReadAllUnreadNotes()
		{
			var result = await _app.Request<EmptyResponse>(
				"i/read-all-unread-notes", 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> ReadAnnouncement(string announcementId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "announcementId", announcementId },
			};
			var result = await _app.Request<EmptyResponse>(
				"i/read-announcement", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> RegenerateToken(string password)
		{
			var param = new Dictionary<string, object?>
			{
				{ "password", password },
			};
			var result = await _app.Request<EmptyResponse>(
				"i/regenerate-token", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> RevokeToken(string tokenId,string? token = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "tokenId", tokenId },
				{ "token", token },
			};
			var result = await _app.Request<EmptyResponse>(
				"i/revoke-token", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<SigninModel>>> SigninHistory(int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<SigninModel>>(
				"i/signin-history", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<MeDetailedModel>> Unpin(string noteId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<MeDetailedModel>(
				"i/unpin", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<MeDetailedModel>> UpdateEmail(string password,string? email = null,string? token = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "password", password },
				{ "email", email },
				{ "token", token },
			};
			var result = await _app.Request<MeDetailedModel>(
				"i/update-email", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<MeDetailedModel>> Update(bool isLocked,bool isExplorable,bool hideOnlineStatus,bool publicReactions,bool carefulBot,bool autoAcceptFollowed,bool noCrawle,bool preventAiLearning,bool requireSigninToViewContents,bool isBot,bool isCat,bool injectFeaturedNote,bool receiveAnnouncementEmail,bool alwaysMarkNsfw,bool autoSensitive,IUpdatePropertiesFollowingVisibilityEnum followingVisibility,IUpdatePropertiesFollowersVisibilityEnum followersVisibility,IUpdatePropertiesNotificationRecieveConfigModel notificationRecieveConfig,string? name = null,string? description = null,string? followedMessage = null,string? location = null,string? birthday = null,IUpdatePropertiesLangEnum? lang = null,string? avatarId = null,List<IUpdatePropertiesAvatarDecorationsItemsModel>? avatarDecorations = null,string? bannerId = null,List<IUpdatePropertiesFieldsItemsModel>? fields = null,int? makeNotesFollowersOnlyBefore = null,int? makeNotesHiddenBefore = null,string? pinnedPageId = null,List<List<string>>? mutedWords = null, List<List<string>>? hardMutedWords = null,List<string>? mutedInstances = null,List<string>? emailNotificationTypes = null,List<string>? alsoKnownAs = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "name", name },
				{ "description", description },
				{ "followedMessage", followedMessage },
				{ "location", location },
				{ "birthday", birthday },
				{ "lang", lang },
				{ "avatarId", avatarId },
				{ "avatarDecorations", avatarDecorations },
				{ "bannerId", bannerId },
				{ "fields", fields },
				{ "isLocked", isLocked },
				{ "isExplorable", isExplorable },
				{ "hideOnlineStatus", hideOnlineStatus },
				{ "publicReactions", publicReactions },
				{ "carefulBot", carefulBot },
				{ "autoAcceptFollowed", autoAcceptFollowed },
				{ "noCrawle", noCrawle },
				{ "preventAiLearning", preventAiLearning },
				{ "requireSigninToViewContents", requireSigninToViewContents },
				{ "makeNotesFollowersOnlyBefore", makeNotesFollowersOnlyBefore },
				{ "makeNotesHiddenBefore", makeNotesHiddenBefore },
				{ "isBot", isBot },
				{ "isCat", isCat },
				{ "injectFeaturedNote", injectFeaturedNote },
				{ "receiveAnnouncementEmail", receiveAnnouncementEmail },
				{ "alwaysMarkNsfw", alwaysMarkNsfw },
				{ "autoSensitive", autoSensitive },
				{ "followingVisibility", followingVisibility },
				{ "followersVisibility", followersVisibility },
				{ "pinnedPageId", pinnedPageId },
				{ "mutedWords", mutedWords },
				{ "hardMutedWords", hardMutedWords },
				{ "mutedInstances", mutedInstances },
				{ "notificationRecieveConfig", notificationRecieveConfig },
				{ "emailNotificationTypes", emailNotificationTypes },
				{ "alsoKnownAs", alsoKnownAs },
			};
			var result = await _app.Request<MeDetailedModel>(
				"i/update", 
				param, 
				needToken: true
			);
			return result;
		}

		public enum IUpdatePropertiesLangEnum {
			[EnumMember(Value = "ach")]
			Ach,
			[EnumMember(Value = "ady")]
			Ady,
			[EnumMember(Value = "af")]
			Af,
			[EnumMember(Value = "af-NA")]
			AfNA,
			[EnumMember(Value = "af-ZA")]
			AfZA,
			[EnumMember(Value = "ak")]
			Ak,
			[EnumMember(Value = "ar")]
			Ar,
			[EnumMember(Value = "ar-AR")]
			ArAR,
			[EnumMember(Value = "ar-MA")]
			ArMA,
			[EnumMember(Value = "ar-SA")]
			ArSA,
			[EnumMember(Value = "ay-BO")]
			AyBO,
			[EnumMember(Value = "az")]
			Az,
			[EnumMember(Value = "az-AZ")]
			AzAZ,
			[EnumMember(Value = "be-BY")]
			BeBY,
			[EnumMember(Value = "bg")]
			Bg,
			[EnumMember(Value = "bg-BG")]
			BgBG,
			[EnumMember(Value = "bn")]
			Bn,
			[EnumMember(Value = "bn-IN")]
			BnIN,
			[EnumMember(Value = "bn-BD")]
			BnBD,
			[EnumMember(Value = "br")]
			Br,
			[EnumMember(Value = "bs-BA")]
			BsBA,
			[EnumMember(Value = "ca")]
			Ca,
			[EnumMember(Value = "ca-ES")]
			CaES,
			[EnumMember(Value = "cak")]
			Cak,
			[EnumMember(Value = "ck-US")]
			CkUS,
			[EnumMember(Value = "cs")]
			Cs,
			[EnumMember(Value = "cs-CZ")]
			CsCZ,
			[EnumMember(Value = "cy")]
			Cy,
			[EnumMember(Value = "cy-GB")]
			CyGB,
			[EnumMember(Value = "da")]
			Da,
			[EnumMember(Value = "da-DK")]
			DaDK,
			[EnumMember(Value = "de")]
			De,
			[EnumMember(Value = "de-AT")]
			DeAT,
			[EnumMember(Value = "de-DE")]
			DeDE,
			[EnumMember(Value = "de-CH")]
			DeCH,
			[EnumMember(Value = "dsb")]
			Dsb,
			[EnumMember(Value = "el")]
			El,
			[EnumMember(Value = "el-GR")]
			ElGR,
			[EnumMember(Value = "en")]
			En,
			[EnumMember(Value = "en-GB")]
			EnGB,
			[EnumMember(Value = "en-AU")]
			EnAU,
			[EnumMember(Value = "en-CA")]
			EnCA,
			[EnumMember(Value = "en-IE")]
			EnIE,
			[EnumMember(Value = "en-IN")]
			EnIN,
			[EnumMember(Value = "en-PI")]
			EnPI,
			[EnumMember(Value = "en-SG")]
			EnSG,
			[EnumMember(Value = "en-UD")]
			EnUD,
			[EnumMember(Value = "en-US")]
			EnUS,
			[EnumMember(Value = "en-ZA")]
			EnZA,
			[EnumMember(Value = "en@pirate")]
			EnAtpirate,
			[EnumMember(Value = "eo")]
			Eo,
			[EnumMember(Value = "eo-EO")]
			EoEO,
			[EnumMember(Value = "es")]
			Es,
			[EnumMember(Value = "es-AR")]
			EsAR,
			[EnumMember(Value = "es-419")]
			Es419,
			[EnumMember(Value = "es-CL")]
			EsCL,
			[EnumMember(Value = "es-CO")]
			EsCO,
			[EnumMember(Value = "es-EC")]
			EsEC,
			[EnumMember(Value = "es-ES")]
			EsES,
			[EnumMember(Value = "es-LA")]
			EsLA,
			[EnumMember(Value = "es-NI")]
			EsNI,
			[EnumMember(Value = "es-MX")]
			EsMX,
			[EnumMember(Value = "es-US")]
			EsUS,
			[EnumMember(Value = "es-VE")]
			EsVE,
			[EnumMember(Value = "et")]
			Et,
			[EnumMember(Value = "et-EE")]
			EtEE,
			[EnumMember(Value = "eu")]
			Eu,
			[EnumMember(Value = "eu-ES")]
			EuES,
			[EnumMember(Value = "fa")]
			Fa,
			[EnumMember(Value = "fa-IR")]
			FaIR,
			[EnumMember(Value = "fb-LT")]
			FbLT,
			[EnumMember(Value = "ff")]
			Ff,
			[EnumMember(Value = "fi")]
			Fi,
			[EnumMember(Value = "fi-FI")]
			FiFI,
			[EnumMember(Value = "fo")]
			Fo,
			[EnumMember(Value = "fo-FO")]
			FoFO,
			[EnumMember(Value = "fr")]
			Fr,
			[EnumMember(Value = "fr-CA")]
			FrCA,
			[EnumMember(Value = "fr-FR")]
			FrFR,
			[EnumMember(Value = "fr-BE")]
			FrBE,
			[EnumMember(Value = "fr-CH")]
			FrCH,
			[EnumMember(Value = "fy-NL")]
			FyNL,
			[EnumMember(Value = "ga")]
			Ga,
			[EnumMember(Value = "ga-IE")]
			GaIE,
			[EnumMember(Value = "gd")]
			Gd,
			[EnumMember(Value = "gl")]
			Gl,
			[EnumMember(Value = "gl-ES")]
			GlES,
			[EnumMember(Value = "gn-PY")]
			GnPY,
			[EnumMember(Value = "gu-IN")]
			GuIN,
			[EnumMember(Value = "gv")]
			Gv,
			[EnumMember(Value = "gx-GR")]
			GxGR,
			[EnumMember(Value = "he")]
			He,
			[EnumMember(Value = "he-IL")]
			HeIL,
			[EnumMember(Value = "hi")]
			Hi,
			[EnumMember(Value = "hi-IN")]
			HiIN,
			[EnumMember(Value = "hr")]
			Hr,
			[EnumMember(Value = "hr-HR")]
			HrHR,
			[EnumMember(Value = "hsb")]
			Hsb,
			[EnumMember(Value = "ht")]
			Ht,
			[EnumMember(Value = "hu")]
			Hu,
			[EnumMember(Value = "hu-HU")]
			HuHU,
			[EnumMember(Value = "hy")]
			Hy,
			[EnumMember(Value = "hy-AM")]
			HyAM,
			[EnumMember(Value = "id")]
			Id,
			[EnumMember(Value = "id-ID")]
			IdID,
			[EnumMember(Value = "is")]
			Is,
			[EnumMember(Value = "is-IS")]
			IsIS,
			[EnumMember(Value = "it")]
			It,
			[EnumMember(Value = "it-IT")]
			ItIT,
			[EnumMember(Value = "ja")]
			Ja,
			[EnumMember(Value = "ja-JP")]
			JaJP,
			[EnumMember(Value = "jv-ID")]
			JvID,
			[EnumMember(Value = "ka-GE")]
			KaGE,
			[EnumMember(Value = "kk-KZ")]
			KkKZ,
			[EnumMember(Value = "km")]
			Km,
			[EnumMember(Value = "kl")]
			Kl,
			[EnumMember(Value = "km-KH")]
			KmKH,
			[EnumMember(Value = "kab")]
			Kab,
			[EnumMember(Value = "kn")]
			Kn,
			[EnumMember(Value = "kn-IN")]
			KnIN,
			[EnumMember(Value = "ko")]
			Ko,
			[EnumMember(Value = "ko-KR")]
			KoKR,
			[EnumMember(Value = "ku-TR")]
			KuTR,
			[EnumMember(Value = "kw")]
			Kw,
			[EnumMember(Value = "la")]
			La,
			[EnumMember(Value = "la-VA")]
			LaVA,
			[EnumMember(Value = "lb")]
			Lb,
			[EnumMember(Value = "li-NL")]
			LiNL,
			[EnumMember(Value = "lt")]
			Lt,
			[EnumMember(Value = "lt-LT")]
			LtLT,
			[EnumMember(Value = "lv")]
			Lv,
			[EnumMember(Value = "lv-LV")]
			LvLV,
			[EnumMember(Value = "mai")]
			Mai,
			[EnumMember(Value = "mg-MG")]
			MgMG,
			[EnumMember(Value = "mk")]
			Mk,
			[EnumMember(Value = "mk-MK")]
			MkMK,
			[EnumMember(Value = "ml")]
			Ml,
			[EnumMember(Value = "ml-IN")]
			MlIN,
			[EnumMember(Value = "mn-MN")]
			MnMN,
			[EnumMember(Value = "mr")]
			Mr,
			[EnumMember(Value = "mr-IN")]
			MrIN,
			[EnumMember(Value = "ms")]
			Ms,
			[EnumMember(Value = "ms-MY")]
			MsMY,
			[EnumMember(Value = "mt")]
			Mt,
			[EnumMember(Value = "mt-MT")]
			MtMT,
			[EnumMember(Value = "my")]
			My,
			[EnumMember(Value = "no")]
			No,
			[EnumMember(Value = "nb")]
			Nb,
			[EnumMember(Value = "nb-NO")]
			NbNO,
			[EnumMember(Value = "ne")]
			Ne,
			[EnumMember(Value = "ne-NP")]
			NeNP,
			[EnumMember(Value = "nl")]
			Nl,
			[EnumMember(Value = "nl-BE")]
			NlBE,
			[EnumMember(Value = "nl-NL")]
			NlNL,
			[EnumMember(Value = "nn-NO")]
			NnNO,
			[EnumMember(Value = "oc")]
			Oc,
			[EnumMember(Value = "or-IN")]
			OrIN,
			[EnumMember(Value = "pa")]
			Pa,
			[EnumMember(Value = "pa-IN")]
			PaIN,
			[EnumMember(Value = "pl")]
			Pl,
			[EnumMember(Value = "pl-PL")]
			PlPL,
			[EnumMember(Value = "ps-AF")]
			PsAF,
			[EnumMember(Value = "pt")]
			Pt,
			[EnumMember(Value = "pt-BR")]
			PtBR,
			[EnumMember(Value = "pt-PT")]
			PtPT,
			[EnumMember(Value = "qu-PE")]
			QuPE,
			[EnumMember(Value = "rm-CH")]
			RmCH,
			[EnumMember(Value = "ro")]
			Ro,
			[EnumMember(Value = "ro-RO")]
			RoRO,
			[EnumMember(Value = "ru")]
			Ru,
			[EnumMember(Value = "ru-RU")]
			RuRU,
			[EnumMember(Value = "sa-IN")]
			SaIN,
			[EnumMember(Value = "se-NO")]
			SeNO,
			[EnumMember(Value = "sh")]
			Sh,
			[EnumMember(Value = "si-LK")]
			SiLK,
			[EnumMember(Value = "sk")]
			Sk,
			[EnumMember(Value = "sk-SK")]
			SkSK,
			[EnumMember(Value = "sl")]
			Sl,
			[EnumMember(Value = "sl-SI")]
			SlSI,
			[EnumMember(Value = "so-SO")]
			SoSO,
			[EnumMember(Value = "sq")]
			Sq,
			[EnumMember(Value = "sq-AL")]
			SqAL,
			[EnumMember(Value = "sr")]
			Sr,
			[EnumMember(Value = "sr-RS")]
			SrRS,
			[EnumMember(Value = "su")]
			Su,
			[EnumMember(Value = "sv")]
			Sv,
			[EnumMember(Value = "sv-SE")]
			SvSE,
			[EnumMember(Value = "sw")]
			Sw,
			[EnumMember(Value = "sw-KE")]
			SwKE,
			[EnumMember(Value = "ta")]
			Ta,
			[EnumMember(Value = "ta-IN")]
			TaIN,
			[EnumMember(Value = "te")]
			Te,
			[EnumMember(Value = "te-IN")]
			TeIN,
			[EnumMember(Value = "tg")]
			Tg,
			[EnumMember(Value = "tg-TJ")]
			TgTJ,
			[EnumMember(Value = "th")]
			Th,
			[EnumMember(Value = "th-TH")]
			ThTH,
			[EnumMember(Value = "fil")]
			Fil,
			[EnumMember(Value = "tlh")]
			Tlh,
			[EnumMember(Value = "tr")]
			Tr,
			[EnumMember(Value = "tr-TR")]
			TrTR,
			[EnumMember(Value = "tt-RU")]
			TtRU,
			[EnumMember(Value = "uk")]
			Uk,
			[EnumMember(Value = "uk-UA")]
			UkUA,
			[EnumMember(Value = "ur")]
			Ur,
			[EnumMember(Value = "ur-PK")]
			UrPK,
			[EnumMember(Value = "uz")]
			Uz,
			[EnumMember(Value = "uz-UZ")]
			UzUZ,
			[EnumMember(Value = "vi")]
			Vi,
			[EnumMember(Value = "vi-VN")]
			ViVN,
			[EnumMember(Value = "xh-ZA")]
			XhZA,
			[EnumMember(Value = "yi")]
			Yi,
			[EnumMember(Value = "yi-DE")]
			YiDE,
			[EnumMember(Value = "zh")]
			Zh,
			[EnumMember(Value = "zh-Hans")]
			ZhHans,
			[EnumMember(Value = "zh-Hant")]
			ZhHant,
			[EnumMember(Value = "zh-CN")]
			ZhCN,
			[EnumMember(Value = "zh-HK")]
			ZhHK,
			[EnumMember(Value = "zh-SG")]
			ZhSG,
			[EnumMember(Value = "zh-TW")]
			ZhTW,
			[EnumMember(Value = "zu-ZA")]
			ZuZA,
		}
		public interface IIUpdatePropertiesAvatarDecorationsItemsModel
		{
			public string Id { get; set; }
			public decimal? Angle { get; set; }
			public bool? FlipH { get; set; }
			public decimal? OffsetX { get; set; }
			public decimal? OffsetY { get; set; }
		}
		public class IUpdatePropertiesAvatarDecorationsItemsModel: IIUpdatePropertiesAvatarDecorationsItemsModel
		{
			public string Id { get; set; }
			public decimal? Angle { get; set; }
			public bool? FlipH { get; set; }
			public decimal? OffsetX { get; set; }
			public decimal? OffsetY { get; set; }
		}
		public interface IIUpdatePropertiesFieldsItemsModel
		{
			public string Name { get; set; }
			public string Value { get; set; }
		}
		public class IUpdatePropertiesFieldsItemsModel: IIUpdatePropertiesFieldsItemsModel
		{
			public string Name { get; set; }
			public string Value { get; set; }
		}
		public enum IUpdatePropertiesFollowingVisibilityEnum {
			[EnumMember(Value = "public")]
			Public,
			[EnumMember(Value = "followers")]
			Followers,
			[EnumMember(Value = "private")]
			Private,
		}
		public enum IUpdatePropertiesFollowersVisibilityEnum {
			[EnumMember(Value = "public")]
			Public,
			[EnumMember(Value = "followers")]
			Followers,
			[EnumMember(Value = "private")]
			Private,
		}
		public interface IIUpdatePropertiesNotificationRecieveConfigModel
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
		public class IUpdatePropertiesNotificationRecieveConfigModel: IIUpdatePropertiesNotificationRecieveConfigModel
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
		public async Task<Response<JsonNode>> Move(string moveToAccount)
		{
			var param = new Dictionary<string, object?>
			{
				{ "moveToAccount", moveToAccount },
			};
			var result = await _app.Request<JsonNode>(
				"i/move", 
				param, 
				needToken: true
			);
			return result;
		}

		public readonly I.GalleryApi GalleryApi;
		public readonly I.WebhooksApi WebhooksApi;
		public IApi(App app)
		{
			this._app = app;
			this.GalleryApi = new I.GalleryApi(this._app);
			this.WebhooksApi = new I.WebhooksApi(this._app);
		}
	}
}
namespace Misharp.Controls.I
{
	public class GalleryApi
	{
		private readonly App _app;
		public GalleryApi(App app)
		{
			this._app = app;
		}
		public async Task<Response<List<ILikesItemsModel>>> Likes(int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<ILikesItemsModel>>(
				"i/gallery/likes", 
				param, 
				needToken: true
			);
			return result;
		}

		public interface IILikesItemsModel
		{
			public string Id { get; set; }
			public GalleryPostModel Post { get; set; }
		}
		public class ILikesItemsModel: IILikesItemsModel
		{
			public string Id { get; set; }
			public GalleryPostModel Post { get; set; }
		}
		public async Task<Response<List<GalleryPostModel>>> Posts(int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<GalleryPostModel>>(
				"i/gallery/posts", 
				param, 
				needToken: true
			);
			return result;
		}

	}
}
namespace Misharp.Controls.I
{
	public class WebhooksApi
	{
		private readonly App _app;
		public WebhooksApi(App app)
		{
			this._app = app;
		}
		public async Task<Response<ICreateModel>> Create(string name,string url,string secret = "",List<string>? on = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "name", name },
				{ "url", url },
				{ "secret", secret },
				{ "on", on },
			};
			var result = await _app.Request<ICreateModel>(
				"i/webhooks/create", 
				param, 
				needToken: true
			);
			return result;
		}

		public interface IICreateModel
		{
			public string Id { get; set; }
			public string UserId { get; set; }
			public string Name { get; set; }
			public List<string> On { get; set; }
			public string Url { get; set; }
			public string Secret { get; set; }
			public bool Active { get; set; }
			public DateTime? LatestSentAt { get; set; }
			public int? LatestStatus { get; set; }
		}
		public class ICreateModel: IICreateModel
		{
			public string Id { get; set; }
			public string UserId { get; set; }
			public string Name { get; set; }
			public List<string> On { get; set; }
			public string Url { get; set; }
			public string Secret { get; set; }
			public bool Active { get; set; }
			public DateTime? LatestSentAt { get; set; }
			public int? LatestStatus { get; set; }
		}
		public async Task<Response<List<IListItemsModel>>> List()
		{
			var result = await _app.Request<List<IListItemsModel>>(
				"i/webhooks/list", 
				needToken: true
			);
			return result;
		}

		public interface IIListItemsModel
		{
			public string Id { get; set; }
			public string UserId { get; set; }
			public string Name { get; set; }
			public List<string> On { get; set; }
			public string Url { get; set; }
			public string Secret { get; set; }
			public bool Active { get; set; }
			public DateTime? LatestSentAt { get; set; }
			public int? LatestStatus { get; set; }
		}
		public class IListItemsModel: IIListItemsModel
		{
			public string Id { get; set; }
			public string UserId { get; set; }
			public string Name { get; set; }
			public List<string> On { get; set; }
			public string Url { get; set; }
			public string Secret { get; set; }
			public bool Active { get; set; }
			public DateTime? LatestSentAt { get; set; }
			public int? LatestStatus { get; set; }
		}
		public async Task<Response<IShowModel>> Show(string webhookId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "webhookId", webhookId },
			};
			var result = await _app.Request<IShowModel>(
				"i/webhooks/show", 
				param, 
				needToken: true
			);
			return result;
		}

		public interface IIShowModel
		{
			public string Id { get; set; }
			public string UserId { get; set; }
			public string Name { get; set; }
			public List<string> On { get; set; }
			public string Url { get; set; }
			public string Secret { get; set; }
			public bool Active { get; set; }
			public DateTime? LatestSentAt { get; set; }
			public int? LatestStatus { get; set; }
		}
		public class IShowModel: IIShowModel
		{
			public string Id { get; set; }
			public string UserId { get; set; }
			public string Name { get; set; }
			public List<string> On { get; set; }
			public string Url { get; set; }
			public string Secret { get; set; }
			public bool Active { get; set; }
			public DateTime? LatestSentAt { get; set; }
			public int? LatestStatus { get; set; }
		}
		public async Task<Response<EmptyResponse>> Update(string webhookId,string name,string url,bool active,string? secret = null,List<string>? on = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "webhookId", webhookId },
				{ "name", name },
				{ "url", url },
				{ "secret", secret },
				{ "on", on },
				{ "active", active },
			};
			var result = await _app.Request<EmptyResponse>(
				"i/webhooks/update", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Delete(string webhookId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "webhookId", webhookId },
			};
			var result = await _app.Request<EmptyResponse>(
				"i/webhooks/delete", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Test(string webhookId,IWebhooksTestPropertiesTypeEnum type,IWebhooksTestPropertiesOverrideModel @override)
		{
			var param = new Dictionary<string, object?>
			{
				{ "webhookId", webhookId },
				{ "type", type },
				{ "override", @override },
			};
			var result = await _app.Request<EmptyResponse>(
				"i/webhooks/test", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public enum IWebhooksTestPropertiesTypeEnum {
			[EnumMember(Value = "mention")]
			Mention,
			[EnumMember(Value = "unfollow")]
			Unfollow,
			[EnumMember(Value = "follow")]
			Follow,
			[EnumMember(Value = "followed")]
			Followed,
			[EnumMember(Value = "note")]
			Note,
			[EnumMember(Value = "reply")]
			Reply,
			[EnumMember(Value = "renote")]
			Renote,
			[EnumMember(Value = "reaction")]
			Reaction,
		}
		public interface IIWebhooksTestPropertiesOverrideModel
		{
			public string Url { get; set; }
			public string Secret { get; set; }
		}
		public class IWebhooksTestPropertiesOverrideModel: IIWebhooksTestPropertiesOverrideModel
		{
			public string Url { get; set; }
			public string Secret { get; set; }
		}
	}
}
