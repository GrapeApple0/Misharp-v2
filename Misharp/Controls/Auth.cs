using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
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
		public async Task<Response<PostGenerateModel>> Generate(string appSecret)
		{
			var param = new Dictionary<string, object?>
			{
				{ "appSecret", appSecret },
			};
			var result = await _app.Request<PostGenerateModel>(
				"auth/session/generate", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IPostGenerateModel
		{
			public string Token { get; set; }
			public Uri Url { get; set; }
		}
		public class PostGenerateModel: IPostGenerateModel
		{
			public string Token { get; set; }
			public Uri Url { get; set; }
		}
		public async Task<Response<PostShowModel>> Show(string token)
		{
			var param = new Dictionary<string, object?>
			{
				{ "token", token },
			};
			var result = await _app.Request<PostShowModel>(
				"auth/session/show", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IPostShowModel
		{
			public string Id { get; set; }
			public AppModel App { get; set; }
			public string Token { get; set; }
		}
		public class PostShowModel: IPostShowModel
		{
			public string Id { get; set; }
			public AppModel App { get; set; }
			public string Token { get; set; }
		}
		public async Task<Response<PostUserkeyModel>> Userkey(string appSecret,string token)
		{
			var param = new Dictionary<string, object?>
			{
				{ "appSecret", appSecret },
				{ "token", token },
			};
			var result = await _app.Request<PostUserkeyModel>(
				"auth/session/userkey", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IPostUserkeyModel
		{
			public string AccessToken { get; set; }
			public UserDetailedNotMeModel User { get; set; }
		}
		public class PostUserkeyModel: IPostUserkeyModel
		{
			public string AccessToken { get; set; }
			public UserDetailedNotMeModel User { get; set; }
		}
	}
}
