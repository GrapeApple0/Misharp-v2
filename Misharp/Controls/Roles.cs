using Misharp.Models;
using System.Text.Json;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class RolesApi
	{
		private readonly App _app;
		public async Task<Response<List<RoleModel>>> List()
		{
			var result = await _app.Request<List<RoleModel>>(
				"roles/list", 
				needToken: true
			);
			return result;
		}

		public async Task<Response<RoleModel>> Show(string roleId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "roleId", roleId },
			};
			var result = await _app.Request<RoleModel>(
				"roles/show", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<RolesUsersItemsModel>>> Users(string roleId,string? sinceId = null,string? untilId = null,int limit = 10)
		{
			var param = new Dictionary<string, object?>
			{
				{ "roleId", roleId },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<RolesUsersItemsModel>>(
				"roles/users", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IRolesUsersItemsModel
		{
			public string Id { get; set; }
			public UserDetailedModel User { get; set; }
		}
		public class RolesUsersItemsModel: IRolesUsersItemsModel
		{
			public string Id { get; set; }
			public UserDetailedModel User { get; set; }
		}
		public async Task<Response<List<NoteModel>>> Notes(string roleId,int limit = 10,string? sinceId = null,string? untilId = null,int? sinceDate = null,int? untilDate = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "roleId", roleId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "sinceDate", sinceDate },
				{ "untilDate", untilDate },
			};
			var result = await _app.Request<List<NoteModel>>(
				"roles/notes", 
				param, 
				needToken: true
			);
			return result;
		}

		public RolesApi(App app)
		{
			this._app = app;
		}
	}
}
