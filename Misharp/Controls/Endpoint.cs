using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class EndpointApi
	{
		private readonly App _app;
		public async Task<Response<PostEndpointModel>> Endpoint(string endpoint)
		{
			var param = new Dictionary<string, object?>
			{
				{ "endpoint", endpoint },
			};
			var result = await _app.Request<PostEndpointModel>(
				"endpoint", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IPostEndpointParamsItemsModel
		{
			public string Name { get; set; }
			public string Type { get; set; }
		}
		public class PostEndpointParamsItemsModel: IPostEndpointParamsItemsModel
		{
			public string Name { get; set; }
			public string Type { get; set; }
		}
		public interface IPostEndpointModel
		{
			public List<PostEndpointParamsItemsModel> Params { get; set; }
		}
		public class PostEndpointModel: IPostEndpointModel
		{
			public List<PostEndpointParamsItemsModel> Params { get; set; }
		}
		public EndpointApi(App app)
		{
			this._app = app;
		}
	}
}
