using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class PingApi
	{
		private readonly App _app;
		public async Task<Response<PingPingModel>> Ping()
		{
			var result = await _app.Request<PingPingModel>(
				"ping", 
				needToken: false
			);
			return result;
		}

		public interface IPingPingModel
		{
			public decimal Pong { get; set; }
		}
		public class PingPingModel: IPingPingModel
		{
			public decimal Pong { get; set; }
		}
		public PingApi(App app)
		{
			this._app = app;
		}
	}
}
