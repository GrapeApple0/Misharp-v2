using System.Net.WebSockets;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using Misharp.Controls;
using Misharp.Models;
using Misharp.Streaming.Enums;

namespace Misharp.Streaming;

public class Streaming
{
    public event Handlers.ReceivedHandler? Received;
    public event Handlers.NotificationHandler? NotificationReceived;
    public event Handlers.MentionHandler? MentionReceived;
    public event Handlers.ReplyHandler? ReplyReceived;
    public event Handlers.RenoteHandler? RenoteReceived;
    public event Handlers.FollowHandler? FollowReceived;
    public event Handlers.FollowedHandler? FollowedReceived;
    public event Handlers.UnfollowHandler? UnfollowReceived;
    public event Handlers.MeUpdatedHandler? MeUpdatedReceived;
    public event Handlers.UrlUploadFinishedHandler? UrlUploadFinishedReceived;
    public event Handlers.ReadAllNotificationsHandler? ReadAllNotificationsReceived;
    public event Handlers.UnreadNotificationHandler? UnreadNotificationReceived;
    public event Handlers.UnreadMentionHandler? UnreadMentionReceived;
    public event Handlers.ReadAllUnreadMentionsHandler? ReadAllUnreadMentionsReceived;
    public event Handlers.NotificationFlushedHandler? NotificationFlushedReceived;
    public event Handlers.UnreadSpecifiedNoteHandler? UnreadSpecifiedNoteReceived;
    public event Handlers.ReadAllUnreadSpecifiedNotesHandler? ReadAllUnreadSpecifiedNotesReceived;
    public event Handlers.ReadAllAntennasHandler? ReadAllAntennasReceived;
    public event Handlers.UnreadAntennaHandler? UnreadAntennaReceived;
    public event Handlers.ReadAllAnnouncementsHandler? ReadAllAnnouncementsReceived;
    public event Handlers.MyTokenRegeneratedHandler? MyTokenRegeneratedReceived;
    public event Handlers.SigninHandler? SigninReceived;
    public event Handlers.DriveFileCreatedHandler? DriveFileCreatedReceived;
    public event Handlers.ReadAntennaHandler? ReadAntennaReceived;
    public event Handlers.ReceivedFollowRequestHandler? ReceivedFollowRequestReceived;
    public event Handlers.AnnouncementCreatedHandler? AnnouncementCreatedReceived;
    public event Handlers.NoteHandler? NoteReceived;
    public event Handlers.StatsHandler? StatsReceived;
    public event Handlers.StatsLogHandler? StatsLogReceived;
    public event Handlers.ReactedHandler? ReactedReceived;
    public event Handlers.UnreactedHandler? UnreactedReceived;
    public event Handlers.DeletedHandler? DeletedReceived;
    public event Handlers.PollVotedHandler? PollVotedReceived;

    private readonly HashSet<string> _ids = new();
    private readonly string _uri;
    private readonly ClientWebSocket _ws = new();
    private readonly CancellationTokenSource _cancellationTokenSource = new();

    public Streaming(App app)
    {
        _uri = $"ws{(app.UseHttps ? "s" : "")}://{app.Host}/streaming?i={app.Token}";
    }

    public async Task Start()
    {
        if (_ws.State == WebSocketState.Open) return;
        await _ws.ConnectAsync(new Uri(_uri), _cancellationTokenSource.Token);
        _ = ReceiveLoop();
    }

    public async Task Stop()
    {
        while (true)
        {
            if (!_cancellationTokenSource.Token.CanBeCanceled) continue;
            _cancellationTokenSource.Cancel();
            break;
        }

        await Task.Delay(1000);
    }

