namespace Misharp.Streaming;

public abstract class Handlers
{
    public delegate void ReceivedHandler(EventArgs.ReceivedEventArgs e);

    public delegate void NotificationHandler(EventArgs.NotificationEventArgs e);

    public delegate void MentionHandler(EventArgs.MentionEventArgs e);

    public delegate void ReplyHandler(EventArgs.ReplyEventArgs e);

    public delegate void RenoteHandler(EventArgs.RenoteEventArgs e);

    public delegate void FollowHandler(EventArgs.FollowEventArgs e);

    public delegate void FollowedHandler(EventArgs.FollowedEventArgs e);

    public delegate void UnfollowHandler(EventArgs.UnfollowEventArgs e);

    public delegate void MeUpdatedHandler(EventArgs.MeUpdatedEventArgs e);

    public delegate void UrlUploadFinishedHandler(EventArgs.UrlUploadFinishedEventArgs e);

    public delegate void ReadAllNotificationsHandler(EventArgs.ReadAllNotificationsEventArgs e);

    public delegate void UnreadNotificationHandler(EventArgs.UnreadNotificationEventArgs e);

    public delegate void UnreadMentionHandler(EventArgs.UnreadMentionEventArgs e);

    public delegate void ReadAllUnreadMentionsHandler(EventArgs.ReadAllUnreadMentionsEventArgs e);

    public delegate void NotificationFlushedHandler(EventArgs.NotificationFlushedEventArgs e);

    public delegate void UnreadSpecifiedNoteHandler(EventArgs.UnreadSpecifiedNoteEventArgs e);

    public delegate void ReadAllUnreadSpecifiedNotesHandler(EventArgs.ReadAllUnreadSpecifiedNotesEventArgs e);

    public delegate void ReadAllAntennasHandler(EventArgs.ReadAllAntennasEventArgs e);

    public delegate void UnreadAntennaHandler(EventArgs.UnreadAntennaEventArgs e);

    public delegate void ReadAllAnnouncementsHandler(EventArgs.ReadAllAnnouncementsEventArgs e);

    public delegate void MyTokenRegeneratedHandler(EventArgs.MyTokenRegeneratedEventArgs e);

    public delegate void SigninHandler(EventArgs.SigninEventArgs e);

    public delegate void DriveFileCreatedHandler(EventArgs.DriveFileCreatedEventArgs e);

    public delegate void ReadAntennaHandler(EventArgs.ReadAntennaEventArgs e);

    public delegate void ReceivedFollowRequestHandler(EventArgs.ReceivedFollowRequestEventArgs e);

    public delegate void AnnouncementCreatedHandler(EventArgs.AnnouncementCreatedEventArgs e);

    public delegate void NoteHandler(EventArgs.NoteEventArgs e);

    public delegate void StatsHandler(EventArgs.StatsEventArgs e);

    public delegate void StatsLogHandler(EventArgs.StatsLogEventArgs e);

    public delegate void ReactedHandler(EventArgs.ReactedEventArgs e);

    public delegate void UnreactedHandler(EventArgs.UnreactedEventArgs e);

    public delegate void DeletedHandler(EventArgs.DeletedEventArgs e);

    public delegate void PollVotedHandler(EventArgs.PollVotedEventArgs e);
}