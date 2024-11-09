using Misharp.Models;
using System.Text.Json;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class MyApi
	{
		private readonly App _app;
		public async Task<Response<List<AppModel>>> Apps(int limit = 10,int offset = 0)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "offset", offset },
			};
			var result = await _app.Request<List<AppModel>>(
				"my/apps", 
				param, 
				needToken: true
			);
			return result;
		}

		public MyApi(App app)
		{
			this._app = app;
		}
	}
}
