using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;

namespace Misharp.Controls;

public class FederationApi
{
    private readonly App _app;

    public async Task<Response<List<FollowingModel>>> Followers(string host, string? sinceId = null,
        string? untilId = null, int limit = 10)
    {
        var param = new Dictionary<string, object?>
        {
            { "host", host },
            { "sinceId", sinceId },
            { "untilId", untilId },
            { "limit", limit }
        };
        var result = await _app.Request<List<FollowingModel>>(
            "federation/followers",
            param,
            false
        );
        return result;
    }

    public async Task<Response<List<FollowingModel>>> Following(string host, string? sinceId = null,
        string? untilId = null, int limit = 10)
    {
        var param = new Dictionary<string, object?>
        {
            { "host", host },
            { "sinceId", sinceId },
            { "untilId", untilId },
            { "limit", limit }
        };
        var result = await _app.Request<List<FollowingModel>>(
            "federation/following",
            param,
            false
        );
        return result;
    }

    public async Task<Response<List<FederationInstanceModel>>> InstancesGet(string? host = null, bool? blocked = null,
        bool? notResponding = null, bool? suspended = null, bool? silenced = null, bool? federating = null,
        bool? subscribing = null, bool? publishing = null, int limit = 30, int offset = 0,
        FederationInstancesPropertiesSortEnum? sort = null)
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
            { "sort", sort }
        };
        var result = await _app.Request<List<FederationInstanceModel>>(
            "federation/instances",
            param,
            false
        );
        return result;
    }

    public async Task<Response<List<FederationInstanceModel>>> Instances(string? host = null, bool? blocked = null,
        bool? notResponding = null, bool? suspended = null, bool? silenced = null, bool? federating = null,
        bool? subscribing = null, bool? publishing = null, int limit = 30, int offset = 0,
        FederationInstancesPropertiesSortEnum? sort = null)
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
            { "sort", sort }
        };
        var result = await _app.Request<List<FederationInstanceModel>>(
            "federation/instances",
            param,
            false
        );
        return result;
    }

    public enum FederationInstancesPropertiesSortEnum
    {
        [EnumMember(Value = "+pubSub")] PluspubSub,
        [EnumMember(Value = "-pubSub")] MinuspubSub,
        [EnumMember(Value = "+notes")] Plusnotes,
        [EnumMember(Value = "-notes")] Minusnotes,
        [EnumMember(Value = "+users")] Plususers,
        [EnumMember(Value = "-users")] Minususers,
        [EnumMember(Value = "+following")] Plusfollowing,
        [EnumMember(Value = "-following")] Minusfollowing,
        [EnumMember(Value = "+followers")] Plusfollowers,
        [EnumMember(Value = "-followers")] Minusfollowers,

        [EnumMember(Value = "+firstRetrievedAt")]
        PlusfirstRetrievedAt,

        [EnumMember(Value = "-firstRetrievedAt")]
        MinusfirstRetrievedAt,

        [EnumMember(Value = "+latestRequestReceivedAt")]
        PluslatestRequestReceivedAt,

        [EnumMember(Value = "-latestRequestReceivedAt")]
        MinuslatestRequestReceivedAt
    }

    public async Task<Response<FederationInstanceModel>> ShowInstance(string host)
    {
        var param = new Dictionary<string, object?>
        {
            { "host", host }
        };
        var result = await _app.Request<FederationInstanceModel>(
            "federation/show-instance",
            param,
            false
        );
        return result;
    }

    public async Task<Response<GetStatsGetModel>> StatsGet(int limit = 10)
    {
        var param = new Dictionary<string, object?>
        {
            { "limit", limit }
        };
        var result = await _app.Request<GetStatsGetModel>(
            "federation/stats",
            param,
            false
        );
        return result;
    }

    public interface IGetStatsGetModel
    {
        public List<FederationInstanceModel> TopSubInstances { get; set; }
        public decimal OtherFollowersCount { get; set; }
        public List<FederationInstanceModel> TopPubInstances { get; set; }
        public decimal OtherFollowingCount { get; set; }
    }

    public class GetStatsGetModel : IGetStatsGetModel
    {
        public List<FederationInstanceModel> TopSubInstances { get; set; }
        public decimal OtherFollowersCount { get; set; }
        public List<FederationInstanceModel> TopPubInstances { get; set; }
        public decimal OtherFollowingCount { get; set; }
    }

    public async Task<Response<PostStatsModel>> Stats(int limit = 10)
    {
        var param = new Dictionary<string, object?>
        {
            { "limit", limit }
        };
        var result = await _app.Request<PostStatsModel>(
            "federation/stats",
            param,
            false
        );
        return result;
    }

    public interface IPostStatsModel
    {
        public List<FederationInstanceModel> TopSubInstances { get; set; }
        public decimal OtherFollowersCount { get; set; }
        public List<FederationInstanceModel> TopPubInstances { get; set; }
        public decimal OtherFollowingCount { get; set; }
    }

    public class PostStatsModel : IPostStatsModel
    {
        public List<FederationInstanceModel> TopSubInstances { get; set; }
        public decimal OtherFollowersCount { get; set; }
        public List<FederationInstanceModel> TopPubInstances { get; set; }
        public decimal OtherFollowingCount { get; set; }
    }

    public async Task<Response<EmptyResponse>> UpdateRemoteUser(string userId)
    {
        var param = new Dictionary<string, object?>
        {
            { "userId", userId }
        };
        var result = await _app.Request<EmptyResponse>(
            "federation/update-remote-user",
            param,
            successStatusCode: System.Net.HttpStatusCode.NoContent,
            needToken: false
        );
        return result;
    }

    public async Task<Response<List<UserDetailedNotMeModel>>> Users(string host, string? sinceId = null,
        string? untilId = null, int limit = 10)
    {
        var param = new Dictionary<string, object?>
        {
            { "host", host },
            { "sinceId", sinceId },
            { "untilId", untilId },
            { "limit", limit }
        };
        var result = await _app.Request<List<UserDetailedNotMeModel>>(
            "federation/users",
            param,
            false
        );
        return result;
    }

    public FederationApi(App app)
    {
        _app = app;
    }
}