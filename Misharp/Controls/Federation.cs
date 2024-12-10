using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class FederationApi
	{
		private readonly App _app;
		public async Task<Response<List<FollowingModel>>> Followers(string host,string? sinceId = null,string? untilId = null,int limit = 10)
		{
			var param = new Dictionary<string, object?>
			{
				{ "host", host },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<FollowingModel>>(
				"federation/followers", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<FollowingModel>>> Following(string host,string? sinceId = null,string? untilId = null,int limit = 10)
		{
			var param = new Dictionary<string, object?>
			{
				{ "host", host },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<FollowingModel>>(
				"federation/following", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<FederationInstanceModel>>> InstancesGet(string? host = null,bool? blocked = null,bool? notResponding = null,bool? suspended = null,bool? silenced = null,bool? federating = null,bool? subscribing = null,bool? publishing = null,int limit = 30,int offset = 0,FederationInstancesPropertiesSortEnum? sort = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "host", host },
				{ "blocked", blocked },
				{ "notResponding", notResponding },
				{ "suspended", suspended },
				{ "silenced", silenced },
				{ "federating", federating },
				{ "subscribing", subscribing },
				{ "publishing", publishing },
				{ "limit", limit },
				{ "offset", offset },
				{ "sort", sort },
			};
			var result = await _app.Request<List<FederationInstanceModel>>(
				"federation/instances", 
				param, 
				needToken: false
			);
			return result;
		}

		public enum FederationInstancesPropertiesSortEnum {
			[EnumMember(Value = "+pubSub")]
			PluspubSub,
			[EnumMember(Value = "-pubSub")]
			MinuspubSub,
			[EnumMember(Value = "+notes")]
			Plusnotes,
			[EnumMember(Value = "-notes")]
			Minusnotes,
			[EnumMember(Value = "+users")]
			Plususers,
			[EnumMember(Value = "-users")]
			Minususers,
			[EnumMember(Value = "+following")]
			Plusfollowing,
			[EnumMember(Value = "-following")]
			Minusfollowing,
			[EnumMember(Value = "+followers")]
			Plusfollowers,
			[EnumMember(Value = "-followers")]
			Minusfollowers,
			[EnumMember(Value = "+firstRetrievedAt")]
			PlusfirstRetrievedAt,
			[EnumMember(Value = "-firstRetrievedAt")]
			MinusfirstRetrievedAt,
			[EnumMember(Value = "+latestRequestReceivedAt")]
			PluslatestRequestReceivedAt,
			[EnumMember(Value = "-latestRequestReceivedAt")]
			MinuslatestRequestReceivedAt,
		}
		public async Task<Response<List<FederationInstanceModel>>> Instances(string? host = null,bool? blocked = null,bool? notResponding = null,bool? suspended = null,bool? silenced = null,bool? federating = null,bool? subscribing = null,bool? publishing = null,int limit = 30,int offset = 0,FederationInstancesPropertiesSortEnum? sort = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "host", host },
				{ "blocked", blocked },
				{ "notResponding", notResponding },
				{ "suspended", suspended },
				{ "silenced", silenced },
				{ "federating", federating },
				{ "subscribing", subscribing },
				{ "publishing", publishing },
				{ "limit", limit },
				{ "offset", offset },
				{ "sort", sort },
			};
			var result = await _app.Request<List<FederationInstanceModel>>(
				"federation/instances", 
				param, 
				needToken: false
			);
			return result;
		}
		public async Task<Response<FederationInstanceModel>> ShowInstance(string host)
		{
			var param = new Dictionary<string, object?>
			{
				{ "host", host },
			};
			var result = await _app.Request<FederationInstanceModel>(
				"federation/show-instance", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> UpdateRemoteUser(string userId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
			};
			var result = await _app.Request<EmptyResponse>(
				"federation/update-remote-user", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<UserDetailedNotMeModel>>> Users(string host,string? sinceId = null,string? untilId = null,int limit = 10)
		{
			var param = new Dictionary<string, object?>
			{
				{ "host", host },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<UserDetailedNotMeModel>>(
				"federation/users", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<FederationStatsGetModel>> StatsGet(int limit = 10)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
			};
			var result = await _app.Request<FederationStatsGetModel>(
				"federation/stats", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IFederationStatsGetModel
		{
			public List<FederationInstanceModel> TopSubInstances { get; set; }
			public decimal OtherFollowersCount { get; set; }
			public List<FederationInstanceModel> TopPubInstances { get; set; }
			public decimal OtherFollowingCount { get; set; }
		}
		public class FederationStatsGetModel: IFederationStatsGetModel
		{
			public List<FederationInstanceModel> TopSubInstances { get; set; }
			public decimal OtherFollowersCount { get; set; }
			public List<FederationInstanceModel> TopPubInstances { get; set; }
			public decimal OtherFollowingCount { get; set; }
		}
		public async Task<Response<FederationStatsModel>> Stats(int limit = 10)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
			};
			var result = await _app.Request<FederationStatsModel>(
				"federation/stats", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IFederationStatsModel
		{
			public List<FederationInstanceModel> TopSubInstances { get; set; }
			public decimal OtherFollowersCount { get; set; }
			public List<FederationInstanceModel> TopPubInstances { get; set; }
			public decimal OtherFollowingCount { get; set; }
		}
		public class FederationStatsModel: IFederationStatsModel
		{
			public List<FederationInstanceModel> TopSubInstances { get; set; }
			public decimal OtherFollowersCount { get; set; }
			public List<FederationInstanceModel> TopPubInstances { get; set; }
			public decimal OtherFollowingCount { get; set; }
		}
		public FederationApi(App app)
		{
			this._app = app;
		}
	}
}
