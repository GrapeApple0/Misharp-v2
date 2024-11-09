using Misharp.Models;
using System.Text.Json;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class UsernameApi
	{
		private readonly App _app;
		public async Task<Response<UsernameAvailableModel>> Available(string username)
		{
			var param = new Dictionary<string, object?>
			{
				{ "username", username },
			};
			var result = await _app.Request<UsernameAvailableModel>(
				"username/available", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IUsernameAvailableModel
		{
			public bool Available { get; set; }
		}
		public class UsernameAvailableModel: IUsernameAvailableModel
		{
			public bool Available { get; set; }
		}
		public UsernameApi(App app)
		{
			this._app = app;
		}
	}
}
