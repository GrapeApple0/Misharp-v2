using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;

namespace Misharp.Controls
{
    public class ChartsApi
    {
        private readonly App _app;

        public async Task<Response<GetActiveUsersGetModel>> ActiveUsersGet(ChartsActiveUsersPropertiesSpanEnum span,
            int limit = 30, int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset }
            };
            var result = await _app.Request<GetActiveUsersGetModel>(
                "charts/active-users",
                param,
                false
            );
            return result;
        }

        public interface IGetActiveUsersGetModel
        {
            public List<decimal> ReadWrite { get; set; }
            public List<decimal> Read { get; set; }
            public List<decimal> Write { get; set; }
            public List<decimal> RegisteredWithinWeek { get; set; }
            public List<decimal> RegisteredWithinMonth { get; set; }
            public List<decimal> RegisteredWithinYear { get; set; }
            public List<decimal> RegisteredOutsideWeek { get; set; }
            public List<decimal> RegisteredOutsideMonth { get; set; }
            public List<decimal> RegisteredOutsideYear { get; set; }
        }

        public class GetActiveUsersGetModel : IGetActiveUsersGetModel
        {
            public List<decimal> ReadWrite { get; set; }
            public List<decimal> Read { get; set; }
            public List<decimal> Write { get; set; }
            public List<decimal> RegisteredWithinWeek { get; set; }
            public List<decimal> RegisteredWithinMonth { get; set; }
            public List<decimal> RegisteredWithinYear { get; set; }
            public List<decimal> RegisteredOutsideWeek { get; set; }
            public List<decimal> RegisteredOutsideMonth { get; set; }
            public List<decimal> RegisteredOutsideYear { get; set; }
        }

        public async Task<Response<PostActiveUsersModel>> ActiveUsers(ChartsActiveUsersPropertiesSpanEnum span,
            int limit = 30, int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset }
            };
            var result = await _app.Request<PostActiveUsersModel>(
                "charts/active-users",
                param,
                false
            );
            return result;
        }

        public enum ChartsActiveUsersPropertiesSpanEnum
        {
            [EnumMember(Value = "day")] Day,
            [EnumMember(Value = "hour")] Hour
        }

        public interface IPostActiveUsersModel
        {
            public List<decimal> ReadWrite { get; set; }
            public List<decimal> Read { get; set; }
            public List<decimal> Write { get; set; }
            public List<decimal> RegisteredWithinWeek { get; set; }
            public List<decimal> RegisteredWithinMonth { get; set; }
            public List<decimal> RegisteredWithinYear { get; set; }
            public List<decimal> RegisteredOutsideWeek { get; set; }
            public List<decimal> RegisteredOutsideMonth { get; set; }
            public List<decimal> RegisteredOutsideYear { get; set; }
        }

        public class PostActiveUsersModel : IPostActiveUsersModel
        {
            public List<decimal> ReadWrite { get; set; }
            public List<decimal> Read { get; set; }
            public List<decimal> Write { get; set; }
            public List<decimal> RegisteredWithinWeek { get; set; }
            public List<decimal> RegisteredWithinMonth { get; set; }
            public List<decimal> RegisteredWithinYear { get; set; }
            public List<decimal> RegisteredOutsideWeek { get; set; }
            public List<decimal> RegisteredOutsideMonth { get; set; }
            public List<decimal> RegisteredOutsideYear { get; set; }
        }

        public async Task<Response<GetApRequestGetModel>> ApRequestGet(ChartsApRequestPropertiesSpanEnum span,
            int limit = 30, int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset }
            };
            var result = await _app.Request<GetApRequestGetModel>(
                "charts/ap-request",
                param,
                false
            );
            return result;
        }

        public interface IGetApRequestGetModel
        {
            public List<decimal> DeliverFailed { get; set; }
            public List<decimal> DeliverSucceeded { get; set; }
            public List<decimal> InboxReceived { get; set; }
        }

        public class GetApRequestGetModel : IGetApRequestGetModel
        {
            public List<decimal> DeliverFailed { get; set; }
            public List<decimal> DeliverSucceeded { get; set; }
            public List<decimal> InboxReceived { get; set; }
        }

        public async Task<Response<PostApRequestModel>> ApRequest(ChartsApRequestPropertiesSpanEnum span,
            int limit = 30, int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset }
            };
            var result = await _app.Request<PostApRequestModel>(
                "charts/ap-request",
                param,
                false
            );
            return result;
        }

        public enum ChartsApRequestPropertiesSpanEnum
        {
            [EnumMember(Value = "day")] Day,
            [EnumMember(Value = "hour")] Hour
        }

        public interface IPostApRequestModel
        {
            public List<decimal> DeliverFailed { get; set; }
            public List<decimal> DeliverSucceeded { get; set; }
            public List<decimal> InboxReceived { get; set; }
        }

        public class PostApRequestModel : IPostApRequestModel
        {
            public List<decimal> DeliverFailed { get; set; }
            public List<decimal> DeliverSucceeded { get; set; }
            public List<decimal> InboxReceived { get; set; }
        }

        public async Task<Response<GetDriveGetModel>> DriveGet(ChartsDrivePropertiesSpanEnum span, int limit = 30,
            int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset }
            };
            var result = await _app.Request<GetDriveGetModel>(
                "charts/drive",
                param,
                false
            );
            return result;
        }

        public interface IGetDriveGetLocalModel
        {
            public List<decimal> IncCount { get; set; }
            public List<decimal> IncSize { get; set; }
            public List<decimal> DecCount { get; set; }
            public List<decimal> DecSize { get; set; }
        }

        public class GetDriveGetLocalModel : IGetDriveGetLocalModel
        {
            public List<decimal> IncCount { get; set; }
            public List<decimal> IncSize { get; set; }
            public List<decimal> DecCount { get; set; }
            public List<decimal> DecSize { get; set; }
        }

        public interface IGetDriveGetRemoteModel
        {
            public List<decimal> IncCount { get; set; }
            public List<decimal> IncSize { get; set; }
            public List<decimal> DecCount { get; set; }
            public List<decimal> DecSize { get; set; }
        }

        public class GetDriveGetRemoteModel : IGetDriveGetRemoteModel
        {
            public List<decimal> IncCount { get; set; }
            public List<decimal> IncSize { get; set; }
            public List<decimal> DecCount { get; set; }
            public List<decimal> DecSize { get; set; }
        }

        public interface IGetDriveGetModel
        {
            public GetDriveGetLocalModel Local { get; set; }
            public GetDriveGetRemoteModel Remote { get; set; }
        }

        public class GetDriveGetModel : IGetDriveGetModel
        {
            public GetDriveGetLocalModel Local { get; set; }
            public GetDriveGetRemoteModel Remote { get; set; }
        }

        public async Task<Response<PostDriveModel>> Drive(ChartsDrivePropertiesSpanEnum span, int limit = 30,
            int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset }
            };
            var result = await _app.Request<PostDriveModel>(
                "charts/drive",
                param,
                false
            );
            return result;
        }

        public enum ChartsDrivePropertiesSpanEnum
        {
            [EnumMember(Value = "day")] Day,
            [EnumMember(Value = "hour")] Hour
        }

        public interface IPostDriveLocalModel
        {
            public List<decimal> IncCount { get; set; }
            public List<decimal> IncSize { get; set; }
            public List<decimal> DecCount { get; set; }
            public List<decimal> DecSize { get; set; }
        }

        public class PostDriveLocalModel : IPostDriveLocalModel
        {
            public List<decimal> IncCount { get; set; }
            public List<decimal> IncSize { get; set; }
            public List<decimal> DecCount { get; set; }
            public List<decimal> DecSize { get; set; }
        }

        public interface IPostDriveRemoteModel
        {
            public List<decimal> IncCount { get; set; }
            public List<decimal> IncSize { get; set; }
            public List<decimal> DecCount { get; set; }
            public List<decimal> DecSize { get; set; }
        }

        public class PostDriveRemoteModel : IPostDriveRemoteModel
        {
            public List<decimal> IncCount { get; set; }
            public List<decimal> IncSize { get; set; }
            public List<decimal> DecCount { get; set; }
            public List<decimal> DecSize { get; set; }
        }

        public interface IPostDriveModel
        {
            public PostDriveLocalModel Local { get; set; }
            public PostDriveRemoteModel Remote { get; set; }
        }

        public class PostDriveModel : IPostDriveModel
        {
            public PostDriveLocalModel Local { get; set; }
            public PostDriveRemoteModel Remote { get; set; }
        }

        public async Task<Response<GetFederationGetModel>> FederationGet(ChartsFederationPropertiesSpanEnum span,
            int limit = 30, int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset }
            };
            var result = await _app.Request<GetFederationGetModel>(
                "charts/federation",
                param,
                false
            );
            return result;
        }

        public interface IGetFederationGetModel
        {
            public List<decimal> DeliveredInstances { get; set; }
            public List<decimal> InboxInstances { get; set; }
            public List<decimal> Stalled { get; set; }
            public List<decimal> Sub { get; set; }
            public List<decimal> Pub { get; set; }
            public List<decimal> Pubsub { get; set; }
            public List<decimal> SubActive { get; set; }
            public List<decimal> PubActive { get; set; }
        }

        public class GetFederationGetModel : IGetFederationGetModel
        {
            public List<decimal> DeliveredInstances { get; set; }
            public List<decimal> InboxInstances { get; set; }
            public List<decimal> Stalled { get; set; }
            public List<decimal> Sub { get; set; }
            public List<decimal> Pub { get; set; }
            public List<decimal> Pubsub { get; set; }
            public List<decimal> SubActive { get; set; }
            public List<decimal> PubActive { get; set; }
        }

        public async Task<Response<PostFederationModel>> Federation(ChartsFederationPropertiesSpanEnum span,
            int limit = 30, int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset }
            };
            var result = await _app.Request<PostFederationModel>(
                "charts/federation",
                param,
                false
            );
            return result;
        }

        public enum ChartsFederationPropertiesSpanEnum
        {
            [EnumMember(Value = "day")] Day,
            [EnumMember(Value = "hour")] Hour
        }

        public interface IPostFederationModel
        {
            public List<decimal> DeliveredInstances { get; set; }
            public List<decimal> InboxInstances { get; set; }
            public List<decimal> Stalled { get; set; }
            public List<decimal> Sub { get; set; }
            public List<decimal> Pub { get; set; }
            public List<decimal> Pubsub { get; set; }
            public List<decimal> SubActive { get; set; }
            public List<decimal> PubActive { get; set; }
        }

        public class PostFederationModel : IPostFederationModel
        {
            public List<decimal> DeliveredInstances { get; set; }
            public List<decimal> InboxInstances { get; set; }
            public List<decimal> Stalled { get; set; }
            public List<decimal> Sub { get; set; }
            public List<decimal> Pub { get; set; }
            public List<decimal> Pubsub { get; set; }
            public List<decimal> SubActive { get; set; }
            public List<decimal> PubActive { get; set; }
        }

        public async Task<Response<GetInstanceGetModel>> InstanceGet(ChartsInstancePropertiesSpanEnum span, string host,
            int limit = 30, int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset },
                { "host", host }
            };
            var result = await _app.Request<GetInstanceGetModel>(
                "charts/instance",
                param,
                false
            );
            return result;
        }

        public interface IGetInstanceGetRequestsModel
        {
            public List<decimal> Failed { get; set; }
            public List<decimal> Succeeded { get; set; }
            public List<decimal> Received { get; set; }
        }

        public class GetInstanceGetRequestsModel : IGetInstanceGetRequestsModel
        {
            public List<decimal> Failed { get; set; }
            public List<decimal> Succeeded { get; set; }
            public List<decimal> Received { get; set; }
        }

        public interface IGetInstanceGetNotesDiffsModel
        {
            public List<decimal> Normal { get; set; }
            public List<decimal> Reply { get; set; }
            public List<decimal> Renote { get; set; }
            public List<decimal> WithFile { get; set; }
        }

        public class GetInstanceGetNotesDiffsModel : IGetInstanceGetNotesDiffsModel
        {
            public List<decimal> Normal { get; set; }
            public List<decimal> Reply { get; set; }
            public List<decimal> Renote { get; set; }
            public List<decimal> WithFile { get; set; }
        }

        public interface IGetInstanceGetNotesModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
            public GetInstanceGetNotesDiffsModel Diffs { get; set; }
        }

        public class GetInstanceGetNotesModel : IGetInstanceGetNotesModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
            public GetInstanceGetNotesDiffsModel Diffs { get; set; }
        }

        public interface IGetInstanceGetUsersModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public class GetInstanceGetUsersModel : IGetInstanceGetUsersModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public interface IGetInstanceGetFollowingModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public class GetInstanceGetFollowingModel : IGetInstanceGetFollowingModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public interface IGetInstanceGetFollowersModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public class GetInstanceGetFollowersModel : IGetInstanceGetFollowersModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public interface IGetInstanceGetDriveModel
        {
            public List<decimal> TotalFiles { get; set; }
            public List<decimal> IncFiles { get; set; }
            public List<decimal> DecFiles { get; set; }
            public List<decimal> IncUsage { get; set; }
            public List<decimal> DecUsage { get; set; }
        }

        public class GetInstanceGetDriveModel : IGetInstanceGetDriveModel
        {
            public List<decimal> TotalFiles { get; set; }
            public List<decimal> IncFiles { get; set; }
            public List<decimal> DecFiles { get; set; }
            public List<decimal> IncUsage { get; set; }
            public List<decimal> DecUsage { get; set; }
        }

        public interface IGetInstanceGetModel
        {
            public GetInstanceGetRequestsModel Requests { get; set; }
            public GetInstanceGetNotesModel Notes { get; set; }
            public GetInstanceGetUsersModel Users { get; set; }
            public GetInstanceGetFollowingModel Following { get; set; }
            public GetInstanceGetFollowersModel Followers { get; set; }
            public GetInstanceGetDriveModel Drive { get; set; }
        }

        public class GetInstanceGetModel : IGetInstanceGetModel
        {
            public GetInstanceGetRequestsModel Requests { get; set; }
            public GetInstanceGetNotesModel Notes { get; set; }
            public GetInstanceGetUsersModel Users { get; set; }
            public GetInstanceGetFollowingModel Following { get; set; }
            public GetInstanceGetFollowersModel Followers { get; set; }
            public GetInstanceGetDriveModel Drive { get; set; }
        }

        public async Task<Response<PostInstanceModel>> Instance(ChartsInstancePropertiesSpanEnum span, string host,
            int limit = 30, int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset },
                { "host", host }
            };
            var result = await _app.Request<PostInstanceModel>(
                "charts/instance",
                param,
                false
            );
            return result;
        }

        public enum ChartsInstancePropertiesSpanEnum
        {
            [EnumMember(Value = "day")] Day,
            [EnumMember(Value = "hour")] Hour
        }

        public interface IPostInstanceRequestsModel
        {
            public List<decimal> Failed { get; set; }
            public List<decimal> Succeeded { get; set; }
            public List<decimal> Received { get; set; }
        }

        public class PostInstanceRequestsModel : IPostInstanceRequestsModel
        {
            public List<decimal> Failed { get; set; }
            public List<decimal> Succeeded { get; set; }
            public List<decimal> Received { get; set; }
        }

        public interface IPostInstanceNotesDiffsModel
        {
            public List<decimal> Normal { get; set; }
            public List<decimal> Reply { get; set; }
            public List<decimal> Renote { get; set; }
            public List<decimal> WithFile { get; set; }
        }

        public class PostInstanceNotesDiffsModel : IPostInstanceNotesDiffsModel
        {
            public List<decimal> Normal { get; set; }
            public List<decimal> Reply { get; set; }
            public List<decimal> Renote { get; set; }
            public List<decimal> WithFile { get; set; }
        }

        public interface IPostInstanceNotesModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
            public PostInstanceNotesDiffsModel Diffs { get; set; }
        }

        public class PostInstanceNotesModel : IPostInstanceNotesModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
            public PostInstanceNotesDiffsModel Diffs { get; set; }
        }

        public interface IPostInstanceUsersModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public class PostInstanceUsersModel : IPostInstanceUsersModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public interface IPostInstanceFollowingModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public class PostInstanceFollowingModel : IPostInstanceFollowingModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public interface IPostInstanceFollowersModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public class PostInstanceFollowersModel : IPostInstanceFollowersModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public interface IPostInstanceDriveModel
        {
            public List<decimal> TotalFiles { get; set; }
            public List<decimal> IncFiles { get; set; }
            public List<decimal> DecFiles { get; set; }
            public List<decimal> IncUsage { get; set; }
            public List<decimal> DecUsage { get; set; }
        }

        public class PostInstanceDriveModel : IPostInstanceDriveModel
        {
            public List<decimal> TotalFiles { get; set; }
            public List<decimal> IncFiles { get; set; }
            public List<decimal> DecFiles { get; set; }
            public List<decimal> IncUsage { get; set; }
            public List<decimal> DecUsage { get; set; }
        }

        public interface IPostInstanceModel
        {
            public PostInstanceRequestsModel Requests { get; set; }
            public PostInstanceNotesModel Notes { get; set; }
            public PostInstanceUsersModel Users { get; set; }
            public PostInstanceFollowingModel Following { get; set; }
            public PostInstanceFollowersModel Followers { get; set; }
            public PostInstanceDriveModel Drive { get; set; }
        }

        public class PostInstanceModel : IPostInstanceModel
        {
            public PostInstanceRequestsModel Requests { get; set; }
            public PostInstanceNotesModel Notes { get; set; }
            public PostInstanceUsersModel Users { get; set; }
            public PostInstanceFollowingModel Following { get; set; }
            public PostInstanceFollowersModel Followers { get; set; }
            public PostInstanceDriveModel Drive { get; set; }
        }

        public async Task<Response<GetNotesGetModel>> NotesGet(ChartsNotesPropertiesSpanEnum span, int limit = 30,
            int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset }
            };
            var result = await _app.Request<GetNotesGetModel>(
                "charts/notes",
                param,
                false
            );
            return result;
        }

        public interface IGetNotesGetLocalDiffsModel
        {
            public List<decimal> Normal { get; set; }
            public List<decimal> Reply { get; set; }
            public List<decimal> Renote { get; set; }
            public List<decimal> WithFile { get; set; }
        }

        public class GetNotesGetLocalDiffsModel : IGetNotesGetLocalDiffsModel
        {
            public List<decimal> Normal { get; set; }
            public List<decimal> Reply { get; set; }
            public List<decimal> Renote { get; set; }
            public List<decimal> WithFile { get; set; }
        }

        public interface IGetNotesGetLocalModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
            public GetNotesGetLocalDiffsModel Diffs { get; set; }
        }

        public class GetNotesGetLocalModel : IGetNotesGetLocalModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
            public GetNotesGetLocalDiffsModel Diffs { get; set; }
        }

        public interface IGetNotesGetRemoteDiffsModel
        {
            public List<decimal> Normal { get; set; }
            public List<decimal> Reply { get; set; }
            public List<decimal> Renote { get; set; }
            public List<decimal> WithFile { get; set; }
        }

        public class GetNotesGetRemoteDiffsModel : IGetNotesGetRemoteDiffsModel
        {
            public List<decimal> Normal { get; set; }
            public List<decimal> Reply { get; set; }
            public List<decimal> Renote { get; set; }
            public List<decimal> WithFile { get; set; }
        }

        public interface IGetNotesGetRemoteModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
            public GetNotesGetRemoteDiffsModel Diffs { get; set; }
        }

        public class GetNotesGetRemoteModel : IGetNotesGetRemoteModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
            public GetNotesGetRemoteDiffsModel Diffs { get; set; }
        }

        public interface IGetNotesGetModel
        {
            public GetNotesGetLocalModel Local { get; set; }
            public GetNotesGetRemoteModel Remote { get; set; }
        }

        public class GetNotesGetModel : IGetNotesGetModel
        {
            public GetNotesGetLocalModel Local { get; set; }
            public GetNotesGetRemoteModel Remote { get; set; }
        }

        public async Task<Response<PostNotesModel>> Notes(ChartsNotesPropertiesSpanEnum span, int limit = 30,
            int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset }
            };
            var result = await _app.Request<PostNotesModel>(
                "charts/notes",
                param,
                false
            );
            return result;
        }

        public enum ChartsNotesPropertiesSpanEnum
        {
            [EnumMember(Value = "day")] Day,
            [EnumMember(Value = "hour")] Hour
        }

        public interface IPostNotesLocalDiffsModel
        {
            public List<decimal> Normal { get; set; }
            public List<decimal> Reply { get; set; }
            public List<decimal> Renote { get; set; }
            public List<decimal> WithFile { get; set; }
        }

        public class PostNotesLocalDiffsModel : IPostNotesLocalDiffsModel
        {
            public List<decimal> Normal { get; set; }
            public List<decimal> Reply { get; set; }
            public List<decimal> Renote { get; set; }
            public List<decimal> WithFile { get; set; }
        }

        public interface IPostNotesLocalModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
            public PostNotesLocalDiffsModel Diffs { get; set; }
        }

        public class PostNotesLocalModel : IPostNotesLocalModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
            public PostNotesLocalDiffsModel Diffs { get; set; }
        }

        public interface IPostNotesRemoteDiffsModel
        {
            public List<decimal> Normal { get; set; }
            public List<decimal> Reply { get; set; }
            public List<decimal> Renote { get; set; }
            public List<decimal> WithFile { get; set; }
        }

        public class PostNotesRemoteDiffsModel : IPostNotesRemoteDiffsModel
        {
            public List<decimal> Normal { get; set; }
            public List<decimal> Reply { get; set; }
            public List<decimal> Renote { get; set; }
            public List<decimal> WithFile { get; set; }
        }

        public interface IPostNotesRemoteModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
            public PostNotesRemoteDiffsModel Diffs { get; set; }
        }

        public class PostNotesRemoteModel : IPostNotesRemoteModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
            public PostNotesRemoteDiffsModel Diffs { get; set; }
        }

        public interface IPostNotesModel
        {
            public PostNotesLocalModel Local { get; set; }
            public PostNotesRemoteModel Remote { get; set; }
        }

        public class PostNotesModel : IPostNotesModel
        {
            public PostNotesLocalModel Local { get; set; }
            public PostNotesRemoteModel Remote { get; set; }
        }

        public async Task<Response<GetUsersGetModel>> UsersGet(ChartsUsersPropertiesSpanEnum span, int limit = 30,
            int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset }
            };
            var result = await _app.Request<GetUsersGetModel>(
                "charts/users",
                param,
                false
            );
            return result;
        }

        public interface IGetUsersGetLocalModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public class GetUsersGetLocalModel : IGetUsersGetLocalModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public interface IGetUsersGetRemoteModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public class GetUsersGetRemoteModel : IGetUsersGetRemoteModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public interface IGetUsersGetModel
        {
            public GetUsersGetLocalModel Local { get; set; }
            public GetUsersGetRemoteModel Remote { get; set; }
        }

        public class GetUsersGetModel : IGetUsersGetModel
        {
            public GetUsersGetLocalModel Local { get; set; }
            public GetUsersGetRemoteModel Remote { get; set; }
        }

        public async Task<Response<PostUsersModel>> Users(ChartsUsersPropertiesSpanEnum span, int limit = 30,
            int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset }
            };
            var result = await _app.Request<PostUsersModel>(
                "charts/users",
                param,
                false
            );
            return result;
        }

        public enum ChartsUsersPropertiesSpanEnum
        {
            [EnumMember(Value = "day")] Day,
            [EnumMember(Value = "hour")] Hour
        }

        public interface IPostUsersLocalModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public class PostUsersLocalModel : IPostUsersLocalModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public interface IPostUsersRemoteModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public class PostUsersRemoteModel : IPostUsersRemoteModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public interface IPostUsersModel
        {
            public PostUsersLocalModel Local { get; set; }
            public PostUsersRemoteModel Remote { get; set; }
        }

        public class PostUsersModel : IPostUsersModel
        {
            public PostUsersLocalModel Local { get; set; }
            public PostUsersRemoteModel Remote { get; set; }
        }

        public readonly Charts.UserApi UserApi;

        public ChartsApi(App app)
        {
            _app = app;
            UserApi = new Charts.UserApi(_app);
        }
    }
}

