using Misharp.Models;
using System.Text.Json;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class AppApi
	{
		private readonly App _app;
		public async Task<Response<AppModel>> Create(string name,string description,List<string>? permission = null,string? callbackUrl = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "name", name },
				{ "description", description },
				{ "permission", permission },
				{ "callbackUrl", callbackUrl },
			};
			var result = await _app.Request<AppModel>(
				"app/create", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<AppModel>> Show(string appId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "appId", appId },
			};
			var result = await _app.Request<AppModel>(
				"app/show", 
				param, 
				needToken: false
			);
			return result;
		}

		public AppApi(App app)
		{
			this._app = app;
		}
	}
}
