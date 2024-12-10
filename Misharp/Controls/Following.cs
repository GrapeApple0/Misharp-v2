using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class FollowingApi
	{
		private readonly App _app;
		public async Task<Response<UserLiteModel>> Create(string userId,bool withReplies)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
				{ "withReplies", withReplies },
			};
			var result = await _app.Request<UserLiteModel>(
				"following/create", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<UserLiteModel>> Delete(string userId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
			};
			var result = await _app.Request<UserLiteModel>(
				"following/delete", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<UserLiteModel>> Update(string userId,FollowingUpdatePropertiesNotifyEnum notify,bool withReplies)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
				{ "notify", notify },
				{ "withReplies", withReplies },
			};
			var result = await _app.Request<UserLiteModel>(
				"following/update", 
				param, 
				needToken: true
			);
			return result;
		}

		public enum FollowingUpdatePropertiesNotifyEnum {
			[EnumMember(Value = "normal")]
			Normal,
			[EnumMember(Value = "none")]
			None,
		}
		public async Task<Response<EmptyResponse>> UpdateAll(FollowingUpdateAllPropertiesNotifyEnum notify,bool withReplies)
		{
			var param = new Dictionary<string, object?>
			{
				{ "notify", notify },
				{ "withReplies", withReplies },
			};
			var result = await _app.Request<EmptyResponse>(
				"following/update-all", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public enum FollowingUpdateAllPropertiesNotifyEnum {
			[EnumMember(Value = "normal")]
			Normal,
			[EnumMember(Value = "none")]
			None,
		}
		public async Task<Response<UserLiteModel>> Invalidate(string userId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
			};
			var result = await _app.Request<UserLiteModel>(
				"following/invalidate", 
				param, 
				needToken: true
			);
			return result;
		}

		public readonly Following.RequestsApi RequestsApi;
		public FollowingApi(App app)
		{
			this._app = app;
			this.RequestsApi = new Following.RequestsApi(this._app);
		}
	}
}
namespace Misharp.Controls.Following
{
	public class RequestsApi
	{
		private readonly App _app;
		public RequestsApi(App app)
		{
			this._app = app;
		}
		public async Task<Response<EmptyResponse>> Accept(string userId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
			};
			var result = await _app.Request<EmptyResponse>(
				"following/requests/accept", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<UserLiteModel>> Cancel(string userId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
			};
			var result = await _app.Request<UserLiteModel>(
				"following/requests/cancel", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<FollowingListItemsModel>>> List(string? sinceId = null,string? untilId = null,int limit = 10)
		{
			var param = new Dictionary<string, object?>
			{
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<FollowingListItemsModel>>(
				"following/requests/list", 
				param, 
				needToken: true
			);
			return result;
		}

		public interface IFollowingListItemsModel
		{
			public string Id { get; set; }
			public UserLiteModel Follower { get; set; }
			public UserLiteModel Followee { get; set; }
		}
		public class FollowingListItemsModel: IFollowingListItemsModel
		{
			public string Id { get; set; }
			public UserLiteModel Follower { get; set; }
			public UserLiteModel Followee { get; set; }
		}
		public async Task<Response<List<FollowingSentItemsModel>>> Sent(string? sinceId = null,string? untilId = null,int limit = 10)
		{
			var param = new Dictionary<string, object?>
			{
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<FollowingSentItemsModel>>(
				"following/requests/sent", 
				param, 
				needToken: true
			);
			return result;
		}

		public interface IFollowingSentItemsModel
		{
			public string Id { get; set; }
			public UserLiteModel Follower { get; set; }
			public UserLiteModel Followee { get; set; }
		}
		public class FollowingSentItemsModel: IFollowingSentItemsModel
		{
			public string Id { get; set; }
			public UserLiteModel Follower { get; set; }
			public UserLiteModel Followee { get; set; }
		}
		public async Task<Response<EmptyResponse>> Reject(string userId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
			};
			var result = await _app.Request<EmptyResponse>(
				"following/requests/reject", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

	}
}
