using Misharp.Models;
using System.Text.Json;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class AuthApi
	{
		private readonly App _app;
		public async Task<Response<EmptyResponse>> Accept(string token)
		{
			var param = new Dictionary<string, object?>
			{
				{ "token", token },
			};
			var result = await _app.Request<EmptyResponse>(
				"auth/accept", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public readonly Auth.SessionApi SessionApi;
		public AuthApi(App app)
		{
			this._app = app;
			this.SessionApi = new Auth.SessionApi(this._app);
		}
	}
}
namespace Misharp.Controls.Auth
{
	public class SessionApi
	{
		private readonly App _app;
		public SessionApi(App app)
		{
			this._app = app;
		}
		public async Task<Response<AuthGenerateModel>> Generate(string appSecret)
		{
			var param = new Dictionary<string, object?>
			{
				{ "appSecret", appSecret },
			};
			var result = await _app.Request<AuthGenerateModel>(
				"auth/session/generate", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IAuthGenerateModel
		{
			public string Token { get; set; }
			public Uri Url { get; set; }
		}
		public class AuthGenerateModel: IAuthGenerateModel
		{
			public string Token { get; set; }
			public Uri Url { get; set; }
		}
		public async Task<Response<AuthShowModel>> Show(string token)
		{
			var param = new Dictionary<string, object?>
			{
				{ "token", token },
			};
			var result = await _app.Request<AuthShowModel>(
				"auth/session/show", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IAuthShowModel
		{
			public string Id { get; set; }
			public AppModel App { get; set; }
			public string Token { get; set; }
		}
		public class AuthShowModel: IAuthShowModel
		{
			public string Id { get; set; }
			public AppModel App { get; set; }
			public string Token { get; set; }
		}
		public async Task<Response<AuthUserkeyModel>> Userkey(string appSecret,string token)
		{
			var param = new Dictionary<string, object?>
			{
				{ "appSecret", appSecret },
				{ "token", token },
			};
			var result = await _app.Request<AuthUserkeyModel>(
				"auth/session/userkey", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IAuthUserkeyModel
		{
			public string AccessToken { get; set; }
			public UserDetailedNotMeModel User { get; set; }
		}
		public class AuthUserkeyModel: IAuthUserkeyModel
		{
			public string AccessToken { get; set; }
			public UserDetailedNotMeModel User { get; set; }
		}
	}
}
