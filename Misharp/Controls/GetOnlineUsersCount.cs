using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class GetOnlineUsersCountApi
	{
		private readonly App _app;
		public async Task<Response<GetGetOnlineUsersCountGetModel>> GetOnlineUsersCountGet()
		{
			var result = await _app.Request<GetGetOnlineUsersCountGetModel>(
				"get-online-users-count", 
				needToken: false
			);
			return result;
		}

		public interface IGetGetOnlineUsersCountGetModel
		{
			public decimal Count { get; set; }
		}
		public class GetGetOnlineUsersCountGetModel: IGetGetOnlineUsersCountGetModel
		{
			public decimal Count { get; set; }
		}
		public async Task<Response<PostGetOnlineUsersCountModel>> GetOnlineUsersCount()
		{
			var result = await _app.Request<PostGetOnlineUsersCountModel>(
				"get-online-users-count", 
				needToken: false
			);
			return result;
		}

		public interface IPostGetOnlineUsersCountModel
		{
			public decimal Count { get; set; }
		}
		public class PostGetOnlineUsersCountModel: IPostGetOnlineUsersCountModel
		{
			public decimal Count { get; set; }
		}
		public GetOnlineUsersCountApi(App app)
		{
			this._app = app;
		}
	}
}
