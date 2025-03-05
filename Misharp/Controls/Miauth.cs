using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class MiauthApi
	{
		private readonly App _app;
		public async Task<Response<PostGenTokenModel>> GenToken(string? session = null,string? name = null,string? description = null,string? iconUrl = null,List<string>? permission = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "session", session },
				{ "name", name },
				{ "description", description },
				{ "iconUrl", iconUrl },
				{ "permission", permission },
			};
			var result = await _app.Request<PostGenTokenModel>(
				"miauth/gen-token", 
				param, 
				needToken: true
			);
			return result;
		}

		public interface IPostGenTokenModel
		{
			public string Token { get; set; }
		}
		public class PostGenTokenModel: IPostGenTokenModel
		{
			public string Token { get; set; }
		}
		public MiauthApi(App app)
		{
			this._app = app;
		}
	}
}
