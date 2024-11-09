using Misharp.Models;
using System.Text.Json;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class NotesApi
	{
		private readonly App _app;
		public async Task<Response<List<NoteModel>>> Notes(bool reply,bool renote,bool withFiles,bool poll,bool local = false,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "local", local },
				{ "reply", reply },
				{ "renote", renote },
				{ "withFiles", withFiles },
				{ "poll", poll },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<NoteModel>>(
				"notes", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<NoteModel>>> Children(string noteId,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "noteId", noteId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<NoteModel>>(
				"notes/children", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<ClipModel>>> Clips(string noteId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<List<ClipModel>>(
				"notes/clips", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<NoteModel>>> Conversation(string noteId,int limit = 10,int offset = 0)
		{
			var param = new Dictionary<string, object?>
			{
				{ "noteId", noteId },
				{ "limit", limit },
				{ "offset", offset },
			};
			var result = await _app.Request<List<NoteModel>>(
				"notes/conversation", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<NotesCreateModel>> Create(NotesCreatePropertiesVisibilityEnum visibility = NotesCreatePropertiesVisibilityEnum.Public,List<string>? visibleUserIds = null,string? cw = null,bool localOnly = false,NotesCreatePropertiesReactionAcceptanceEnum? reactionAcceptance = null,bool noExtractMentions = false,bool noExtractHashtags = false,bool noExtractEmojis = false,string? replyId = null,string? renoteId = null,string? channelId = null,string? text = null,List<string>? fileIds = null,List<string>? mediaIds = null,NotesCreatePropertiesPollModel? poll = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "visibility", visibility },
				{ "visibleUserIds", visibleUserIds },
				{ "cw", cw },
				{ "localOnly", localOnly },
				{ "reactionAcceptance", reactionAcceptance },
				{ "noExtractMentions", noExtractMentions },
				{ "noExtractHashtags", noExtractHashtags },
				{ "noExtractEmojis", noExtractEmojis },
				{ "replyId", replyId },
				{ "renoteId", renoteId },
				{ "channelId", channelId },
				{ "text", text },
				{ "fileIds", fileIds },
				{ "mediaIds", mediaIds },
				{ "poll", poll },
			};
			var result = await _app.Request<NotesCreateModel>(
				"notes/create", 
				param, 
				needToken: true
			);
			return result;
		}

		public enum NotesCreatePropertiesVisibilityEnum {
			[EnumMember(Value = "public")]
			Public,
			[EnumMember(Value = "home")]
			Home,
			[EnumMember(Value = "followers")]
			Followers,
			[EnumMember(Value = "specified")]
			Specified,
		}
		public enum NotesCreatePropertiesReactionAcceptanceEnum {
			[EnumMember(Value = "likeOnly")]
			LikeOnly,
			[EnumMember(Value = "likeOnlyForRemote")]
			LikeOnlyForRemote,
			[EnumMember(Value = "nonSensitiveOnly")]
			NonSensitiveOnly,
			[EnumMember(Value = "nonSensitiveOnlyForLocalLikeOnlyForRemote")]
			NonSensitiveOnlyForLocalLikeOnlyForRemote,
		}
		public interface INotesCreatePropertiesPollModel
		{
			public List<string> Choices { get; set; }
			public bool Multiple { get; set; }
			public int? ExpiresAt { get; set; }
			public int? ExpiredAfter { get; set; }
		}
		public class NotesCreatePropertiesPollModel: INotesCreatePropertiesPollModel
		{
			public List<string> Choices { get; set; }
			public bool Multiple { get; set; }
			public int? ExpiresAt { get; set; }
			public int? ExpiredAfter { get; set; }
		}
		public interface INotesCreateModel
		{
			public NoteModel CreatedNote { get; set; }
		}
		public class NotesCreateModel: INotesCreateModel
		{
			public NoteModel CreatedNote { get; set; }
		}
		public async Task<Response<EmptyResponse>> Delete(string noteId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<EmptyResponse>(
				"notes/delete", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<NoteModel>>> FeaturedGet(int limit = 10,string? untilId = null,string? channelId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "untilId", untilId },
				{ "channelId", channelId },
			};
			var result = await _app.Request<List<NoteModel>>(
				"notes/featured", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<NoteModel>>> Featured(int limit = 10,string? untilId = null,string? channelId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "untilId", untilId },
				{ "channelId", channelId },
			};
			var result = await _app.Request<List<NoteModel>>(
				"notes/featured", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<NoteModel>>> GlobalTimeline(bool withFiles = false,bool withRenotes = true,int limit = 10,string? sinceId = null,string? untilId = null,int? sinceDate = null,int? untilDate = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "withFiles", withFiles },
				{ "withRenotes", withRenotes },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "sinceDate", sinceDate },
				{ "untilDate", untilDate },
			};
			var result = await _app.Request<List<NoteModel>>(
				"notes/global-timeline", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<NoteModel>>> HybridTimeline(int limit = 10,string? sinceId = null,string? untilId = null,int? sinceDate = null,int? untilDate = null,bool allowPartial = false,bool includeMyRenotes = true,bool includeRenotedMyNotes = true,bool includeLocalRenotes = true,bool withFiles = false,bool withRenotes = true,bool withReplies = false)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "sinceDate", sinceDate },
				{ "untilDate", untilDate },
				{ "allowPartial", allowPartial },
				{ "includeMyRenotes", includeMyRenotes },
				{ "includeRenotedMyNotes", includeRenotedMyNotes },
				{ "includeLocalRenotes", includeLocalRenotes },
				{ "withFiles", withFiles },
				{ "withRenotes", withRenotes },
				{ "withReplies", withReplies },
			};
			var result = await _app.Request<List<NoteModel>>(
				"notes/hybrid-timeline", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<NoteModel>>> LocalTimeline(bool withFiles = false,bool withRenotes = true,bool withReplies = false,int limit = 10,string? sinceId = null,string? untilId = null,bool allowPartial = false,int? sinceDate = null,int? untilDate = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "withFiles", withFiles },
				{ "withRenotes", withRenotes },
				{ "withReplies", withReplies },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "allowPartial", allowPartial },
				{ "sinceDate", sinceDate },
				{ "untilDate", untilDate },
			};
			var result = await _app.Request<List<NoteModel>>(
				"notes/local-timeline", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<NoteModel>>> Mentions(string visibility,bool following = false,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "following", following },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "visibility", visibility },
			};
			var result = await _app.Request<List<NoteModel>>(
				"notes/mentions", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<NoteReactionModel>>> ReactionsGet(string noteId,string? type = null,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "noteId", noteId },
				{ "type", type },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<NoteReactionModel>>(
				"notes/reactions", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<NoteReactionModel>>> Reactions(string noteId,string? type = null,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "noteId", noteId },
				{ "type", type },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<NoteReactionModel>>(
				"notes/reactions", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<NoteModel>>> Renotes(string noteId,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "noteId", noteId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<NoteModel>>(
				"notes/renotes", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<NoteModel>>> Replies(string noteId,string? sinceId = null,string? untilId = null,int limit = 10)
		{
			var param = new Dictionary<string, object?>
			{
				{ "noteId", noteId },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<NoteModel>>(
				"notes/replies", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<NoteModel>>> SearchByTag(string tag,bool? reply = null,bool? renote = null,bool withFiles = false,bool? poll = null,string? sinceId = null,string? untilId = null,int limit = 10,List<List<List<string>>>? query = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "reply", reply },
				{ "renote", renote },
				{ "withFiles", withFiles },
				{ "poll", poll },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
				{ "tag", tag },
				{ "query", query },
			};
			var result = await _app.Request<List<NoteModel>>(
				"notes/search-by-tag", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<NoteModel>>> Search(string query,string host,string? sinceId = null,string? untilId = null,int limit = 10,int offset = 0,string? userId = null,string? channelId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "query", query },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
				{ "offset", offset },
				{ "host", host },
				{ "userId", userId },
				{ "channelId", channelId },
			};
			var result = await _app.Request<List<NoteModel>>(
				"notes/search", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<NoteModel>> Show(string noteId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<NoteModel>(
				"notes/show", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<NotesStateModel>> State(string noteId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<NotesStateModel>(
				"notes/state", 
				param, 
				needToken: true
			);
			return result;
		}

		public interface INotesStateModel
		{
			public bool IsFavorited { get; set; }
			public bool IsMutedThread { get; set; }
		}
		public class NotesStateModel: INotesStateModel
		{
			public bool IsFavorited { get; set; }
			public bool IsMutedThread { get; set; }
		}
		public async Task<Response<List<NoteModel>>> Timeline(int limit = 10,string? sinceId = null,string? untilId = null,int? sinceDate = null,int? untilDate = null,bool allowPartial = false,bool includeMyRenotes = true,bool includeRenotedMyNotes = true,bool includeLocalRenotes = true,bool withFiles = false,bool withRenotes = true)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "sinceDate", sinceDate },
				{ "untilDate", untilDate },
				{ "allowPartial", allowPartial },
				{ "includeMyRenotes", includeMyRenotes },
				{ "includeRenotedMyNotes", includeRenotedMyNotes },
				{ "includeLocalRenotes", includeLocalRenotes },
				{ "withFiles", withFiles },
				{ "withRenotes", withRenotes },
			};
			var result = await _app.Request<List<NoteModel>>(
				"notes/timeline", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<NotesTranslateModel>> Translate(string noteId,string targetLang)
		{
			var param = new Dictionary<string, object?>
			{
				{ "noteId", noteId },
				{ "targetLang", targetLang },
			};
			var result = await _app.Request<NotesTranslateModel>(
				"notes/translate", 
				param, 
				needToken: true
			);
			return result;
		}

		public interface INotesTranslateModel
		{
			public string SourceLang { get; set; }
			public string Text { get; set; }
		}
		public class NotesTranslateModel: INotesTranslateModel
		{
			public string SourceLang { get; set; }
			public string Text { get; set; }
		}
		public async Task<Response<EmptyResponse>> Unrenote(string noteId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<EmptyResponse>(
				"notes/unrenote", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<NoteModel>>> UserListTimeline(string listId,int limit = 10,string? sinceId = null,string? untilId = null,int? sinceDate = null,int? untilDate = null,bool allowPartial = false,bool includeMyRenotes = true,bool includeRenotedMyNotes = true,bool includeLocalRenotes = true,bool withRenotes = true,bool withFiles = false)
		{
			var param = new Dictionary<string, object?>
			{
				{ "listId", listId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "sinceDate", sinceDate },
				{ "untilDate", untilDate },
				{ "allowPartial", allowPartial },
				{ "includeMyRenotes", includeMyRenotes },
				{ "includeRenotedMyNotes", includeRenotedMyNotes },
				{ "includeLocalRenotes", includeLocalRenotes },
				{ "withRenotes", withRenotes },
				{ "withFiles", withFiles },
			};
			var result = await _app.Request<List<NoteModel>>(
				"notes/user-list-timeline", 
				param, 
				needToken: true
			);
			return result;
		}

		public readonly Notes.FavoritesApi FavoritesApi;
		public readonly Notes.PollsApi PollsApi;
		public readonly Notes.ReactionsApi ReactionsApi;
		public readonly Notes.ThreadMutingApi ThreadMutingApi;
		public NotesApi(App app)
		{
			this._app = app;
			this.FavoritesApi = new Notes.FavoritesApi(this._app);
			this.PollsApi = new Notes.PollsApi(this._app);
			this.ReactionsApi = new Notes.ReactionsApi(this._app);
			this.ThreadMutingApi = new Notes.ThreadMutingApi(this._app);
		}
	}
}
namespace Misharp.Controls.Notes
{
	public class FavoritesApi
	{
		private readonly App _app;
		public FavoritesApi(App app)
		{
			this._app = app;
		}
		public async Task<Response<EmptyResponse>> Create(string noteId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<EmptyResponse>(
				"notes/favorites/create", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Delete(string noteId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<EmptyResponse>(
				"notes/favorites/delete", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

	}
}
namespace Misharp.Controls.Notes
{
	public class PollsApi
	{
		private readonly App _app;
		public PollsApi(App app)
		{
			this._app = app;
		}
		public async Task<Response<List<NoteModel>>> Recommendation(int limit = 10,int offset = 0,bool excludeChannels = false)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "offset", offset },
				{ "excludeChannels", excludeChannels },
			};
			var result = await _app.Request<List<NoteModel>>(
				"notes/polls/recommendation", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Vote(string noteId,int choice)
		{
			var param = new Dictionary<string, object?>
			{
				{ "noteId", noteId },
				{ "choice", choice },
			};
			var result = await _app.Request<EmptyResponse>(
				"notes/polls/vote", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

	}
}
namespace Misharp.Controls.Notes
{
	public class ReactionsApi
	{
		private readonly App _app;
		public ReactionsApi(App app)
		{
			this._app = app;
		}
		public async Task<Response<EmptyResponse>> Create(string noteId,string reaction)
		{
			var param = new Dictionary<string, object?>
			{
				{ "noteId", noteId },
				{ "reaction", reaction },
			};
			var result = await _app.Request<EmptyResponse>(
				"notes/reactions/create", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Delete(string noteId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<EmptyResponse>(
				"notes/reactions/delete", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

	}
}
namespace Misharp.Controls.Notes
{
	public class ThreadMutingApi
	{
		private readonly App _app;
		public ThreadMutingApi(App app)
		{
			this._app = app;
		}
		public async Task<Response<EmptyResponse>> Create(string noteId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<EmptyResponse>(
				"notes/thread-muting/create", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Delete(string noteId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<EmptyResponse>(
				"notes/thread-muting/delete", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

	}
}
