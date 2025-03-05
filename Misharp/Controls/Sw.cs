using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class SwApi
	{
		private readonly App _app;
		public async Task<Response<PostRegisterModel>> Register(string endpoint,string auth,string publickey,bool sendReadMessage = false)
		{
			var param = new Dictionary<string, object?>
			{
				{ "endpoint", endpoint },
				{ "auth", auth },
				{ "publickey", publickey },
				{ "sendReadMessage", sendReadMessage },
			};
			var result = await _app.Request<PostRegisterModel>(
				"sw/register", 
				param, 
				needToken: true
			);
			return result;
		}

		public enum PostRegisterStateEnum {
			[EnumMember(Value = "already-subscribed")]
			AlreadySubscribed,
			[EnumMember(Value = "subscribed")]
			Subscribed,
		}
		public interface IPostRegisterModel
		{
			public PostRegisterStateEnum State { get; set; }
			public string? Key { get; set; }
			public string UserId { get; set; }
			public string Endpoint { get; set; }
			public bool SendReadMessage { get; set; }
		}
		public class PostRegisterModel: IPostRegisterModel
		{
			public PostRegisterStateEnum State { get; set; }
			public string? Key { get; set; }
			public string UserId { get; set; }
			public string Endpoint { get; set; }
			public bool SendReadMessage { get; set; }
		}
		public async Task<Response<PostShowRegistrationModel>> ShowRegistration(string endpoint)
		{
			var param = new Dictionary<string, object?>
			{
				{ "endpoint", endpoint },
			};
			var result = await _app.Request<PostShowRegistrationModel>(
				"sw/show-registration", 
				param, 
				needToken: true
			);
			return result;
		}

		public interface IPostShowRegistrationModel
		{
			public string UserId { get; set; }
			public string Endpoint { get; set; }
			public bool SendReadMessage { get; set; }
		}
		public class PostShowRegistrationModel: IPostShowRegistrationModel
		{
			public string UserId { get; set; }
			public string Endpoint { get; set; }
			public bool SendReadMessage { get; set; }
		}
		public async Task<Response<EmptyResponse>> Unregister(string endpoint)
		{
			var param = new Dictionary<string, object?>
			{
				{ "endpoint", endpoint },
			};
			var result = await _app.Request<EmptyResponse>(
				"sw/unregister", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<PostUpdateRegistrationModel>> UpdateRegistration(string endpoint,bool sendReadMessage)
		{
			var param = new Dictionary<string, object?>
			{
				{ "endpoint", endpoint },
				{ "sendReadMessage", sendReadMessage },
			};
			var result = await _app.Request<PostUpdateRegistrationModel>(
				"sw/update-registration", 
				param, 
				needToken: true
			);
			return result;
		}

		public interface IPostUpdateRegistrationModel
		{
			public string UserId { get; set; }
			public string Endpoint { get; set; }
			public bool SendReadMessage { get; set; }
		}
		public class PostUpdateRegistrationModel: IPostUpdateRegistrationModel
		{
			public string UserId { get; set; }
			public string Endpoint { get; set; }
			public bool SendReadMessage { get; set; }
		}
		public SwApi(App app)
		{
			this._app = app;
		}
	}
}
