using Misharp.Models;
using System.Text.Json;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class PinnedUsersApi
	{
		private readonly App _app;
		public async Task<Response<List<UserDetailedModel>>> PinnedUsers()
		{
			var result = await _app.Request<List<UserDetailedModel>>(
				"pinned-users", 
				needToken: false
			);
			return result;
		}

		public PinnedUsersApi(App app)
		{
			this._app = app;
		}
	}
}