namespace Misharp.Controls.Charts
{
    public class UserApi
    {
        private readonly App _app;

        public UserApi(App app)
        {
            _app = app;
        }

        public async Task<Response<GetDriveGetModel>> DriveGet(ChartsUserDrivePropertiesSpanEnum span, string userId,
            int limit = 30, int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset },
                { "userId", userId }
            };
            var result = await _app.Request<GetDriveGetModel>(
                "charts/user/drive",
                param,
                false
            );
            return result;
        }

        public interface IGetDriveGetModel
        {
            public List<decimal> TotalCount { get; set; }
            public List<decimal> TotalSize { get; set; }
            public List<decimal> IncCount { get; set; }
            public List<decimal> IncSize { get; set; }
            public List<decimal> DecCount { get; set; }
            public List<decimal> DecSize { get; set; }
        }

        public class GetDriveGetModel : IGetDriveGetModel
        {
            public List<decimal> TotalCount { get; set; }
            public List<decimal> TotalSize { get; set; }
            public List<decimal> IncCount { get; set; }
            public List<decimal> IncSize { get; set; }
            public List<decimal> DecCount { get; set; }
            public List<decimal> DecSize { get; set; }
        }

        public async Task<Response<PostDriveModel>> Drive(ChartsUserDrivePropertiesSpanEnum span, string userId,
            int limit = 30, int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset },
                { "userId", userId }
            };
            var result = await _app.Request<PostDriveModel>(
                "charts/user/drive",
                param,
                false
            );
            return result;
        }

        public enum ChartsUserDrivePropertiesSpanEnum
        {
            [EnumMember(Value = "day")] Day,
            [EnumMember(Value = "hour")] Hour
        }

        public interface IPostDriveModel
        {
            public List<decimal> TotalCount { get; set; }
            public List<decimal> TotalSize { get; set; }
            public List<decimal> IncCount { get; set; }
            public List<decimal> IncSize { get; set; }
            public List<decimal> DecCount { get; set; }
            public List<decimal> DecSize { get; set; }
        }

        public class PostDriveModel : IPostDriveModel
        {
            public List<decimal> TotalCount { get; set; }
            public List<decimal> TotalSize { get; set; }
            public List<decimal> IncCount { get; set; }
            public List<decimal> IncSize { get; set; }
            public List<decimal> DecCount { get; set; }
            public List<decimal> DecSize { get; set; }
        }

        public async Task<Response<GetFollowingGetModel>> FollowingGet(ChartsUserFollowingPropertiesSpanEnum span,
            string userId, int limit = 30, int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset },
                { "userId", userId }
            };
            var result = await _app.Request<GetFollowingGetModel>(
                "charts/user/following",
                param,
                false
            );
            return result;
        }

        public interface IGetFollowingGetLocalFollowingsModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public class GetFollowingGetLocalFollowingsModel : IGetFollowingGetLocalFollowingsModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public interface IGetFollowingGetLocalFollowersModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public class GetFollowingGetLocalFollowersModel : IGetFollowingGetLocalFollowersModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public interface IGetFollowingGetLocalModel
        {
            public GetFollowingGetLocalFollowingsModel Followings { get; set; }
            public GetFollowingGetLocalFollowersModel Followers { get; set; }
        }

        public class GetFollowingGetLocalModel : IGetFollowingGetLocalModel
        {
            public GetFollowingGetLocalFollowingsModel Followings { get; set; }
            public GetFollowingGetLocalFollowersModel Followers { get; set; }
        }

        public interface IGetFollowingGetRemoteFollowingsModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public class GetFollowingGetRemoteFollowingsModel : IGetFollowingGetRemoteFollowingsModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public interface IGetFollowingGetRemoteFollowersModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public class GetFollowingGetRemoteFollowersModel : IGetFollowingGetRemoteFollowersModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public interface IGetFollowingGetRemoteModel
        {
            public GetFollowingGetRemoteFollowingsModel Followings { get; set; }
            public GetFollowingGetRemoteFollowersModel Followers { get; set; }
        }

        public class GetFollowingGetRemoteModel : IGetFollowingGetRemoteModel
        {
            public GetFollowingGetRemoteFollowingsModel Followings { get; set; }
            public GetFollowingGetRemoteFollowersModel Followers { get; set; }
        }

        public interface IGetFollowingGetModel
        {
            public GetFollowingGetLocalModel Local { get; set; }
            public GetFollowingGetRemoteModel Remote { get; set; }
        }

        public class GetFollowingGetModel : IGetFollowingGetModel
        {
            public GetFollowingGetLocalModel Local { get; set; }
            public GetFollowingGetRemoteModel Remote { get; set; }
        }

        public async Task<Response<PostFollowingModel>> Following(ChartsUserFollowingPropertiesSpanEnum span,
            string userId, int limit = 30, int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset },
                { "userId", userId }
            };
            var result = await _app.Request<PostFollowingModel>(
                "charts/user/following",
                param,
                false
            );
            return result;
        }

        public enum ChartsUserFollowingPropertiesSpanEnum
        {
            [EnumMember(Value = "day")] Day,
            [EnumMember(Value = "hour")] Hour
        }

        public interface IPostFollowingLocalFollowingsModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public class PostFollowingLocalFollowingsModel : IPostFollowingLocalFollowingsModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public interface IPostFollowingLocalFollowersModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public class PostFollowingLocalFollowersModel : IPostFollowingLocalFollowersModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public interface IPostFollowingLocalModel
        {
            public PostFollowingLocalFollowingsModel Followings { get; set; }
            public PostFollowingLocalFollowersModel Followers { get; set; }
        }

        public class PostFollowingLocalModel : IPostFollowingLocalModel
        {
            public PostFollowingLocalFollowingsModel Followings { get; set; }
            public PostFollowingLocalFollowersModel Followers { get; set; }
        }

        public interface IPostFollowingRemoteFollowingsModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public class PostFollowingRemoteFollowingsModel : IPostFollowingRemoteFollowingsModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public interface IPostFollowingRemoteFollowersModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public class PostFollowingRemoteFollowersModel : IPostFollowingRemoteFollowersModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
        }

        public interface IPostFollowingRemoteModel
        {
            public PostFollowingRemoteFollowingsModel Followings { get; set; }
            public PostFollowingRemoteFollowersModel Followers { get; set; }
        }

        public class PostFollowingRemoteModel : IPostFollowingRemoteModel
        {
            public PostFollowingRemoteFollowingsModel Followings { get; set; }
            public PostFollowingRemoteFollowersModel Followers { get; set; }
        }

        public interface IPostFollowingModel
        {
            public PostFollowingLocalModel Local { get; set; }
            public PostFollowingRemoteModel Remote { get; set; }
        }

        public class PostFollowingModel : IPostFollowingModel
        {
            public PostFollowingLocalModel Local { get; set; }
            public PostFollowingRemoteModel Remote { get; set; }
        }

        public async Task<Response<GetNotesGetModel>> NotesGet(ChartsUserNotesPropertiesSpanEnum span, string userId,
            int limit = 30, int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset },
                { "userId", userId }
            };
            var result = await _app.Request<GetNotesGetModel>(
                "charts/user/notes",
                param,
                false
            );
            return result;
        }

        public interface IGetNotesGetDiffsModel
        {
            public List<decimal> Normal { get; set; }
            public List<decimal> Reply { get; set; }
            public List<decimal> Renote { get; set; }
            public List<decimal> WithFile { get; set; }
        }

        public class GetNotesGetDiffsModel : IGetNotesGetDiffsModel
        {
            public List<decimal> Normal { get; set; }
            public List<decimal> Reply { get; set; }
            public List<decimal> Renote { get; set; }
            public List<decimal> WithFile { get; set; }
        }

        public interface IGetNotesGetModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
            public GetNotesGetDiffsModel Diffs { get; set; }
        }

        public class GetNotesGetModel : IGetNotesGetModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
            public GetNotesGetDiffsModel Diffs { get; set; }
        }

        public async Task<Response<PostNotesModel>> Notes(ChartsUserNotesPropertiesSpanEnum span, string userId,
            int limit = 30, int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset },
                { "userId", userId }
            };
            var result = await _app.Request<PostNotesModel>(
                "charts/user/notes",
                param,
                false
            );
            return result;
        }

        public enum ChartsUserNotesPropertiesSpanEnum
        {
            [EnumMember(Value = "day")] Day,
            [EnumMember(Value = "hour")] Hour
        }

        public interface IPostNotesDiffsModel
        {
            public List<decimal> Normal { get; set; }
            public List<decimal> Reply { get; set; }
            public List<decimal> Renote { get; set; }
            public List<decimal> WithFile { get; set; }
        }

        public class PostNotesDiffsModel : IPostNotesDiffsModel
        {
            public List<decimal> Normal { get; set; }
            public List<decimal> Reply { get; set; }
            public List<decimal> Renote { get; set; }
            public List<decimal> WithFile { get; set; }
        }

        public interface IPostNotesModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
            public PostNotesDiffsModel Diffs { get; set; }
        }

        public class PostNotesModel : IPostNotesModel
        {
            public List<decimal> Total { get; set; }
            public List<decimal> Inc { get; set; }
            public List<decimal> Dec { get; set; }
            public PostNotesDiffsModel Diffs { get; set; }
        }

        public async Task<Response<GetPvGetModel>> PvGet(ChartsUserPvPropertiesSpanEnum span, string userId,
            int limit = 30, int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset },
                { "userId", userId }
            };
            var result = await _app.Request<GetPvGetModel>(
                "charts/user/pv",
                param,
                false
            );
            return result;
        }

        public interface IGetPvGetUpvModel
        {
            public List<decimal> User { get; set; }
            public List<decimal> Visitor { get; set; }
        }

        public class GetPvGetUpvModel : IGetPvGetUpvModel
        {
            public List<decimal> User { get; set; }
            public List<decimal> Visitor { get; set; }
        }

        public interface IGetPvGetPvModel
        {
            public List<decimal> User { get; set; }
            public List<decimal> Visitor { get; set; }
        }

        public class GetPvGetPvModel : IGetPvGetPvModel
        {
            public List<decimal> User { get; set; }
            public List<decimal> Visitor { get; set; }
        }

        public interface IGetPvGetModel
        {
            public GetPvGetUpvModel Upv { get; set; }
            public GetPvGetPvModel Pv { get; set; }
        }

        public class GetPvGetModel : IGetPvGetModel
        {
            public GetPvGetUpvModel Upv { get; set; }
            public GetPvGetPvModel Pv { get; set; }
        }

        public async Task<Response<PostPvModel>> Pv(ChartsUserPvPropertiesSpanEnum span, string userId, int limit = 30,
            int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset },
                { "userId", userId }
            };
            var result = await _app.Request<PostPvModel>(
                "charts/user/pv",
                param,
                false
            );
            return result;
        }

        public enum ChartsUserPvPropertiesSpanEnum
        {
            [EnumMember(Value = "day")] Day,
            [EnumMember(Value = "hour")] Hour
        }

        public interface IPostPvUpvModel
        {
            public List<decimal> User { get; set; }
            public List<decimal> Visitor { get; set; }
        }

        public class PostPvUpvModel : IPostPvUpvModel
        {
            public List<decimal> User { get; set; }
            public List<decimal> Visitor { get; set; }
        }

        public interface IPostPvPvModel
        {
            public List<decimal> User { get; set; }
            public List<decimal> Visitor { get; set; }
        }

        public class PostPvPvModel : IPostPvPvModel
        {
            public List<decimal> User { get; set; }
            public List<decimal> Visitor { get; set; }
        }

        public interface IPostPvModel
        {
            public PostPvUpvModel Upv { get; set; }
            public PostPvPvModel Pv { get; set; }
        }

        public class PostPvModel : IPostPvModel
        {
            public PostPvUpvModel Upv { get; set; }
            public PostPvPvModel Pv { get; set; }
        }

        public async Task<Response<GetReactionsGetModel>> ReactionsGet(ChartsUserReactionsPropertiesSpanEnum span,
            string userId, int limit = 30, int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset },
                { "userId", userId }
            };
            var result = await _app.Request<GetReactionsGetModel>(
                "charts/user/reactions",
                param,
                false
            );
            return result;
        }

        public interface IGetReactionsGetLocalModel
        {
            public List<decimal> Count { get; set; }
        }

        public class GetReactionsGetLocalModel : IGetReactionsGetLocalModel
        {
            public List<decimal> Count { get; set; }
        }

        public interface IGetReactionsGetRemoteModel
        {
            public List<decimal> Count { get; set; }
        }

        public class GetReactionsGetRemoteModel : IGetReactionsGetRemoteModel
        {
            public List<decimal> Count { get; set; }
        }

        public interface IGetReactionsGetModel
        {
            public GetReactionsGetLocalModel Local { get; set; }
            public GetReactionsGetRemoteModel Remote { get; set; }
        }

        public class GetReactionsGetModel : IGetReactionsGetModel
        {
            public GetReactionsGetLocalModel Local { get; set; }
            public GetReactionsGetRemoteModel Remote { get; set; }
        }

        public async Task<Response<PostReactionsModel>> Reactions(ChartsUserReactionsPropertiesSpanEnum span,
            string userId, int limit = 30, int? offset = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "span", span },
                { "limit", limit },
                { "offset", offset },
                { "userId", userId }
            };
            var result = await _app.Request<PostReactionsModel>(
                "charts/user/reactions",
                param,
                false
            );
            return result;
        }

        public enum ChartsUserReactionsPropertiesSpanEnum
        {
            [EnumMember(Value = "day")] Day,
            [EnumMember(Value = "hour")] Hour
        }

        public interface IPostReactionsLocalModel
        {
            public List<decimal> Count { get; set; }
        }

        public class PostReactionsLocalModel : IPostReactionsLocalModel
        {
            public List<decimal> Count { get; set; }
        }

        public interface IPostReactionsRemoteModel
        {
            public List<decimal> Count { get; set; }
        }

        public class PostReactionsRemoteModel : IPostReactionsRemoteModel
        {
            public List<decimal> Count { get; set; }
        }

        public interface IPostReactionsModel
        {
            public PostReactionsLocalModel Local { get; set; }
            public PostReactionsRemoteModel Remote { get; set; }
        }

        public class PostReactionsModel : IPostReactionsModel
        {
            public PostReactionsLocalModel Local { get; set; }
            public PostReactionsRemoteModel Remote { get; set; }
        }
    }
}