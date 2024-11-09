using Misharp.Models;
using System.Text.Json;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class BlockingApi
	{
		private readonly App _app;
		public async Task<Response<UserDetailedNotMeModel>> Create(string userId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
			};
			var result = await _app.Request<UserDetailedNotMeModel>(
				"blocking/create", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<UserDetailedNotMeModel>> Delete(string userId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
			};
			var result = await _app.Request<UserDetailedNotMeModel>(
				"blocking/delete", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<BlockingModel>>> List(int limit = 30,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<BlockingModel>>(
				"blocking/list", 
				param, 
				needToken: true
			);
			return result;
		}

		public BlockingApi(App app)
		{
			this._app = app;
		}
	}
}
