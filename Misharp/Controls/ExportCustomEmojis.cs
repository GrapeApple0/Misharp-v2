using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class ExportCustomEmojisApi
	{
		private readonly App _app;
		public async Task<Response<EmptyResponse>> ExportCustomEmojis()
		{
			var result = await _app.Request<EmptyResponse>(
				"export-custom-emojis", 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public ExportCustomEmojisApi(App app)
		{
			this._app = app;
		}
	}
}
