using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface INotificationModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public NotificationTypeEnum Type { get; set; }
		public UserLiteModel User { get; set; }
		public string UserId { get; set; }
		public NoteModel Note { get; set; }
		public string Reaction { get; set; }
		public string? Message { get; set; }
		public RoleModel Role { get; set; }
		public NotificationAchievementEnum Achievement { get; set; }
		public NotificationExportedEntityEnum ExportedEntity { get; set; }
		public string FileId { get; set; }
		public string Body { get; set; }
		public string? Header { get; set; }
		public string? Icon { get; set; }
		public List<NotificationReactionsItemsModel> Reactions { get; set; }
		public List<UserLiteModel> Users { get; set; }
	}


	public class NotificationModel: INotificationModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public NotificationTypeEnum Type { get; set; }
		public UserLiteModel User { get; set; }
		public string UserId { get; set; }
		public NoteModel Note { get; set; }
		public string Reaction { get; set; }
		public string? Message { get; set; }
		public RoleModel Role { get; set; }
		public NotificationAchievementEnum Achievement { get; set; }
		public NotificationExportedEntityEnum ExportedEntity { get; set; }
		public string FileId { get; set; }
		public string Body { get; set; }
		public string? Header { get; set; }
		public string? Icon { get; set; }
		public List<NotificationReactionsItemsModel> Reactions { get; set; }
		public List<UserLiteModel> Users { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
	public enum NotificationTypeEnum {
		[EnumMember(Value = "note")]
		Note,
		[EnumMember(Value = "mention")]
		Mention,
		[EnumMember(Value = "reply")]
		Reply,
		[EnumMember(Value = "renote")]
		Renote,
		[EnumMember(Value = "quote")]
		Quote,
		[EnumMember(Value = "reaction")]
		Reaction,
		[EnumMember(Value = "pollEnded")]
		PollEnded,
		[EnumMember(Value = "follow")]
		Follow,
		[EnumMember(Value = "receiveFollowRequest")]
		ReceiveFollowRequest,
		[EnumMember(Value = "followRequestAccepted")]
		FollowRequestAccepted,
		[EnumMember(Value = "roleAssigned")]
		RoleAssigned,
		[EnumMember(Value = "achievementEarned")]
		AchievementEarned,
		[EnumMember(Value = "exportCompleted")]
		ExportCompleted,
		[EnumMember(Value = "login")]
		Login,
		[EnumMember(Value = "app")]
		App,
		[EnumMember(Value = "reaction:grouped")]
		ReactionGrouped,
		[EnumMember(Value = "renote:grouped")]
		RenoteGrouped,
		[EnumMember(Value = "test")]
		Test,
	}
	public enum NotificationAchievementEnum {
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
	public enum NotificationExportedEntityEnum {
		[EnumMember(Value = "antenna")]
		Antenna,
		[EnumMember(Value = "blocking")]
		Blocking,
		[EnumMember(Value = "clip")]
		Clip,
		[EnumMember(Value = "customEmoji")]
		CustomEmoji,
		[EnumMember(Value = "favorite")]
		Favorite,
		[EnumMember(Value = "following")]
		Following,
		[EnumMember(Value = "muting")]
		Muting,
		[EnumMember(Value = "note")]
		Note,
		[EnumMember(Value = "userList")]
		UserList,
	}
	public interface INotificationReactionsItemsModel
	{
		public UserLiteModel User { get; set; }
		public string Reaction { get; set; }
	}
	public class NotificationReactionsItemsModel: INotificationReactionsItemsModel
	{
		public UserLiteModel User { get; set; }
		public string Reaction { get; set; }
	}
}
