using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class RequestResetPasswordApi
	{
		private readonly App _app;
		public async Task<Response<EmptyResponse>> RequestResetPassword(string username,string email)
		{
			var param = new Dictionary<string, object?>
			{
				{ "username", username },
				{ "email", email },
			};
			var result = await _app.Request<EmptyResponse>(
				"request-reset-password", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: false
			);
			return result;
		}

		public RequestResetPasswordApi(App app)
		{
			this._app = app;
		}
	}
}
