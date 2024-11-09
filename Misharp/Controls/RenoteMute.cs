using Misharp.Models;
using System.Text.Json;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class RenoteMuteApi
	{
		private readonly App _app;
		public async Task<Response<EmptyResponse>> Create(string userId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
			};
			var result = await _app.Request<EmptyResponse>(
				"renote-mute/create", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Delete(string userId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "userId", userId },
			};
			var result = await _app.Request<EmptyResponse>(
				"renote-mute/delete", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<RenoteMutingModel>>> List(int limit = 30,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<RenoteMutingModel>>(
				"renote-mute/list", 
				param, 
				needToken: true
			);
			return result;
		}

		public RenoteMuteApi(App app)
		{
			this._app = app;
		}
	}
}
