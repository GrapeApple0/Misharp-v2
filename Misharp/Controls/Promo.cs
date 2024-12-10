using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class PromoApi
	{
		private readonly App _app;
		public async Task<Response<EmptyResponse>> Read(string noteId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<EmptyResponse>(
				"promo/read", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public PromoApi(App app)
		{
			this._app = app;
		}
	}
}
