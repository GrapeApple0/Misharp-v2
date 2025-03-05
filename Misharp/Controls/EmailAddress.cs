using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class EmailAddressApi
	{
		private readonly App _app;
		public async Task<Response<PostAvailableModel>> Available(string emailAddress)
		{
			var param = new Dictionary<string, object?>
			{
				{ "emailAddress", emailAddress },
			};
			var result = await _app.Request<PostAvailableModel>(
				"email-address/available", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IPostAvailableModel
		{
			public bool Available { get; set; }
			public string? Reason { get; set; }
		}
		public class PostAvailableModel: IPostAvailableModel
		{
			public bool Available { get; set; }
			public string? Reason { get; set; }
		}
		public EmailAddressApi(App app)
		{
			this._app = app;
		}
	}
}
