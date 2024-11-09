using Misharp.Models;
using System.Text.Json;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class EmailAddressApi
	{
		private readonly App _app;
		public async Task<Response<EmailAddressAvailableModel>> Available(string emailAddress)
		{
			var param = new Dictionary<string, object?>
			{
				{ "emailAddress", emailAddress },
			};
			var result = await _app.Request<EmailAddressAvailableModel>(
				"email-address/available", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IEmailAddressAvailableModel
		{
			public bool Available { get; set; }
			public string? Reason { get; set; }
		}
		public class EmailAddressAvailableModel: IEmailAddressAvailableModel
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
