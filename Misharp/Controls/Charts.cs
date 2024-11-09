using Misharp.Models;
using System.Text.Json;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class ChartsApi
	{
		private readonly App _app;
		public async Task<Response<ChartsActiveUsersGetModel>> ActiveUsersGet(ChartsActiveUsersPropertiesSpanEnum span,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
			};
			var result = await _app.Request<ChartsActiveUsersGetModel>(
				"charts/active-users", 
				param, 
				needToken: false
			);
			return result;
		}

		public enum ChartsActiveUsersPropertiesSpanEnum {
			[EnumMember(Value = "day")]
			Day,
			[EnumMember(Value = "hour")]
			Hour,
		}
		public interface IChartsActiveUsersGetModel
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
		public class ChartsActiveUsersGetModel: IChartsActiveUsersGetModel
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
		public async Task<Response<ChartsActiveUsersModel>> ActiveUsers(ChartsActiveUsersPropertiesSpanEnum span,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
			};
			var result = await _app.Request<ChartsActiveUsersModel>(
				"charts/active-users", 
				param, 
				needToken: false
			);
			return result;
		}
		public interface IChartsActiveUsersModel
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
		public class ChartsActiveUsersModel: IChartsActiveUsersModel
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
		public async Task<Response<ChartsApRequestGetModel>> ApRequestGet(ChartsApRequestPropertiesSpanEnum span,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
			};
			var result = await _app.Request<ChartsApRequestGetModel>(
				"charts/ap-request", 
				param, 
				needToken: false
			);
			return result;
		}

		public enum ChartsApRequestPropertiesSpanEnum {
			[EnumMember(Value = "day")]
			Day,
			[EnumMember(Value = "hour")]
			Hour,
		}
		public interface IChartsApRequestGetModel
		{
			public List<decimal> DeliverFailed { get; set; }
			public List<decimal> DeliverSucceeded { get; set; }
			public List<decimal> InboxReceived { get; set; }
		}
		public class ChartsApRequestGetModel: IChartsApRequestGetModel
		{
			public List<decimal> DeliverFailed { get; set; }
			public List<decimal> DeliverSucceeded { get; set; }
			public List<decimal> InboxReceived { get; set; }
		}
		public async Task<Response<ChartsApRequestModel>> ApRequest(ChartsApRequestPropertiesSpanEnum span,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
			};
			var result = await _app.Request<ChartsApRequestModel>(
				"charts/ap-request", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IChartsApRequestModel
		{
			public List<decimal> DeliverFailed { get; set; }
			public List<decimal> DeliverSucceeded { get; set; }
			public List<decimal> InboxReceived { get; set; }
		}
		public class ChartsApRequestModel: IChartsApRequestModel
		{
			public List<decimal> DeliverFailed { get; set; }
			public List<decimal> DeliverSucceeded { get; set; }
			public List<decimal> InboxReceived { get; set; }
		}
		public async Task<Response<ChartsDriveGetModel>> DriveGet(ChartsDrivePropertiesSpanEnum span,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
			};
			var result = await _app.Request<ChartsDriveGetModel>(
				"charts/drive", 
				param, 
				needToken: false
			);
			return result;
		}

		public enum ChartsDrivePropertiesSpanEnum {
			[EnumMember(Value = "day")]
			Day,
			[EnumMember(Value = "hour")]
			Hour,
		}
		public interface IChartsDriveGetLocalModel
		{
			public List<decimal> IncCount { get; set; }
			public List<decimal> IncSize { get; set; }
			public List<decimal> DecCount { get; set; }
			public List<decimal> DecSize { get; set; }
		}
		public class ChartsDriveGetLocalModel: IChartsDriveGetLocalModel
		{
			public List<decimal> IncCount { get; set; }
			public List<decimal> IncSize { get; set; }
			public List<decimal> DecCount { get; set; }
			public List<decimal> DecSize { get; set; }
		}
		public interface IChartsDriveGetRemoteModel
		{
			public List<decimal> IncCount { get; set; }
			public List<decimal> IncSize { get; set; }
			public List<decimal> DecCount { get; set; }
			public List<decimal> DecSize { get; set; }
		}
		public class ChartsDriveGetRemoteModel: IChartsDriveGetRemoteModel
		{
			public List<decimal> IncCount { get; set; }
			public List<decimal> IncSize { get; set; }
			public List<decimal> DecCount { get; set; }
			public List<decimal> DecSize { get; set; }
		}
		public interface IChartsDriveGetModel
		{
			public ChartsDriveGetLocalModel Local { get; set; }
			public ChartsDriveGetRemoteModel Remote { get; set; }
		}
		public class ChartsDriveGetModel: IChartsDriveGetModel
		{
			public ChartsDriveGetLocalModel Local { get; set; }
			public ChartsDriveGetRemoteModel Remote { get; set; }
		}
		public async Task<Response<ChartsDriveModel>> Drive(ChartsDrivePropertiesSpanEnum span,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
			};
			var result = await _app.Request<ChartsDriveModel>(
				"charts/drive", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IChartsDriveLocalModel
		{
			public List<decimal> IncCount { get; set; }
			public List<decimal> IncSize { get; set; }
			public List<decimal> DecCount { get; set; }
			public List<decimal> DecSize { get; set; }
		}
		public class ChartsDriveLocalModel: IChartsDriveLocalModel
		{
			public List<decimal> IncCount { get; set; }
			public List<decimal> IncSize { get; set; }
			public List<decimal> DecCount { get; set; }
			public List<decimal> DecSize { get; set; }
		}
		public interface IChartsDriveRemoteModel
		{
			public List<decimal> IncCount { get; set; }
			public List<decimal> IncSize { get; set; }
			public List<decimal> DecCount { get; set; }
			public List<decimal> DecSize { get; set; }
		}
		public class ChartsDriveRemoteModel: IChartsDriveRemoteModel
		{
			public List<decimal> IncCount { get; set; }
			public List<decimal> IncSize { get; set; }
			public List<decimal> DecCount { get; set; }
			public List<decimal> DecSize { get; set; }
		}
		public interface IChartsDriveModel
		{
			public ChartsDriveLocalModel Local { get; set; }
			public ChartsDriveRemoteModel Remote { get; set; }
		}
		public class ChartsDriveModel: IChartsDriveModel
		{
			public ChartsDriveLocalModel Local { get; set; }
			public ChartsDriveRemoteModel Remote { get; set; }
		}
		public async Task<Response<ChartsFederationGetModel>> FederationGet(ChartsFederationPropertiesSpanEnum span,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
			};
			var result = await _app.Request<ChartsFederationGetModel>(
				"charts/federation", 
				param, 
				needToken: false
			);
			return result;
		}

		public enum ChartsFederationPropertiesSpanEnum {
			[EnumMember(Value = "day")]
			Day,
			[EnumMember(Value = "hour")]
			Hour,
		}
		public interface IChartsFederationGetModel
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
		public class ChartsFederationGetModel: IChartsFederationGetModel
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
		public async Task<Response<ChartsFederationModel>> Federation(ChartsFederationPropertiesSpanEnum span,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
			};
			var result = await _app.Request<ChartsFederationModel>(
				"charts/federation", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IChartsFederationModel
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
		public class ChartsFederationModel: IChartsFederationModel
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
		public async Task<Response<ChartsInstanceGetModel>> InstanceGet(ChartsInstancePropertiesSpanEnum span,string host,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
				{ "host", host },
			};
			var result = await _app.Request<ChartsInstanceGetModel>(
				"charts/instance", 
				param, 
				needToken: false
			);
			return result;
		}

		public enum ChartsInstancePropertiesSpanEnum {
			[EnumMember(Value = "day")]
			Day,
			[EnumMember(Value = "hour")]
			Hour,
		}
		public interface IChartsInstanceGetRequestsModel
		{
			public List<decimal> Failed { get; set; }
			public List<decimal> Succeeded { get; set; }
			public List<decimal> Received { get; set; }
		}
		public class ChartsInstanceGetRequestsModel: IChartsInstanceGetRequestsModel
		{
			public List<decimal> Failed { get; set; }
			public List<decimal> Succeeded { get; set; }
			public List<decimal> Received { get; set; }
		}
		public interface IChartsInstanceGetNotesDiffsModel
		{
			public List<decimal> Normal { get; set; }
			public List<decimal> Reply { get; set; }
			public List<decimal> Renote { get; set; }
			public List<decimal> WithFile { get; set; }
		}
		public class ChartsInstanceGetNotesDiffsModel: IChartsInstanceGetNotesDiffsModel
		{
			public List<decimal> Normal { get; set; }
			public List<decimal> Reply { get; set; }
			public List<decimal> Renote { get; set; }
			public List<decimal> WithFile { get; set; }
		}
		public interface IChartsInstanceGetNotesModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
			public ChartsInstanceGetNotesDiffsModel Diffs { get; set; }
		}
		public class ChartsInstanceGetNotesModel: IChartsInstanceGetNotesModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
			public ChartsInstanceGetNotesDiffsModel Diffs { get; set; }
		}
		public interface IChartsInstanceGetUsersModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public class ChartsInstanceGetUsersModel: IChartsInstanceGetUsersModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public interface IChartsInstanceGetFollowingModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public class ChartsInstanceGetFollowingModel: IChartsInstanceGetFollowingModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public interface IChartsInstanceGetFollowersModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public class ChartsInstanceGetFollowersModel: IChartsInstanceGetFollowersModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public interface IChartsInstanceGetDriveModel
		{
			public List<decimal> TotalFiles { get; set; }
			public List<decimal> IncFiles { get; set; }
			public List<decimal> DecFiles { get; set; }
			public List<decimal> IncUsage { get; set; }
			public List<decimal> DecUsage { get; set; }
		}
		public class ChartsInstanceGetDriveModel: IChartsInstanceGetDriveModel
		{
			public List<decimal> TotalFiles { get; set; }
			public List<decimal> IncFiles { get; set; }
			public List<decimal> DecFiles { get; set; }
			public List<decimal> IncUsage { get; set; }
			public List<decimal> DecUsage { get; set; }
		}
		public interface IChartsInstanceGetModel
		{
			public ChartsInstanceGetRequestsModel Requests { get; set; }
			public ChartsInstanceGetNotesModel Notes { get; set; }
			public ChartsInstanceGetUsersModel Users { get; set; }
			public ChartsInstanceGetFollowingModel Following { get; set; }
			public ChartsInstanceGetFollowersModel Followers { get; set; }
			public ChartsInstanceGetDriveModel Drive { get; set; }
		}
		public class ChartsInstanceGetModel: IChartsInstanceGetModel
		{
			public ChartsInstanceGetRequestsModel Requests { get; set; }
			public ChartsInstanceGetNotesModel Notes { get; set; }
			public ChartsInstanceGetUsersModel Users { get; set; }
			public ChartsInstanceGetFollowingModel Following { get; set; }
			public ChartsInstanceGetFollowersModel Followers { get; set; }
			public ChartsInstanceGetDriveModel Drive { get; set; }
		}
		public async Task<Response<ChartsInstanceModel>> Instance(ChartsInstancePropertiesSpanEnum span,string host,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
				{ "host", host },
			};
			var result = await _app.Request<ChartsInstanceModel>(
				"charts/instance", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IChartsInstanceRequestsModel
		{
			public List<decimal> Failed { get; set; }
			public List<decimal> Succeeded { get; set; }
			public List<decimal> Received { get; set; }
		}
		public class ChartsInstanceRequestsModel: IChartsInstanceRequestsModel
		{
			public List<decimal> Failed { get; set; }
			public List<decimal> Succeeded { get; set; }
			public List<decimal> Received { get; set; }
		}
		public interface IChartsInstanceNotesDiffsModel
		{
			public List<decimal> Normal { get; set; }
			public List<decimal> Reply { get; set; }
			public List<decimal> Renote { get; set; }
			public List<decimal> WithFile { get; set; }
		}
		public class ChartsInstanceNotesDiffsModel: IChartsInstanceNotesDiffsModel
		{
			public List<decimal> Normal { get; set; }
			public List<decimal> Reply { get; set; }
			public List<decimal> Renote { get; set; }
			public List<decimal> WithFile { get; set; }
		}
		public interface IChartsInstanceNotesModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
			public ChartsInstanceNotesDiffsModel Diffs { get; set; }
		}
		public class ChartsInstanceNotesModel: IChartsInstanceNotesModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
			public ChartsInstanceNotesDiffsModel Diffs { get; set; }
		}
		public interface IChartsInstanceUsersModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public class ChartsInstanceUsersModel: IChartsInstanceUsersModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public interface IChartsInstanceFollowingModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public class ChartsInstanceFollowingModel: IChartsInstanceFollowingModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public interface IChartsInstanceFollowersModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public class ChartsInstanceFollowersModel: IChartsInstanceFollowersModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public interface IChartsInstanceDriveModel
		{
			public List<decimal> TotalFiles { get; set; }
			public List<decimal> IncFiles { get; set; }
			public List<decimal> DecFiles { get; set; }
			public List<decimal> IncUsage { get; set; }
			public List<decimal> DecUsage { get; set; }
		}
		public class ChartsInstanceDriveModel: IChartsInstanceDriveModel
		{
			public List<decimal> TotalFiles { get; set; }
			public List<decimal> IncFiles { get; set; }
			public List<decimal> DecFiles { get; set; }
			public List<decimal> IncUsage { get; set; }
			public List<decimal> DecUsage { get; set; }
		}
		public interface IChartsInstanceModel
		{
			public ChartsInstanceRequestsModel Requests { get; set; }
			public ChartsInstanceNotesModel Notes { get; set; }
			public ChartsInstanceUsersModel Users { get; set; }
			public ChartsInstanceFollowingModel Following { get; set; }
			public ChartsInstanceFollowersModel Followers { get; set; }
			public ChartsInstanceDriveModel Drive { get; set; }
		}
		public class ChartsInstanceModel: IChartsInstanceModel
		{
			public ChartsInstanceRequestsModel Requests { get; set; }
			public ChartsInstanceNotesModel Notes { get; set; }
			public ChartsInstanceUsersModel Users { get; set; }
			public ChartsInstanceFollowingModel Following { get; set; }
			public ChartsInstanceFollowersModel Followers { get; set; }
			public ChartsInstanceDriveModel Drive { get; set; }
		}
		public async Task<Response<ChartsNotesGetModel>> NotesGet(ChartsNotesPropertiesSpanEnum span,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
			};
			var result = await _app.Request<ChartsNotesGetModel>(
				"charts/notes", 
				param, 
				needToken: false
			);
			return result;
		}

		public enum ChartsNotesPropertiesSpanEnum {
			[EnumMember(Value = "day")]
			Day,
			[EnumMember(Value = "hour")]
			Hour,
		}
		public interface IChartsNotesGetLocalDiffsModel
		{
			public List<decimal> Normal { get; set; }
			public List<decimal> Reply { get; set; }
			public List<decimal> Renote { get; set; }
			public List<decimal> WithFile { get; set; }
		}
		public class ChartsNotesGetLocalDiffsModel: IChartsNotesGetLocalDiffsModel
		{
			public List<decimal> Normal { get; set; }
			public List<decimal> Reply { get; set; }
			public List<decimal> Renote { get; set; }
			public List<decimal> WithFile { get; set; }
		}
		public interface IChartsNotesGetLocalModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
			public ChartsNotesGetLocalDiffsModel Diffs { get; set; }
		}
		public class ChartsNotesGetLocalModel: IChartsNotesGetLocalModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
			public ChartsNotesGetLocalDiffsModel Diffs { get; set; }
		}
		public interface IChartsNotesGetRemoteDiffsModel
		{
			public List<decimal> Normal { get; set; }
			public List<decimal> Reply { get; set; }
			public List<decimal> Renote { get; set; }
			public List<decimal> WithFile { get; set; }
		}
		public class ChartsNotesGetRemoteDiffsModel: IChartsNotesGetRemoteDiffsModel
		{
			public List<decimal> Normal { get; set; }
			public List<decimal> Reply { get; set; }
			public List<decimal> Renote { get; set; }
			public List<decimal> WithFile { get; set; }
		}
		public interface IChartsNotesGetRemoteModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
			public ChartsNotesGetRemoteDiffsModel Diffs { get; set; }
		}
		public class ChartsNotesGetRemoteModel: IChartsNotesGetRemoteModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
			public ChartsNotesGetRemoteDiffsModel Diffs { get; set; }
		}
		public interface IChartsNotesGetModel
		{
			public ChartsNotesGetLocalModel Local { get; set; }
			public ChartsNotesGetRemoteModel Remote { get; set; }
		}
		public class ChartsNotesGetModel: IChartsNotesGetModel
		{
			public ChartsNotesGetLocalModel Local { get; set; }
			public ChartsNotesGetRemoteModel Remote { get; set; }
		}
		public async Task<Response<ChartsNotesModel>> Notes(ChartsNotesPropertiesSpanEnum span,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
			};
			var result = await _app.Request<ChartsNotesModel>(
				"charts/notes", 
				param, 
				needToken: false
			);
			return result;
		}
		public interface IChartsNotesLocalDiffsModel
		{
			public List<decimal> Normal { get; set; }
			public List<decimal> Reply { get; set; }
			public List<decimal> Renote { get; set; }
			public List<decimal> WithFile { get; set; }
		}
		public class ChartsNotesLocalDiffsModel: IChartsNotesLocalDiffsModel
		{
			public List<decimal> Normal { get; set; }
			public List<decimal> Reply { get; set; }
			public List<decimal> Renote { get; set; }
			public List<decimal> WithFile { get; set; }
		}
		public interface IChartsNotesLocalModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
			public ChartsNotesLocalDiffsModel Diffs { get; set; }
		}
		public class ChartsNotesLocalModel: IChartsNotesLocalModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
			public ChartsNotesLocalDiffsModel Diffs { get; set; }
		}
		public interface IChartsNotesRemoteDiffsModel
		{
			public List<decimal> Normal { get; set; }
			public List<decimal> Reply { get; set; }
			public List<decimal> Renote { get; set; }
			public List<decimal> WithFile { get; set; }
		}
		public class ChartsNotesRemoteDiffsModel: IChartsNotesRemoteDiffsModel
		{
			public List<decimal> Normal { get; set; }
			public List<decimal> Reply { get; set; }
			public List<decimal> Renote { get; set; }
			public List<decimal> WithFile { get; set; }
		}
		public interface IChartsNotesRemoteModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
			public ChartsNotesRemoteDiffsModel Diffs { get; set; }
		}
		public class ChartsNotesRemoteModel: IChartsNotesRemoteModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
			public ChartsNotesRemoteDiffsModel Diffs { get; set; }
		}
		public interface IChartsNotesModel
		{
			public ChartsNotesLocalModel Local { get; set; }
			public ChartsNotesRemoteModel Remote { get; set; }
		}
		public class ChartsNotesModel: IChartsNotesModel
		{
			public ChartsNotesLocalModel Local { get; set; }
			public ChartsNotesRemoteModel Remote { get; set; }
		}
		public async Task<Response<ChartsUsersGetModel>> UsersGet(ChartsUsersPropertiesSpanEnum span,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
			};
			var result = await _app.Request<ChartsUsersGetModel>(
				"charts/users", 
				param, 
				needToken: false
			);
			return result;
		}

		public enum ChartsUsersPropertiesSpanEnum {
			[EnumMember(Value = "day")]
			Day,
			[EnumMember(Value = "hour")]
			Hour,
		}
		public interface IChartsUsersGetLocalModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public class ChartsUsersGetLocalModel: IChartsUsersGetLocalModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public interface IChartsUsersGetRemoteModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public class ChartsUsersGetRemoteModel: IChartsUsersGetRemoteModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public interface IChartsUsersGetModel
		{
			public ChartsUsersGetLocalModel Local { get; set; }
			public ChartsUsersGetRemoteModel Remote { get; set; }
		}
		public class ChartsUsersGetModel: IChartsUsersGetModel
		{
			public ChartsUsersGetLocalModel Local { get; set; }
			public ChartsUsersGetRemoteModel Remote { get; set; }
		}
		public async Task<Response<ChartsUsersModel>> Users(ChartsUsersPropertiesSpanEnum span,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
			};
			var result = await _app.Request<ChartsUsersModel>(
				"charts/users", 
				param, 
				needToken: false
			);
			return result;
		}
		public interface IChartsUsersLocalModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public class ChartsUsersLocalModel: IChartsUsersLocalModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public interface IChartsUsersRemoteModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public class ChartsUsersRemoteModel: IChartsUsersRemoteModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public interface IChartsUsersModel
		{
			public ChartsUsersLocalModel Local { get; set; }
			public ChartsUsersRemoteModel Remote { get; set; }
		}
		public class ChartsUsersModel: IChartsUsersModel
		{
			public ChartsUsersLocalModel Local { get; set; }
			public ChartsUsersRemoteModel Remote { get; set; }
		}
		public readonly Charts.UserApi UserApi;
		public ChartsApi(App app)
		{
			this._app = app;
			this.UserApi = new Charts.UserApi(this._app);
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
			this._app = app;
		}
		public async Task<Response<ChartsDriveGetModel>> DriveGet(ChartsUserDrivePropertiesSpanEnum span,string userId,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
				{ "userId", userId },
			};
			var result = await _app.Request<ChartsDriveGetModel>(
				"charts/user/drive", 
				param, 
				needToken: false
			);
			return result;
		}

		public enum ChartsUserDrivePropertiesSpanEnum {
			[EnumMember(Value = "day")]
			Day,
			[EnumMember(Value = "hour")]
			Hour,
		}
		public interface IChartsDriveGetModel
		{
			public List<decimal> TotalCount { get; set; }
			public List<decimal> TotalSize { get; set; }
			public List<decimal> IncCount { get; set; }
			public List<decimal> IncSize { get; set; }
			public List<decimal> DecCount { get; set; }
			public List<decimal> DecSize { get; set; }
		}
		public class ChartsDriveGetModel: IChartsDriveGetModel
		{
			public List<decimal> TotalCount { get; set; }
			public List<decimal> TotalSize { get; set; }
			public List<decimal> IncCount { get; set; }
			public List<decimal> IncSize { get; set; }
			public List<decimal> DecCount { get; set; }
			public List<decimal> DecSize { get; set; }
		}
		public async Task<Response<ChartsDriveModel>> Drive(ChartsUserDrivePropertiesSpanEnum span,string userId,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
				{ "userId", userId },
			};
			var result = await _app.Request<ChartsDriveModel>(
				"charts/user/drive", 
				param, 
				needToken: false
			);
			return result;
		}
		public interface IChartsDriveModel
		{
			public List<decimal> TotalCount { get; set; }
			public List<decimal> TotalSize { get; set; }
			public List<decimal> IncCount { get; set; }
			public List<decimal> IncSize { get; set; }
			public List<decimal> DecCount { get; set; }
			public List<decimal> DecSize { get; set; }
		}
		public class ChartsDriveModel: IChartsDriveModel
		{
			public List<decimal> TotalCount { get; set; }
			public List<decimal> TotalSize { get; set; }
			public List<decimal> IncCount { get; set; }
			public List<decimal> IncSize { get; set; }
			public List<decimal> DecCount { get; set; }
			public List<decimal> DecSize { get; set; }
		}
		public async Task<Response<ChartsFollowingGetModel>> FollowingGet(ChartsUserFollowingPropertiesSpanEnum span,string userId,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
				{ "userId", userId },
			};
			var result = await _app.Request<ChartsFollowingGetModel>(
				"charts/user/following", 
				param, 
				needToken: false
			);
			return result;
		}

		public enum ChartsUserFollowingPropertiesSpanEnum {
			[EnumMember(Value = "day")]
			Day,
			[EnumMember(Value = "hour")]
			Hour,
		}
		public interface IChartsFollowingGetLocalFollowingsModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public class ChartsFollowingGetLocalFollowingsModel: IChartsFollowingGetLocalFollowingsModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public interface IChartsFollowingGetLocalFollowersModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public class ChartsFollowingGetLocalFollowersModel: IChartsFollowingGetLocalFollowersModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public interface IChartsFollowingGetLocalModel
		{
			public ChartsFollowingGetLocalFollowingsModel Followings { get; set; }
			public ChartsFollowingGetLocalFollowersModel Followers { get; set; }
		}
		public class ChartsFollowingGetLocalModel: IChartsFollowingGetLocalModel
		{
			public ChartsFollowingGetLocalFollowingsModel Followings { get; set; }
			public ChartsFollowingGetLocalFollowersModel Followers { get; set; }
		}
		public interface IChartsFollowingGetRemoteFollowingsModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public class ChartsFollowingGetRemoteFollowingsModel: IChartsFollowingGetRemoteFollowingsModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public interface IChartsFollowingGetRemoteFollowersModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public class ChartsFollowingGetRemoteFollowersModel: IChartsFollowingGetRemoteFollowersModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public interface IChartsFollowingGetRemoteModel
		{
			public ChartsFollowingGetRemoteFollowingsModel Followings { get; set; }
			public ChartsFollowingGetRemoteFollowersModel Followers { get; set; }
		}
		public class ChartsFollowingGetRemoteModel: IChartsFollowingGetRemoteModel
		{
			public ChartsFollowingGetRemoteFollowingsModel Followings { get; set; }
			public ChartsFollowingGetRemoteFollowersModel Followers { get; set; }
		}
		public interface IChartsFollowingGetModel
		{
			public ChartsFollowingGetLocalModel Local { get; set; }
			public ChartsFollowingGetRemoteModel Remote { get; set; }
		}
		public class ChartsFollowingGetModel: IChartsFollowingGetModel
		{
			public ChartsFollowingGetLocalModel Local { get; set; }
			public ChartsFollowingGetRemoteModel Remote { get; set; }
		}
		public async Task<Response<ChartsFollowingModel>> Following(ChartsUserFollowingPropertiesSpanEnum span,string userId,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
				{ "userId", userId },
			};
			var result = await _app.Request<ChartsFollowingModel>(
				"charts/user/following", 
				param, 
				needToken: false
			);
			return result;
		}
		public interface IChartsFollowingLocalFollowingsModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public class ChartsFollowingLocalFollowingsModel: IChartsFollowingLocalFollowingsModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public interface IChartsFollowingLocalFollowersModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public class ChartsFollowingLocalFollowersModel: IChartsFollowingLocalFollowersModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public interface IChartsFollowingLocalModel
		{
			public ChartsFollowingLocalFollowingsModel Followings { get; set; }
			public ChartsFollowingLocalFollowersModel Followers { get; set; }
		}
		public class ChartsFollowingLocalModel: IChartsFollowingLocalModel
		{
			public ChartsFollowingLocalFollowingsModel Followings { get; set; }
			public ChartsFollowingLocalFollowersModel Followers { get; set; }
		}
		public interface IChartsFollowingRemoteFollowingsModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public class ChartsFollowingRemoteFollowingsModel: IChartsFollowingRemoteFollowingsModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public interface IChartsFollowingRemoteFollowersModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public class ChartsFollowingRemoteFollowersModel: IChartsFollowingRemoteFollowersModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
		}
		public interface IChartsFollowingRemoteModel
		{
			public ChartsFollowingRemoteFollowingsModel Followings { get; set; }
			public ChartsFollowingRemoteFollowersModel Followers { get; set; }
		}
		public class ChartsFollowingRemoteModel: IChartsFollowingRemoteModel
		{
			public ChartsFollowingRemoteFollowingsModel Followings { get; set; }
			public ChartsFollowingRemoteFollowersModel Followers { get; set; }
		}
		public interface IChartsFollowingModel
		{
			public ChartsFollowingLocalModel Local { get; set; }
			public ChartsFollowingRemoteModel Remote { get; set; }
		}
		public class ChartsFollowingModel: IChartsFollowingModel
		{
			public ChartsFollowingLocalModel Local { get; set; }
			public ChartsFollowingRemoteModel Remote { get; set; }
		}
		public async Task<Response<ChartsNotesGetModel>> NotesGet(ChartsUserNotesPropertiesSpanEnum span,string userId,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
				{ "userId", userId },
			};
			var result = await _app.Request<ChartsNotesGetModel>(
				"charts/user/notes", 
				param, 
				needToken: false
			);
			return result;
		}

		public enum ChartsUserNotesPropertiesSpanEnum {
			[EnumMember(Value = "day")]
			Day,
			[EnumMember(Value = "hour")]
			Hour,
		}
		public interface IChartsNotesGetDiffsModel
		{
			public List<decimal> Normal { get; set; }
			public List<decimal> Reply { get; set; }
			public List<decimal> Renote { get; set; }
			public List<decimal> WithFile { get; set; }
		}
		public class ChartsNotesGetDiffsModel: IChartsNotesGetDiffsModel
		{
			public List<decimal> Normal { get; set; }
			public List<decimal> Reply { get; set; }
			public List<decimal> Renote { get; set; }
			public List<decimal> WithFile { get; set; }
		}
		public interface IChartsNotesGetModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
			public ChartsNotesGetDiffsModel Diffs { get; set; }
		}
		public class ChartsNotesGetModel: IChartsNotesGetModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
			public ChartsNotesGetDiffsModel Diffs { get; set; }
		}
		public async Task<Response<ChartsNotesModel>> Notes(ChartsUserNotesPropertiesSpanEnum span,string userId,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
				{ "userId", userId },
			};
			var result = await _app.Request<ChartsNotesModel>(
				"charts/user/notes", 
				param, 
				needToken: false
			);
			return result;
		}
		public interface IChartsNotesDiffsModel
		{
			public List<decimal> Normal { get; set; }
			public List<decimal> Reply { get; set; }
			public List<decimal> Renote { get; set; }
			public List<decimal> WithFile { get; set; }
		}
		public class ChartsNotesDiffsModel: IChartsNotesDiffsModel
		{
			public List<decimal> Normal { get; set; }
			public List<decimal> Reply { get; set; }
			public List<decimal> Renote { get; set; }
			public List<decimal> WithFile { get; set; }
		}
		public interface IChartsNotesModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
			public ChartsNotesDiffsModel Diffs { get; set; }
		}
		public class ChartsNotesModel: IChartsNotesModel
		{
			public List<decimal> Total { get; set; }
			public List<decimal> Inc { get; set; }
			public List<decimal> Dec { get; set; }
			public ChartsNotesDiffsModel Diffs { get; set; }
		}
		public async Task<Response<ChartsPvGetModel>> PvGet(ChartsUserPvPropertiesSpanEnum span,string userId,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
				{ "userId", userId },
			};
			var result = await _app.Request<ChartsPvGetModel>(
				"charts/user/pv", 
				param, 
				needToken: false
			);
			return result;
		}

		public enum ChartsUserPvPropertiesSpanEnum {
			[EnumMember(Value = "day")]
			Day,
			[EnumMember(Value = "hour")]
			Hour,
		}
		public interface IChartsPvGetUpvModel
		{
			public List<decimal> User { get; set; }
			public List<decimal> Visitor { get; set; }
		}
		public class ChartsPvGetUpvModel: IChartsPvGetUpvModel
		{
			public List<decimal> User { get; set; }
			public List<decimal> Visitor { get; set; }
		}
		public interface IChartsPvGetPvModel
		{
			public List<decimal> User { get; set; }
			public List<decimal> Visitor { get; set; }
		}
		public class ChartsPvGetPvModel: IChartsPvGetPvModel
		{
			public List<decimal> User { get; set; }
			public List<decimal> Visitor { get; set; }
		}
		public interface IChartsPvGetModel
		{
			public ChartsPvGetUpvModel Upv { get; set; }
			public ChartsPvGetPvModel Pv { get; set; }
		}
		public class ChartsPvGetModel: IChartsPvGetModel
		{
			public ChartsPvGetUpvModel Upv { get; set; }
			public ChartsPvGetPvModel Pv { get; set; }
		}
		public async Task<Response<ChartsPvModel>> Pv(ChartsUserPvPropertiesSpanEnum span,string userId,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
				{ "userId", userId },
			};
			var result = await _app.Request<ChartsPvModel>(
				"charts/user/pv", 
				param, 
				needToken: false
			);
			return result;
		}
		public interface IChartsPvUpvModel
		{
			public List<decimal> User { get; set; }
			public List<decimal> Visitor { get; set; }
		}
		public class ChartsPvUpvModel: IChartsPvUpvModel
		{
			public List<decimal> User { get; set; }
			public List<decimal> Visitor { get; set; }
		}
		public interface IChartsPvPvModel
		{
			public List<decimal> User { get; set; }
			public List<decimal> Visitor { get; set; }
		}
		public class ChartsPvPvModel: IChartsPvPvModel
		{
			public List<decimal> User { get; set; }
			public List<decimal> Visitor { get; set; }
		}
		public interface IChartsPvModel
		{
			public ChartsPvUpvModel Upv { get; set; }
			public ChartsPvPvModel Pv { get; set; }
		}
		public class ChartsPvModel: IChartsPvModel
		{
			public ChartsPvUpvModel Upv { get; set; }
			public ChartsPvPvModel Pv { get; set; }
		}
		public async Task<Response<ChartsReactionsGetModel>> ReactionsGet(ChartsUserReactionsPropertiesSpanEnum span,string userId,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
				{ "userId", userId },
			};
			var result = await _app.Request<ChartsReactionsGetModel>(
				"charts/user/reactions", 
				param, 
				needToken: false
			);
			return result;
		}

		public enum ChartsUserReactionsPropertiesSpanEnum {
			[EnumMember(Value = "day")]
			Day,
			[EnumMember(Value = "hour")]
			Hour,
		}
		public interface IChartsReactionsGetLocalModel
		{
			public List<decimal> Count { get; set; }
		}
		public class ChartsReactionsGetLocalModel: IChartsReactionsGetLocalModel
		{
			public List<decimal> Count { get; set; }
		}
		public interface IChartsReactionsGetRemoteModel
		{
			public List<decimal> Count { get; set; }
		}
		public class ChartsReactionsGetRemoteModel: IChartsReactionsGetRemoteModel
		{
			public List<decimal> Count { get; set; }
		}
		public interface IChartsReactionsGetModel
		{
			public ChartsReactionsGetLocalModel Local { get; set; }
			public ChartsReactionsGetRemoteModel Remote { get; set; }
		}
		public class ChartsReactionsGetModel: IChartsReactionsGetModel
		{
			public ChartsReactionsGetLocalModel Local { get; set; }
			public ChartsReactionsGetRemoteModel Remote { get; set; }
		}
		public async Task<Response<ChartsReactionsModel>> Reactions(ChartsUserReactionsPropertiesSpanEnum span,string userId,int limit = 30,int? offset = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "span", span },
				{ "limit", limit },
				{ "offset", offset },
				{ "userId", userId },
			};
			var result = await _app.Request<ChartsReactionsModel>(
				"charts/user/reactions", 
				param, 
				needToken: false
			);
			return result;
		}
		public interface IChartsReactionsLocalModel
		{
			public List<decimal> Count { get; set; }
		}
		public class ChartsReactionsLocalModel: IChartsReactionsLocalModel
		{
			public List<decimal> Count { get; set; }
		}
		public interface IChartsReactionsRemoteModel
		{
			public List<decimal> Count { get; set; }
		}
		public class ChartsReactionsRemoteModel: IChartsReactionsRemoteModel
		{
			public List<decimal> Count { get; set; }
		}
		public interface IChartsReactionsModel
		{
			public ChartsReactionsLocalModel Local { get; set; }
			public ChartsReactionsRemoteModel Remote { get; set; }
		}
		public class ChartsReactionsModel: IChartsReactionsModel
		{
			public ChartsReactionsLocalModel Local { get; set; }
			public ChartsReactionsRemoteModel Remote { get; set; }
		}
	}
}
