using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class UsersApi
	{
		private readonly App _app;
		public async Task<Response<List<UserDetailedModel>>> Users(UsersPropertiesSortEnum sort,int limit = 10,int offset = 0,UsersPropertiesStateEnum state = UsersPropertiesStateEnum.All,UsersPropertiesOriginEnum origin = UsersPropertiesOriginEnum.Local,string? hostname = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "offset", offset },
				{ "sort", sort },
				{ "state", state },
				{ "origin", origin },
				{ "hostname", hostname },
			};
			var result = await _app.Request<List<UserDetailedModel>>(
				"users", 
				param, 
				needToken: false
			);
			return result;
		}

		public enum UsersPropertiesSortEnum {
			[EnumMember(Value = "+follower")]
			Plusfollower,
			[EnumMember(Value = "-follower")]
			Minusfollower,
			[EnumMember(Value = "+createdAt")]
			PluscreatedAt,
			[EnumMember(Value = "-createdAt")]
			MinuscreatedAt,
			[EnumMember(Value = "+updatedAt")]
			PlusupdatedAt,
			[EnumMember(Value = "-updatedAt")]
			MinusupdatedAt,
		}
		public enum UsersPropertiesStateEnum {
			[EnumMember(Value = "all")]
			All,
			[EnumMember(Value = "alive")]
			Alive,
		}
		public enum UsersPropertiesOriginEnum {
			[EnumMember(Value = "combined")]
			Combined,
			[EnumMember(Value = "local")]
			Local,
			[EnumMember(Value = "remote")]
			Remote,
		}
		public async Task<Response<List<PostAchievementsItemsModel>>> Achievements(string userId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
			};
			var result = await _app.Request<List<PostAchievementsItemsModel>>(
				"users/achievements", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IPostAchievementsItemsModel
		{
			public string Name { get; set; }
			public decimal UnlockedAt { get; set; }
		}
		public class PostAchievementsItemsModel: IPostAchievementsItemsModel
		{
			public string Name { get; set; }
			public decimal UnlockedAt { get; set; }
		}
		public async Task<Response<List<ClipModel>>> Clips(string userId,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<ClipModel>>(
				"users/clips", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<NoteModel>>> FeaturedNotesGet(string userId,int limit = 10,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "untilId", untilId },
				{ "userId", userId },
			};
			var result = await _app.Request<List<NoteModel>>(
				"users/featured-notes", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<NoteModel>>> FeaturedNotes(string userId,int limit = 10,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "untilId", untilId },
				{ "userId", userId },
			};
			var result = await _app.Request<List<NoteModel>>(
				"users/featured-notes", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<FlashModel>>> Flashs(string userId,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<FlashModel>>(
				"users/flashs", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<FollowingModel>>> Followers(string userId,string username,string? sinceId = null,string? untilId = null,int limit = 10,string? host = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
				{ "userId", userId },
				{ "username", username },
				{ "host", host },
			};
			var result = await _app.Request<List<FollowingModel>>(
				"users/followers", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<FollowingModel>>> Following(string userId,string username,string? sinceId = null,string? untilId = null,int limit = 10,string? host = null,string? birthday = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
				{ "userId", userId },
				{ "username", username },
				{ "host", host },
				{ "birthday", birthday },
			};
			var result = await _app.Request<List<FollowingModel>>(
				"users/following", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<PostGetFrequentlyRepliedUsersItemsModel>>> GetFrequentlyRepliedUsers(string userId,int limit = 10)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<PostGetFrequentlyRepliedUsersItemsModel>>(
				"users/get-frequently-replied-users", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IPostGetFrequentlyRepliedUsersItemsModel
		{
			public UserDetailedModel User { get; set; }
			public decimal Weight { get; set; }
		}
		public class PostGetFrequentlyRepliedUsersItemsModel: IPostGetFrequentlyRepliedUsersItemsModel
		{
			public UserDetailedModel User { get; set; }
			public decimal Weight { get; set; }
		}
		public async Task<Response<List<NoteModel>>> Notes(string userId,bool withReplies = false,bool withRenotes = true,bool withChannelNotes = false,int limit = 10,string? sinceId = null,string? untilId = null,int? sinceDate = null,int? untilDate = null,bool allowPartial = false,bool withFiles = false)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
				{ "withReplies", withReplies },
				{ "withRenotes", withRenotes },
				{ "withChannelNotes", withChannelNotes },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "sinceDate", sinceDate },
				{ "untilDate", untilDate },
				{ "allowPartial", allowPartial },
				{ "withFiles", withFiles },
			};
			var result = await _app.Request<List<NoteModel>>(
				"users/notes", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<PageModel>>> Pages(string userId,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<PageModel>>(
				"users/pages", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<NoteReactionModel>>> Reactions(string userId,int limit = 10,string? sinceId = null,string? untilId = null,int? sinceDate = null,int? untilDate = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "sinceDate", sinceDate },
				{ "untilDate", untilDate },
			};
			var result = await _app.Request<List<NoteReactionModel>>(
				"users/reactions", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<UserDetailedModel>>> Recommendation(int limit = 10,int offset = 0)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "offset", offset },
			};
			var result = await _app.Request<List<UserDetailedModel>>(
				"users/recommendation", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<object>> Relation(JsonNode userId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
			};
			var result = await _app.Request<object>(
				"users/relation", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> ReportAbuse(string userId,string comment)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
				{ "comment", comment },
			};
			var result = await _app.Request<EmptyResponse>(
				"users/report-abuse", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<UserModel>>> Search(string query,int offset = 0,int limit = 10,UsersSearchPropertiesOriginEnum origin = UsersSearchPropertiesOriginEnum.Combined,bool detail = true)
		{
			var param = new Dictionary<string, object?>
			{
				{ "query", query },
				{ "offset", offset },
				{ "limit", limit },
				{ "origin", origin },
				{ "detail", detail },
			};
			var result = await _app.Request<List<UserModel>>(
				"users/search", 
				param, 
				needToken: false
			);
			return result;
		}

		public enum UsersSearchPropertiesOriginEnum {
			[EnumMember(Value = "local")]
			Local,
			[EnumMember(Value = "remote")]
			Remote,
			[EnumMember(Value = "combined")]
			Combined,
		}
		public async Task<Response<List<UserModel>>> SearchByUsernameAndHost(int limit = 10,bool detail = true,string? username = null,string? host = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "detail", detail },
				{ "username", username },
				{ "host", host },
			};
			var result = await _app.Request<List<UserModel>>(
				"users/search-by-username-and-host", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<UserDetailedModel>> Show(string userId,string username,List<string>? userIds = null,string? host = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
				{ "userIds", userIds },
				{ "username", username },
				{ "host", host },
			};
			var result = await _app.Request<UserDetailedModel>(
				"users/show", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> UpdateMemo(string userId,string? memo = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
				{ "memo", memo },
			};
			var result = await _app.Request<EmptyResponse>(
				"users/update-memo", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public readonly Users.GalleryApi GalleryApi;
		public readonly Users.ListsApi ListsApi;
		public UsersApi(App app)
		{
			this._app = app;
			this.GalleryApi = new Users.GalleryApi(this._app);
			this.ListsApi = new Users.ListsApi(this._app);
		}
	}
}
namespace Misharp.Controls.Users
{
	public class GalleryApi
	{
		private readonly App _app;
		public GalleryApi(App app)
		{
			this._app = app;
		}
		public async Task<Response<List<GalleryPostModel>>> Posts(string userId,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<GalleryPostModel>>(
				"users/gallery/posts", 
				param, 
				needToken: false
			);
			return result;
		}

	}
}
namespace Misharp.Controls.Users
{
	public class ListsApi
	{
		private readonly App _app;
		public ListsApi(App app)
		{
			this._app = app;
		}
		public async Task<Response<UserListModel>> Create(string name)
		{
			var param = new Dictionary<string, object?>
			{
				{ "name", name },
			};
			var result = await _app.Request<UserListModel>(
				"users/lists/create", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<UserListModel>> CreateFromPublic(string name,string listId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "name", name },
				{ "listId", listId },
			};
			var result = await _app.Request<UserListModel>(
				"users/lists/create-from-public", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Delete(string listId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "listId", listId },
			};
			var result = await _app.Request<EmptyResponse>(
				"users/lists/delete", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Favorite(string listId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "listId", listId },
			};
			var result = await _app.Request<EmptyResponse>(
				"users/lists/favorite", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<PostGetMembershipsItemsModel>>> GetMemberships(string listId,bool forPublic = false,int limit = 30,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "listId", listId },
				{ "forPublic", forPublic },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<PostGetMembershipsItemsModel>>(
				"users/lists/get-memberships", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IPostGetMembershipsItemsModel
		{
			public string Id { get; set; }
			public DateTime? CreatedAt { get; set; }
			public string UserId { get; set; }
			public UserLiteModel User { get; set; }
			public bool WithReplies { get; set; }
		}
		public class PostGetMembershipsItemsModel: IPostGetMembershipsItemsModel
		{
			public string Id { get; set; }
			public DateTime? CreatedAt { get; set; }
			public string UserId { get; set; }
			public UserLiteModel User { get; set; }
			public bool WithReplies { get; set; }
		}
		public async Task<Response<List<UserListModel>>> List(string userId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
			};
			var result = await _app.Request<List<UserListModel>>(
				"users/lists/list", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Pull(string listId,string userId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "listId", listId },
				{ "userId", userId },
			};
			var result = await _app.Request<EmptyResponse>(
				"users/lists/pull", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Push(string listId,string userId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "listId", listId },
				{ "userId", userId },
			};
			var result = await _app.Request<EmptyResponse>(
				"users/lists/push", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<UserListModel>> Show(string listId,bool forPublic = false)
		{
			var param = new Dictionary<string, object?>
			{
				{ "listId", listId },
				{ "forPublic", forPublic },
			};
			var result = await _app.Request<UserListModel>(
				"users/lists/show", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Unfavorite(string listId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "listId", listId },
			};
			var result = await _app.Request<EmptyResponse>(
				"users/lists/unfavorite", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<UserListModel>> Update(string listId,string name,bool isPublic)
		{
			var param = new Dictionary<string, object?>
			{
				{ "listId", listId },
				{ "name", name },
				{ "isPublic", isPublic },
			};
			var result = await _app.Request<UserListModel>(
				"users/lists/update", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> UpdateMembership(string listId,string userId,bool withReplies)
		{
			var param = new Dictionary<string, object?>
			{
				{ "listId", listId },
				{ "userId", userId },
				{ "withReplies", withReplies },
			};
			var result = await _app.Request<EmptyResponse>(
				"users/lists/update-membership", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

	}
}
