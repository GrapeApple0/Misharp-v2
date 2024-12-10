using Misharp.Models;
using Misharp.Streaming.Enums;
using Misharp.Streaming.Models;

namespace Misharp.Streaming;

public abstract class EventArgs
{
    public class ReceivedEventArgs : EventArgs
    {
        public string Id { get; init; }
        public BodyType Type { get; init; }
        public BodyModel Body { get; init; }
    }

    public class NotificationEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.Notification;
        public new NotificationModel Body { get; init; }
    }

    public class MentionEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.Mention;
        public new NoteModel Body { get; init; }
    }

    public class ReplyEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.Reply;
        public new NoteModel Body { get; init; }
    }

    public class RenoteEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.Renote;
        public new NoteModel Body { get; init; }
    }

    public class FollowEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.Follow;
        public new UserLiteModel Body { get; init; }
    }

    public class FollowedEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.Followed;
        public new UserLiteModel Body { get; init; }
    }

    public class UnfollowEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.Unfollow;
        public new UserLiteModel Body { get; init; }
    }

    public class MeUpdatedEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.MeUpdated;
        public new MeDetailedModel Body { get; init; }
    }

    public class UrlUploadFinishedEventArgs : ReceivedEventArgs
    {
        public class UrlUploadFinishedEventModel
        {
            public string Marker { get; set; }
            public DriveFileModel File { get; set; }
        }

        public new BodyType Type { get; } = BodyType.UrlUploadFinished;
        public new UrlUploadFinishedEventModel Body { get; init; }
    }

    public class ReadAllNotificationsEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.ReadAllNotifications;
    }

    public class UnreadNotificationEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.UnreadNotification;
        public new NotificationModel Body { get; init; }
    }

    public class UnreadMentionEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.UnreadMention;
        public new string Body { get; init; }
    }

    public class ReadAllUnreadMentionsEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.ReadAllUnreadMentions;
    }

    public class NotificationFlushedEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.NotificationFlushed;
    }

    public class UnreadSpecifiedNoteEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.UnreadSpecifiedNote;
        public new string Body { get; init; }
    }

    public class ReadAllUnreadSpecifiedNotesEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.ReadAllUnreadSpecifiedNotes;
    }

    public class ReadAllAntennasEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.ReadAllAntennas;
    }

    public class UnreadAntennaEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.UnreadAntenna;
        public new AntennaModel Body { get; init; }
    }

    public class ReadAllAnnouncementsEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.ReadAllAnnouncements;
    }

    public class MyTokenRegeneratedEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.MyTokenRegenerated;
    }

    public class SigninEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.Signin;
        public new SigninModel Body { get; init; }
    }

    public class DriveFileCreatedEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.DriveFileCreated;
        public new DriveFileModel Body { get; init; }
    }

    public class ReadAntennaEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.ReadAntenna;
        public new AntennaModel Body { get; init; }
    }

    public class ReceivedFollowRequestEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.ReceiveFollowRequest;
        public new UserModel Body { get; init; }
    }

    public class AnnouncementCreatedEventArgs : ReceivedEventArgs
    {
        public class AnnouncementCreatedEventModel
        {
            public AnnouncementModel Announcement { get; set; }
        }

        public new BodyType Type { get; } = BodyType.AnnouncementCreated;
        public new AnnouncementCreatedEventModel Body { get; init; }
    }

    public class NoteEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.Note;
        public new NoteModel Body { get; init; }
    }

    public class StatsEventArgs : ReceivedEventArgs
    {
        public class ServerStatsModel
        {
            public class MemoryModel
            {
                public decimal Used { get; set; }
                public decimal Active { get; set; }
            }

            public class NetModel
            {
                public decimal Rx { get; set; }
                public decimal Tx { get; set; }
            }

            public class FsModel
            {
                public decimal R { get; set; }
                public decimal W { get; set; }
            }

            public decimal Cpu { get; set; }
            public MemoryModel Memory { get; set; }
            public NetModel Net { get; set; }
        }

        public new BodyType Type { get; } = BodyType.Stats;
        public new ServerStatsModel Body { get; init; }
    }

    public class StatsLogEventArgs : ReceivedEventArgs
    {
        public new BodyType Type { get; } = BodyType.StatsLog;
        public new List<StatsEventArgs.ServerStatsModel> Body { get; init; }
    }

    public class ReactedEventArgs : ReceivedEventArgs
    {
        public class ReactedEventModel
        {
            public class EmojiModel
            {
                public string Name { get; set; }
                public string Url { get; set; }
            }

            public string Reaction { get; set; }
            public EmojiModel? Emoji { get; set; }
            public string UserId { get; set; }
        }

        public new BodyType Type { get; } = BodyType.Reacted;
        public new ReactedEventModel Body { get; init; }
    }

    public class UnreactedEventArgs : ReceivedEventArgs
    {
        public class UnreactedEventModel
        {
            public string Reaction { get; set; }
            public string UserId { get; set; }
        }

        public new BodyType Type { get; } = BodyType.Unreacted;
        public new UnreactedEventModel Body { get; init; }
    }

    public class DeletedEventArgs : ReceivedEventArgs
    {
        public class DeletedEventModel
        {
            public string DeletedAt { get; set; }
        }

        public new BodyType Type { get; } = BodyType.Deleted;
        public new DeletedEventModel Body { get; init; }
    }

    public class PollVotedEventArgs : ReceivedEventArgs
    {
        public class PollVotedEventModel
        {
            public int Choice { get; set; }
            public string UserId { get; set; }
        }

        public new BodyType Type { get; } = BodyType.PollVoted;
        public new PollVotedEventModel Body { get; init; }
    }
}