using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class StatsApi
	{
		private readonly App _app;
		public async Task<Response<StatsStatsModel>> Stats()
		{
			var result = await _app.Request<StatsStatsModel>(
				"stats", 
				needToken: false
			);
			return result;
		}

		public interface IStatsStatsModel
		{
			public decimal NotesCount { get; set; }
			public decimal OriginalNotesCount { get; set; }
			public decimal UsersCount { get; set; }
			public decimal OriginalUsersCount { get; set; }
			public decimal Instances { get; set; }
			public decimal DriveUsageLocal { get; set; }
			public decimal DriveUsageRemote { get; set; }
		}
		public class StatsStatsModel: IStatsStatsModel
		{
			public decimal NotesCount { get; set; }
			public decimal OriginalNotesCount { get; set; }
			public decimal UsersCount { get; set; }
			public decimal OriginalUsersCount { get; set; }
			public decimal Instances { get; set; }
			public decimal DriveUsageLocal { get; set; }
			public decimal DriveUsageRemote { get; set; }
		}
		public StatsApi(App app)
		{
			this._app = app;
		}
	}
}
