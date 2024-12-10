using System.Runtime.Serialization;

namespace Misharp.Streaming.Enums;

public enum BodyType
{
    [EnumMember(Value = "notification")] Notification,
    [EnumMember(Value = "mention")] Mention,
    [EnumMember(Value = "reply")] Reply,
    [EnumMember(Value = "renote")] Renote,
    [EnumMember(Value = "follow")] Follow,
    [EnumMember(Value = "followed")] Followed,
    [EnumMember(Value = "unfollow")] Unfollow,
    [EnumMember(Value = "meUpdated")] MeUpdated,

    [EnumMember(Value = "urlUploadFinished")]
    UrlUploadFinished,

    [EnumMember(Value = "readAllNotifications")]
    ReadAllNotifications,

    [EnumMember(Value = "unreadNotification")]
    UnreadNotification,
    [EnumMember(Value = "unreadMention")] UnreadMention,

    [EnumMember(Value = "readAllUnreadMentions")]
    ReadAllUnreadMentions,

    [EnumMember(Value = "notificationFlushed")]
    NotificationFlushed,

    [EnumMember(Value = "unreadSpecifiedNote")]
    UnreadSpecifiedNote,

    [EnumMember(Value = "readAllUnreadSpecifiedNotes")]
    ReadAllUnreadSpecifiedNotes,

    [EnumMember(Value = "readAllAntennas")]
    ReadAllAntennas,
    [EnumMember(Value = "unreadAntenna")] UnreadAntenna,

    [EnumMember(Value = "readAllAnnouncements")]
    ReadAllAnnouncements,

    [EnumMember(Value = "myTokenRegenerated")]
    MyTokenRegenerated,

    [EnumMember(Value = "readAllChannels")]
    ReadAllChannels,
    [EnumMember(Value = "unreadChannel")] UnreadChannel,
    [EnumMember(Value = "signin")] Signin,

    [EnumMember(Value = "registryUpdated")]
    RegistryUpdated,

    [EnumMember(Value = "driveFileCreated")]
    DriveFileCreated,
    [EnumMember(Value = "readAntenna")] ReadAntenna,

    [EnumMember(Value = "receiveFollowRequest")]
    ReceiveFollowRequest,

    [EnumMember(Value = "announcementCreated")]
    AnnouncementCreated,

    // timeline
    [EnumMember(Value = "note")] Note,

    // serverStats
    [EnumMember(Value = "stats")] Stats,
    [EnumMember(Value = "statsLog")] StatsLog,

    // queueStats
    [EnumMember(Value = "stats")] QueueStats,

    // admin
    [EnumMember(Value = "newAbuseUserReport")]
    NewAbuseUserReport,

    // NoteUpdatedEvent
    [EnumMember(Value = "reacted")] Reacted,
    [EnumMember(Value = "unreacted")] Unreacted,
    [EnumMember(Value = "deleted")] Deleted,
    [EnumMember(Value = "pollVoted")] PollVoted
}