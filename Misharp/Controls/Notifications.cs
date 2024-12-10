using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class NotificationsApi
	{
		private readonly App _app;
		public async Task<Response<EmptyResponse>> Create(string body,string? header = null,string? icon = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "body", body },
				{ "header", header },
				{ "icon", icon },
			};
			var result = await _app.Request<EmptyResponse>(
				"notifications/create", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Flush()
		{
			var result = await _app.Request<EmptyResponse>(
				"notifications/flush", 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> MarkAllAsRead()
		{
			var result = await _app.Request<EmptyResponse>(
				"notifications/mark-all-as-read", 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> TestNotification()
		{
			var result = await _app.Request<EmptyResponse>(
				"notifications/test-notification", 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public NotificationsApi(App app)
		{
			this._app = app;
		}
	}
}
