using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class RetentionApi
	{
		private readonly App _app;
		public async Task<Response<List<GetRetentionGetItemsModel>>> RetentionGet()
		{
			var result = await _app.Request<List<GetRetentionGetItemsModel>>(
				"retention", 
				needToken: false
			);
			return result;
		}

		public interface IGetRetentionGetItemsModel
		{
			public DateTime? CreatedAt { get; set; }
			public decimal Users { get; set; }
			public Dictionary<string, decimal> Data { get; set; }
		}
		public class GetRetentionGetItemsModel: IGetRetentionGetItemsModel
		{
			public DateTime? CreatedAt { get; set; }
			public decimal Users { get; set; }
			public Dictionary<string, decimal> Data { get; set; }
		}
		public async Task<Response<List<PostRetentionItemsModel>>> Retention()
		{
			var result = await _app.Request<List<PostRetentionItemsModel>>(
				"retention", 
				needToken: false
			);
			return result;
		}

		public interface IPostRetentionItemsModel
		{
			public DateTime? CreatedAt { get; set; }
			public decimal Users { get; set; }
			public Dictionary<string, decimal> Data { get; set; }
		}
		public class PostRetentionItemsModel: IPostRetentionItemsModel
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
