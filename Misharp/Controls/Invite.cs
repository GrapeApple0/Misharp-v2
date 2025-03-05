using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class InviteApi
	{
		private readonly App _app;
		public async Task<Response<InviteCodeModel>> Create()
		{
			var result = await _app.Request<InviteCodeModel>(
				"invite/create", 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Delete(string inviteId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "inviteId", inviteId },
			};
			var result = await _app.Request<EmptyResponse>(
				"invite/delete", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<PostLimitModel>> Limit()
		{
			var result = await _app.Request<PostLimitModel>(
				"invite/limit", 
				needToken: true
			);
			return result;
		}

		public interface IPostLimitModel
		{
			public int? Remaining { get; set; }
		}
		public class PostLimitModel: IPostLimitModel
		{
			public int? Remaining { get; set; }
		}
		public async Task<Response<List<InviteCodeModel>>> List(int limit = 30,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<InviteCodeModel>>(
				"invite/list", 
				param, 
				needToken: true
			);
			return result;
		}

		public InviteApi(App app)
		{
			this._app = app;
		}
	}
}
