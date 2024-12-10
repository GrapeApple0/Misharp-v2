using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class ResetPasswordApi
	{
		private readonly App _app;
		public async Task<Response<EmptyResponse>> ResetPassword(string token,string password)
		{
			var param = new Dictionary<string, object?>
			{
				{ "token", token },
				{ "password", password },
			};
			var result = await _app.Request<EmptyResponse>(
				"reset-password", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: false
			);
			return result;
		}

		public ResetPasswordApi(App app)
		{
			this._app = app;
		}
	}
}
