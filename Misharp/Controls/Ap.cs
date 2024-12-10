using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class ApApi
	{
		private readonly App _app;
		public async Task<Response<JsonNode>> Get(string uri)
		{
			var param = new Dictionary<string, object?>
			{
				{ "uri", uri },
			};
			var result = await _app.Request<JsonNode>(
				"ap/get", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<object>> Show(string uri)
		{
			var param = new Dictionary<string, object?>
			{
				{ "uri", uri },
			};
			var result = await _app.Request<object>(
				"ap/show", 
				param, 
				needToken: true
			);
			return result;
		}

		public ApApi(App app)
		{
			this._app = app;
		}
	}
}