    private async Task ReceiveLoop()
    {
        var buffer = new byte[65535];
        try
        {
            while (!_cancellationTokenSource.IsCancellationRequested)
            {
                var segment = new ArraySegment<byte>(buffer);
                var result = await _ws.ReceiveAsync(segment, _cancellationTokenSource.Token);
                var count = result.Count;
                while (!result.EndOfMessage)
                {
                    if (count >= buffer.Length)
                    {
                        Console.WriteLine("Too long data");
                        await _ws.CloseAsync(WebSocketCloseStatus.InvalidPayloadData, "Too long data",
                            _cancellationTokenSource.Token);
                        break;
                    }

                    segment = new ArraySegment<byte>(buffer, count, buffer.Length - count);
                    result = await _ws.ReceiveAsync(segment, _cancellationTokenSource.Token);
                    count += result.Count;
                }

                var res = Encoding.UTF8.GetString(buffer, 0, count);
                var message = JsonSerializer.Deserialize<Models.Message>(res, Config.JsonSerializerOptions);
                if (message != null) Handle(message);
            }
        }
        catch (Exception e)
        {
            if (e is OperationCanceledException)
                await _ws.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing request by user",
                    _cancellationTokenSource.Token);
        }
    }

    private void Handle(Models.Message message)
    {
        Received?.Invoke(new EventArgs.ReceivedEventArgs
        {
            Id = message.Body.Id,
            Type = message.Body.Type,
            Body = message.Body
        });
        NotificationModel? notificationModelBody;
        NoteModel? noteModelBody;
        UserLiteModel? userLiteModelBody;
        AntennaModel? antennaModelBody;

        switch (message.Body.Type)
        {
            case BodyType.Notification:
                notificationModelBody = JsonSerializer.Deserialize<NotificationModel>(
                    message.Body.Body.ToString(),
                    Config.JsonSerializerOptions);
                if (notificationModelBody == null)
                    throw new Exception("Failed to deserialize notification model");

                NotificationReceived?.Invoke(new EventArgs.NotificationEventArgs
                {
                    Id = message.Body.Id,
                    Body = notificationModelBody
                });
                break;
            case BodyType.Mention:
                noteModelBody = JsonSerializer.Deserialize<NoteModel>(message.Body.Body.ToString(),
                    Config.JsonSerializerOptions);
                if (noteModelBody == null) throw new Exception("Failed to deserialize note model");
                MentionReceived?.Invoke(new EventArgs.MentionEventArgs
                {
                    Id = message.Body.Id,
                    Body = noteModelBody
                });
                break;
            case BodyType.Reply:
                noteModelBody = JsonSerializer.Deserialize<NoteModel>(message.Body.Body.ToString(),
                    Config.JsonSerializerOptions);
                if (noteModelBody == null) throw new Exception("Failed to deserialize note model");
                ReplyReceived?.Invoke(new EventArgs.ReplyEventArgs
                {
                    Id = message.Body.Id,
                    Body = noteModelBody
                });
                break;
            case BodyType.Renote:
                noteModelBody = JsonSerializer.Deserialize<NoteModel>(message.Body.Body.ToString(),
                    Config.JsonSerializerOptions);
                if (noteModelBody == null) throw new Exception("Failed to deserialize note model");
                RenoteReceived?.Invoke(new EventArgs.RenoteEventArgs
                {
                    Id = message.Body.Id,
                    Body = noteModelBody
                });
                break;
            case BodyType.Follow:
                var userDetailedNotMeModel = JsonSerializer.Deserialize<UserDetailedNotMeModel>(
                    message.Body.Body.ToString(),
                    Config.JsonSerializerOptions);
                if (userDetailedNotMeModel == null) throw new Exception("Failed to deserialize user detailed model");
                FollowReceived?.Invoke(new EventArgs.FollowEventArgs
                {
                    Id = message.Body.Id,
                    Body = userDetailedNotMeModel
                });
                break;
            case BodyType.Followed:
                userLiteModelBody = JsonSerializer.Deserialize<UserLiteModel>(message.Body.Body.ToString(),
                    Config.JsonSerializerOptions);
                if (userLiteModelBody == null) throw new Exception("Failed to deserialize user lite model");
                FollowedReceived?.Invoke(new EventArgs.FollowedEventArgs
                {
                    Id = message.Body.Id,
                    Body = userLiteModelBody
                });
                break;
            case BodyType.Unfollow:
                userLiteModelBody = JsonSerializer.Deserialize<UserLiteModel>(message.Body.Body.ToString(),
                    Config.JsonSerializerOptions);
                if (userLiteModelBody == null) throw new Exception("Failed to deserialize user lite model");
                UnfollowReceived?.Invoke(new EventArgs.UnfollowEventArgs
                {
                    Id = message.Body.Id,
                    Body = userLiteModelBody
                });
                break;
            case BodyType.MeUpdated:
                var userDetailedModel = JsonSerializer.Deserialize<UserDetailedModel>(message.Body.Body.ToString(),
                    Config.JsonSerializerOptions);
                if (userDetailedModel == null) throw new Exception("Failed to deserialize user detailed model");
                MeUpdatedReceived?.Invoke(new EventArgs.MeUpdatedEventArgs
                {
                    Id = message.Body.Id,
                    Body = userDetailedModel
                });
                break;
            case BodyType.UrlUploadFinished:
                var urlUploadFinishedEventModel = JsonSerializer
                    .Deserialize<EventArgs.UrlUploadFinishedEventArgs.UrlUploadFinishedEventModel>(
                        message.Body.Body.ToString(), Config.JsonSerializerOptions);
                if (urlUploadFinishedEventModel == null) break;
                UrlUploadFinishedReceived?.Invoke(new EventArgs.UrlUploadFinishedEventArgs
                {
                    Id = message.Body.Id,
                    Body = urlUploadFinishedEventModel
                });
                break;
            case BodyType.ReadAllNotifications:
                ReadAllNotificationsReceived?.Invoke(new EventArgs.ReadAllNotificationsEventArgs
                {
                    Id = message.Body.Id
                });
                break;
            case BodyType.UnreadNotification:
                notificationModelBody = JsonSerializer.Deserialize<NotificationModel>(
                    message.Body.Body.ToString(),
                    Config.JsonSerializerOptions);
                if (notificationModelBody == null) throw new Exception("Failed to deserialize notification model");
                UnreadNotificationReceived?.Invoke(new EventArgs.UnreadNotificationEventArgs
                {
                    Id = message.Body.Id,
                    Body = notificationModelBody
                });
                break;
            case BodyType.UnreadMention:
                UnreadMentionReceived?.Invoke(new EventArgs.UnreadMentionEventArgs
                {
                    Id = message.Body.Id,
                    Body = message.Body.Body.ToString()
                });
                break;
            case BodyType.ReadAllUnreadMentions:
                ReadAllUnreadMentionsReceived?.Invoke(new EventArgs.ReadAllUnreadMentionsEventArgs
                {
                    Id = message.Body.Id
                });
                break;
            case BodyType.NotificationFlushed:
                NotificationFlushedReceived?.Invoke(new EventArgs.NotificationFlushedEventArgs
                {
                    Id = message.Body.Id
                });
                break;
            case BodyType.UnreadSpecifiedNote:
                UnreadSpecifiedNoteReceived?.Invoke(new EventArgs.UnreadSpecifiedNoteEventArgs
                {
                    Id = message.Body.Id,
                    Body = message.Body.Body.ToString()
                });
                break;
            case BodyType.ReadAllUnreadSpecifiedNotes:
                ReadAllUnreadSpecifiedNotesReceived?.Invoke(new EventArgs.ReadAllUnreadSpecifiedNotesEventArgs
                {
                    Id = message.Body.Id
                });
                break;
            case BodyType.ReadAllAntennas:
                ReadAllAntennasReceived?.Invoke(new EventArgs.ReadAllAntennasEventArgs
                {
                    Id = message.Body.Id
                });
                break;
            case BodyType.UnreadAntenna:
                antennaModelBody = JsonSerializer.Deserialize<AntennaModel>(message.Body.Body.ToString(),
                    Config.JsonSerializerOptions);
                if (antennaModelBody == null) throw new Exception("Failed to deserialize antenna model");
                UnreadAntennaReceived?.Invoke(new EventArgs.UnreadAntennaEventArgs
                {
                    Id = message.Body.Id,
                    Body = antennaModelBody
                });
                break;
            case BodyType.ReadAllAnnouncements:
                ReadAllAnnouncementsReceived?.Invoke(new EventArgs.ReadAllAnnouncementsEventArgs
                {
                    Id = message.Body.Id
                });
                break;
            case BodyType.MyTokenRegenerated:
                MyTokenRegeneratedReceived?.Invoke(new EventArgs.MyTokenRegeneratedEventArgs
                {
                    Id = message.Body.Id
                });
                break;
            case BodyType.Signin:
                var signinModelBody = JsonSerializer.Deserialize<SigninModel>(message.Body.Body.ToString(),
                    Config.JsonSerializerOptions);
                if (signinModelBody == null) throw new Exception("Failed to deserialize signin model");
                SigninReceived?.Invoke(new EventArgs.SigninEventArgs
                {
                    Id = message.Body.Id,
                    Body = signinModelBody
                });
                break;
            case BodyType.DriveFileCreated:
                var driveFileModelBody = JsonSerializer.Deserialize<DriveFileModel>(message.Body.Body.ToString(),
                    Config.JsonSerializerOptions);
                if (driveFileModelBody == null) throw new Exception("Failed to deserialize drive file model");
                DriveFileCreatedReceived?.Invoke(new EventArgs.DriveFileCreatedEventArgs
                {
                    Id = message.Body.Id,
                    Body = driveFileModelBody
                });
                break;
            case BodyType.ReadAntenna:
                antennaModelBody = JsonSerializer.Deserialize<AntennaModel>(message.Body.Body.ToString(),
                    Config.JsonSerializerOptions);
                if (antennaModelBody == null) throw new Exception("Failed to deserialize antenna model");
                ReadAntennaReceived?.Invoke(new EventArgs.ReadAntennaEventArgs()
                {
                    Id = message.Body.Id,
                    Body = antennaModelBody
                });
                break;
            case BodyType.ReceiveFollowRequest:
                var user = JsonSerializer.Deserialize<UserModel>(message.Body.Body.ToString(),
                    Config.JsonSerializerOptions);
                if (user == null) throw new Exception("Failed to deserialize user model");
                ReceivedFollowRequestReceived?.Invoke(new EventArgs.ReceivedFollowRequestEventArgs
                {
                    Id = message.Body.Id,
                    Body = user
                });
                break;
            case BodyType.AnnouncementCreated:
                var announcementCreated =
                    JsonSerializer.Deserialize<EventArgs.AnnouncementCreatedEventArgs.AnnouncementCreatedEventModel>(
                        message.Body.Body.ToString(), Config.JsonSerializerOptions);
                if (announcementCreated == null)
                    throw new Exception("Failed to deserialize announcement created model");
                AnnouncementCreatedReceived?.Invoke(new EventArgs.AnnouncementCreatedEventArgs
                {
                    Id = message.Body.Id,
                    Body = announcementCreated
                });
                break;
            // timeline
            case BodyType.Note:
                noteModelBody = JsonSerializer.Deserialize<NoteModel>(message.Body.Body.ToString(),
                    Config.JsonSerializerOptions);
                if (noteModelBody == null) break;
                NoteReceived?.Invoke(new EventArgs.NoteEventArgs
                {
                    Id = message.Body.Id,
                    Body = noteModelBody
                });
                break;
            // case BodyType.Stats:
            //     var serverStats = JsonSerializer.Deserialize<EventArgs.StatsEventArgs.ServerStatsModel>(
            //         message.Body.Body.ToString(), Config.JsonSerializerOptions);
            //     if (serverStats == null) throw new Exception("Failed to deserialize server stats model");
            //     StatsReceived?.Invoke(new EventArgs.StatsEventArgs
            //     {
            //         Id = message.Body.Id,
            //         Body = serverStats
            //     });
            //     break;
            // case BodyType.StatsLog:
            //     var serverStatsLog = JsonSerializer.Deserialize<List<EventArgs.StatsEventArgs.ServerStatsModel>>(
            //         message.Body.Body.ToString(), Config.JsonSerializerOptions);
            //     if (serverStatsLog == null) throw new Exception("Failed to deserialize server stats log model");
            //     StatsLogReceived?.Invoke(new EventArgs.StatsLogEventArgs()
            //     {
            //         Id = message.Body.Id,
            //         Body = serverStatsLog
            //     });
            //     break;
            case BodyType.Reacted:
                var reacted = JsonSerializer.Deserialize<EventArgs.ReactedEventArgs.ReactedEventModel>(
                    message.Body.Body.ToString(), Config.JsonSerializerOptions);
                if (reacted == null) throw new Exception("Failed to deserialize reacted model");
                ReactedReceived?.Invoke(new EventArgs.ReactedEventArgs
                {
                    Id = message.Body.Id,
                    Body = reacted
                });
                break;
            case BodyType.Unreacted:
                var unreacted = JsonSerializer.Deserialize<EventArgs.UnreactedEventArgs.UnreactedEventModel>(
                    message.Body.Body.ToString(), Config.JsonSerializerOptions);
                if (unreacted == null) throw new Exception("Failed to deserialize unreacted model");
                UnreactedReceived?.Invoke(new EventArgs.UnreactedEventArgs
                {
                    Id = message.Body.Id,
                    Body = unreacted
                });
                break;
            case BodyType.Deleted:
                var deleted = JsonSerializer.Deserialize<EventArgs.DeletedEventArgs.DeletedEventModel>(
                    message.Body.Body.ToString(),
                    Config.JsonSerializerOptions);
                if (deleted == null) throw new Exception("Failed to deserialize deleted model");
                DeletedReceived?.Invoke(new EventArgs.DeletedEventArgs
                {
                    Id = message.Body.Id,
                    Body = deleted
                });
                break;
            case BodyType.PollVoted:
                var pollVoted = JsonSerializer.Deserialize<EventArgs.PollVotedEventArgs.PollVotedEventModel>(
                    message.Body.Body.ToString(),
                    Config.JsonSerializerOptions);
                if (pollVoted == null) throw new Exception("Failed to deserialize poll voted model");
                PollVotedReceived?.Invoke(new EventArgs.PollVotedEventArgs
                {
                    Id = message.Body.Id,
                    Body = pollVoted
                });
                break;
        }
    }

    private async Task Send(string content)
    {
        var buffer = Encoding.UTF8.GetBytes(content);
        var segment = new ArraySegment<byte>(buffer);
        await _ws.SendAsync(segment, WebSocketMessageType.Text, true, _cancellationTokenSource.Token);
    }

    public async Task Subscribe(ChannelType channel, string id)
    {
        if (!_ids.Add(id)) throw new Exception("This id is already in use");
        var param = new Dictionary<string, object>
        {
            { "type", "connect" },
            {
                "body", new Dictionary<string, object>
                {
                    { "channel", channel },
                    { "id", id }
                }
            }
        };
        var jsonText = JsonSerializer.Serialize(param, Config.JsonSerializerOptions);
        await Send(jsonText);
    }

    public async Task Subscribe(ChannelType channel, string id,
        bool withRenotes = false,
        bool withReplies = false,
        bool withFiles = false)
    {
        if (!_ids.Add(id)) throw new Exception("This id is already in use");
        var param = new Dictionary<string, object>
        {
            { "type", "connect" },
            {
                "body", new Dictionary<string, object>
                {
                    { "channel", channel },
                    { "id", id },
                    { "withRenotes", withRenotes },
                    { "withReplies", withReplies },
                    { "withFiles", withFiles }
                }
            }
        };
        var jsonText = JsonSerializer.Serialize(param, Config.JsonSerializerOptions);
        await Send(jsonText);
    }

    public async Task Subscribe(string noteId)
    {
        if (!_ids.Add(noteId)) throw new Exception("This noteId is already captured");
        var param = new Dictionary<string, object>
        {
            { "type", "subNote" },
            {
                "body", new Dictionary<string, object>
                {
                    { "id", noteId }
                }
            }
        };
        var jsonText = JsonSerializer.Serialize(param, Config.JsonSerializerOptions);
        await Send(jsonText);
    }

    public async Task Unsubscribe(int id)
    {
        var param = new Dictionary<string, object>
        {
            { "type", "disconnect" },
            {
                "body", new Dictionary<string, object>
                {
                    { "id", id.ToString() }
                }
            }
        };
        var jsonText = JsonSerializer.Serialize(param, Config.JsonSerializerOptions);
        await Send(jsonText);
    }

    public async Task Unsubscribe(string noteId)
    {
        var param = new Dictionary<string, object>
        {
            { "type", "unsubNote" },
            {
                "body", new Dictionary<string, object>
                {
                    { "id", noteId }
                }
            }
        };
        var jsonText = JsonSerializer.Serialize(param, Config.JsonSerializerOptions);
        await Send(jsonText);
    }
}