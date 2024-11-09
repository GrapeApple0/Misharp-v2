using Misharp.Models;
using System.Text.Json;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class EndpointsApi
	{
		private readonly App _app;
		public async Task<Response<List<string>>> Endpoints()
		{
			var result = await _app.Request<List<string>>(
				"endpoints", 
				needToken: false
			);
			return result;
		}

		public EndpointsApi(App app)
		{
			this._app = app;
		}
	}
}
