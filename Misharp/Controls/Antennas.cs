using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class AntennasApi
	{
		private readonly App _app;
		public async Task<Response<AntennaModel>> Create(string name,AntennasCreatePropertiesSrcEnum src,bool caseSensitive,bool localOnly,bool excludeBots,bool withReplies,bool withFile,string? userListId = null,List<List<List<string>>>? keywords = null,List<List<List<string>>>? excludeKeywords = null,List<string>? users = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "name", name },
				{ "src", src },
				{ "userListId", userListId },
				{ "keywords", keywords },
				{ "excludeKeywords", excludeKeywords },
				{ "users", users },
				{ "caseSensitive", caseSensitive },
				{ "localOnly", localOnly },
				{ "excludeBots", excludeBots },
				{ "withReplies", withReplies },
				{ "withFile", withFile },
			};
			var result = await _app.Request<AntennaModel>(
				"antennas/create", 
				param, 
				needToken: true
			);
			return result;
		}

		public enum AntennasCreatePropertiesSrcEnum {
			[EnumMember(Value = "home")]
			Home,
			[EnumMember(Value = "all")]
			All,
			[EnumMember(Value = "users")]
			Users,
			[EnumMember(Value = "list")]
			List,
			[EnumMember(Value = "users_blacklist")]
			UsersBlacklist,
		}
		public async Task<Response<EmptyResponse>> Delete(string antennaId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "antennaId", antennaId },
			};
			var result = await _app.Request<EmptyResponse>(
				"antennas/delete", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<AntennaModel>>> List()
		{
			var result = await _app.Request<List<AntennaModel>>(
				"antennas/list", 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<NoteModel>>> Notes(string antennaId,int limit = 10,string? sinceId = null,string? untilId = null,int? sinceDate = null,int? untilDate = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "antennaId", antennaId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "sinceDate", sinceDate },
				{ "untilDate", untilDate },
			};
			var result = await _app.Request<List<NoteModel>>(
				"antennas/notes", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<AntennaModel>> Show(string antennaId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "antennaId", antennaId },
			};
			var result = await _app.Request<AntennaModel>(
				"antennas/show", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<AntennaModel>> Update(string antennaId,string name,AntennasUpdatePropertiesSrcEnum src,bool caseSensitive,bool localOnly,bool excludeBots,bool withReplies,bool withFile,string? userListId = null,List<List<List<string>>>? keywords = null,List<List<List<string>>>? excludeKeywords = null,List<string>? users = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "antennaId", antennaId },
				{ "name", name },
				{ "src", src },
				{ "userListId", userListId },
				{ "keywords", keywords },
				{ "excludeKeywords", excludeKeywords },
				{ "users", users },
				{ "caseSensitive", caseSensitive },
				{ "localOnly", localOnly },
				{ "excludeBots", excludeBots },
				{ "withReplies", withReplies },
				{ "withFile", withFile },
			};
			var result = await _app.Request<AntennaModel>(
				"antennas/update", 
				param, 
				needToken: true
			);
			return result;
		}

		public enum AntennasUpdatePropertiesSrcEnum {
			[EnumMember(Value = "home")]
			Home,
			[EnumMember(Value = "all")]
			All,
			[EnumMember(Value = "users")]
			Users,
			[EnumMember(Value = "list")]
			List,
			[EnumMember(Value = "users_blacklist")]
			UsersBlacklist,
		}
		public AntennasApi(App app)
		{
			this._app = app;
		}
	}
}
