using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class UsernameApi
	{
		private readonly App _app;
		public async Task<Response<PostAvailableModel>> Available(string username)
		{
			var param = new Dictionary<string, object?>
			{
				{ "username", username },
			};
			var result = await _app.Request<PostAvailableModel>(
				"username/available", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IPostAvailableModel
		{
			public bool Available { get; set; }
		}
		public class PostAvailableModel: IPostAvailableModel
		{
			public bool Available { get; set; }
		}
		public UsernameApi(App app)
		{
			this._app = app;
		}
	}
}
