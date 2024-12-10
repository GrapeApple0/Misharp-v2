using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class GetOnlineUsersCountApi
	{
		private readonly App _app;
		public async Task<Response<GetOnlineUsersCountGetOnlineUsersCountGetModel>> GetOnlineUsersCountGet()
		{
			var result = await _app.Request<GetOnlineUsersCountGetOnlineUsersCountGetModel>(
				"get-online-users-count", 
				needToken: false
			);
			return result;
		}

		public interface IGetOnlineUsersCountGetOnlineUsersCountGetModel
		{
			public decimal Count { get; set; }
		}
		public class GetOnlineUsersCountGetOnlineUsersCountGetModel: IGetOnlineUsersCountGetOnlineUsersCountGetModel
		{
			public decimal Count { get; set; }
		}
		public async Task<Response<GetOnlineUsersCountGetOnlineUsersCountModel>> GetOnlineUsersCount()
		{
			var result = await _app.Request<GetOnlineUsersCountGetOnlineUsersCountModel>(
				"get-online-users-count", 
				needToken: false
			);
			return result;
		}

		public interface IGetOnlineUsersCountGetOnlineUsersCountModel
		{
			public decimal Count { get; set; }
		}
		public class GetOnlineUsersCountGetOnlineUsersCountModel: IGetOnlineUsersCountGetOnlineUsersCountModel
		{
			public decimal Count { get; set; }
		}
		public GetOnlineUsersCountApi(App app)
		{
			this._app = app;
		}
	}
}
