using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class EndpointApi
	{
		private readonly App _app;
		public async Task<Response<EndpointEndpointModel>> Endpoint(string endpoint)
		{
			var param = new Dictionary<string, object?>
			{
				{ "endpoint", endpoint },
			};
			var result = await _app.Request<EndpointEndpointModel>(
				"endpoint", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IEndpointEndpointParamsItemsModel
		{
			public string Name { get; set; }
			public string Type { get; set; }
		}
		public class EndpointEndpointParamsItemsModel: IEndpointEndpointParamsItemsModel
		{
			public string Name { get; set; }
			public string Type { get; set; }
		}
		public interface IEndpointEndpointModel
		{
			public List<EndpointEndpointParamsItemsModel> Params { get; set; }
		}
		public class EndpointEndpointModel: IEndpointEndpointModel
		{
			public List<EndpointEndpointParamsItemsModel> Params { get; set; }
		}
		public EndpointApi(App app)
		{
			this._app = app;
		}
	}
}
