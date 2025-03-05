using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class PingApi
	{
		private readonly App _app;
		public async Task<Response<PostPingModel>> Ping()
		{
			var result = await _app.Request<PostPingModel>(
				"ping", 
				needToken: false
			);
			return result;
		}

		public interface IPostPingModel
		{
			public decimal Pong { get; set; }
		}
		public class PostPingModel: IPostPingModel
		{
			public decimal Pong { get; set; }
		}
		public PingApi(App app)
		{
			this._app = app;
		}
	}
}
