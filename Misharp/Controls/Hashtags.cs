using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class HashtagsApi
	{
		private readonly App _app;
		public async Task<Response<List<HashtagModel>>> List(HashtagsListPropertiesSortEnum sort,int limit = 10,bool attachedToUserOnly = false,bool attachedToLocalUserOnly = false,bool attachedToRemoteUserOnly = false)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "attachedToUserOnly", attachedToUserOnly },
				{ "attachedToLocalUserOnly", attachedToLocalUserOnly },
				{ "attachedToRemoteUserOnly", attachedToRemoteUserOnly },
				{ "sort", sort },
			};
			var result = await _app.Request<List<HashtagModel>>(
				"hashtags/list", 
				param, 
				needToken: false
			);
			return result;
		}

		public enum HashtagsListPropertiesSortEnum {
			[EnumMember(Value = "+mentionedUsers")]
			PlusmentionedUsers,
			[EnumMember(Value = "-mentionedUsers")]
			MinusmentionedUsers,
			[EnumMember(Value = "+mentionedLocalUsers")]
			PlusmentionedLocalUsers,
			[EnumMember(Value = "-mentionedLocalUsers")]
			MinusmentionedLocalUsers,
			[EnumMember(Value = "+mentionedRemoteUsers")]
			PlusmentionedRemoteUsers,
			[EnumMember(Value = "-mentionedRemoteUsers")]
			MinusmentionedRemoteUsers,
			[EnumMember(Value = "+attachedUsers")]
			PlusattachedUsers,
			[EnumMember(Value = "-attachedUsers")]
			MinusattachedUsers,
			[EnumMember(Value = "+attachedLocalUsers")]
			PlusattachedLocalUsers,
			[EnumMember(Value = "-attachedLocalUsers")]
			MinusattachedLocalUsers,
			[EnumMember(Value = "+attachedRemoteUsers")]
			PlusattachedRemoteUsers,
			[EnumMember(Value = "-attachedRemoteUsers")]
			MinusattachedRemoteUsers,
		}
		public async Task<Response<List<string>>> Search(string query,int limit = 10,int offset = 0)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "query", query },
				{ "offset", offset },
			};
			var result = await _app.Request<List<string>>(
				"hashtags/search", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<HashtagModel>> Show(string tag)
		{
			var param = new Dictionary<string, object?>
			{
				{ "tag", tag },
			};
			var result = await _app.Request<HashtagModel>(
				"hashtags/show", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<GetTrendGetItemsModel>>> TrendGet()
		{
			var result = await _app.Request<List<GetTrendGetItemsModel>>(
				"hashtags/trend", 
				needToken: false
			);
			return result;
		}

		public interface IGetTrendGetItemsModel
		{
			public string Tag { get; set; }
			public List<decimal> Chart { get; set; }
			public decimal UsersCount { get; set; }
		}
		public class GetTrendGetItemsModel: IGetTrendGetItemsModel
		{
			public string Tag { get; set; }
			public List<decimal> Chart { get; set; }
			public decimal UsersCount { get; set; }
		}
		public async Task<Response<List<PostTrendItemsModel>>> Trend()
		{
			var result = await _app.Request<List<PostTrendItemsModel>>(
				"hashtags/trend", 
				needToken: false
			);
			return result;
		}

		public interface IPostTrendItemsModel
		{
			public string Tag { get; set; }
			public List<decimal> Chart { get; set; }
			public decimal UsersCount { get; set; }
		}
		public class PostTrendItemsModel: IPostTrendItemsModel
		{
			public string Tag { get; set; }
			public List<decimal> Chart { get; set; }
			public decimal UsersCount { get; set; }
		}
		public async Task<Response<List<UserDetailedModel>>> Users(string tag,HashtagsUsersPropertiesSortEnum sort,int limit = 10,HashtagsUsersPropertiesStateEnum state = HashtagsUsersPropertiesStateEnum.All,HashtagsUsersPropertiesOriginEnum origin = HashtagsUsersPropertiesOriginEnum.Local)
		{
			var param = new Dictionary<string, object?>
			{
				{ "tag", tag },
				{ "limit", limit },
				{ "sort", sort },
				{ "state", state },
				{ "origin", origin },
			};
			var result = await _app.Request<List<UserDetailedModel>>(
				"hashtags/users", 
				param, 
				needToken: false
			);
			return result;
		}

		public enum HashtagsUsersPropertiesSortEnum {
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
		public enum HashtagsUsersPropertiesStateEnum {
			[EnumMember(Value = "all")]
			All,
			[EnumMember(Value = "alive")]
			Alive,
		}
		public enum HashtagsUsersPropertiesOriginEnum {
			[EnumMember(Value = "combined")]
			Combined,
			[EnumMember(Value = "local")]
			Local,
			[EnumMember(Value = "remote")]
			Remote,
		}
		public HashtagsApi(App app)
		{
			this._app = app;
		}
	}
}
