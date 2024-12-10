using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class RetentionApi
	{
		private readonly App _app;
		public async Task<Response<List<RetentionRetentionGetItemsModel>>> RetentionGet()
		{
			var result = await _app.Request<List<RetentionRetentionGetItemsModel>>(
				"retention", 
				needToken: false
			);
			return result;
		}

		public interface IRetentionRetentionGetItemsModel
		{
			public DateTime? CreatedAt { get; set; }
			public decimal Users { get; set; }
			public Dictionary<string, decimal> Data { get; set; }
		}
		public class RetentionRetentionGetItemsModel: IRetentionRetentionGetItemsModel
		{
			public DateTime? CreatedAt { get; set; }
			public decimal Users { get; set; }
			public Dictionary<string, decimal> Data { get; set; }
		}
		public async Task<Response<List<RetentionRetentionItemsModel>>> Retention()
		{
			var result = await _app.Request<List<RetentionRetentionItemsModel>>(
				"retention", 
				needToken: false
			);
			return result;
		}

		public interface IRetentionRetentionItemsModel
		{
			public DateTime? CreatedAt { get; set; }
			public decimal Users { get; set; }
			public Dictionary<string, decimal> Data { get; set; }
		}
		public class RetentionRetentionItemsModel: IRetentionRetentionItemsModel
		{
			public DateTime? CreatedAt { get; set; }
			public decimal Users { get; set; }
			public Dictionary<string, decimal> Data { get; set; }
		}
		public RetentionApi(App app)
		{
			this._app = app;
		}
	}
}
