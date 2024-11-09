using Misharp.Models;
using System.Text.Json;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class SwApi
	{
		private readonly App _app;
		public async Task<Response<SwShowRegistrationModel>> ShowRegistration(string endpoint)
		{
			var param = new Dictionary<string, object?>
			{
				{ "endpoint", endpoint },
			};
			var result = await _app.Request<SwShowRegistrationModel>(
				"sw/show-registration", 
				param, 
				needToken: true
			);
			return result;
		}

		public interface ISwShowRegistrationModel
		{
			public string UserId { get; set; }
			public string Endpoint { get; set; }
			public bool SendReadMessage { get; set; }
		}
		public class SwShowRegistrationModel: ISwShowRegistrationModel
		{
			public string UserId { get; set; }
			public string Endpoint { get; set; }
			public bool SendReadMessage { get; set; }
		}
		public async Task<Response<SwUpdateRegistrationModel>> UpdateRegistration(string endpoint,bool sendReadMessage)
		{
			var param = new Dictionary<string, object?>
			{
				{ "endpoint", endpoint },
				{ "sendReadMessage", sendReadMessage },
			};
			var result = await _app.Request<SwUpdateRegistrationModel>(
				"sw/update-registration", 
				param, 
				needToken: true
			);
			return result;
		}

		public interface ISwUpdateRegistrationModel
		{
			public string UserId { get; set; }
			public string Endpoint { get; set; }
			public bool SendReadMessage { get; set; }
		}
		public class SwUpdateRegistrationModel: ISwUpdateRegistrationModel
		{
			public string UserId { get; set; }
			public string Endpoint { get; set; }
			public bool SendReadMessage { get; set; }
		}
		public async Task<Response<SwRegisterModel>> Register(string endpoint,string auth,string publickey,bool sendReadMessage = false)
		{
			var param = new Dictionary<string, object?>
			{
				{ "endpoint", endpoint },
				{ "auth", auth },
				{ "publickey", publickey },
				{ "sendReadMessage", sendReadMessage },
			};
			var result = await _app.Request<SwRegisterModel>(
				"sw/register", 
				param, 
				needToken: true
			);
			return result;
		}

		public enum SwRegisterStateEnum {
			[EnumMember(Value = "already-subscribed")]
			AlreadySubscribed,
			[EnumMember(Value = "subscribed")]
			Subscribed,
		}
		public interface ISwRegisterModel
		{
			public SwRegisterStateEnum State { get; set; }
			public string? Key { get; set; }
			public string UserId { get; set; }
			public string Endpoint { get; set; }
			public bool SendReadMessage { get; set; }
		}
		public class SwRegisterModel: ISwRegisterModel
		{
			public SwRegisterStateEnum State { get; set; }
			public string? Key { get; set; }
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

		public SwApi(App app)
		{
			this._app = app;
		}
	}
}
