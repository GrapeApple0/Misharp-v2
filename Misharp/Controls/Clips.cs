using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class ClipsApi
	{
		private readonly App _app;
		public async Task<Response<EmptyResponse>> AddNote(string clipId,string noteId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "clipId", clipId },
				{ "noteId", noteId },
			};
			var result = await _app.Request<EmptyResponse>(
				"clips/add-note", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<ClipModel>> Create(string name,bool isPublic = false,string? description = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "name", name },
				{ "isPublic", isPublic },
				{ "description", description },
			};
			var result = await _app.Request<ClipModel>(
				"clips/create", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Delete(string clipId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "clipId", clipId },
			};
			var result = await _app.Request<EmptyResponse>(
				"clips/delete", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Favorite(string clipId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "clipId", clipId },
			};
			var result = await _app.Request<EmptyResponse>(
				"clips/favorite", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<ClipModel>>> List()
		{
			var result = await _app.Request<List<ClipModel>>(
				"clips/list", 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<ClipModel>>> MyFavorites()
		{
			var result = await _app.Request<List<ClipModel>>(
				"clips/my-favorites", 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<NoteModel>>> Notes(string clipId,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "clipId", clipId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<NoteModel>>(
				"clips/notes", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> RemoveNote(string clipId,string noteId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "clipId", clipId },
				{ "noteId", noteId },
			};
			var result = await _app.Request<EmptyResponse>(
				"clips/remove-note", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<ClipModel>> Show(string clipId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "clipId", clipId },
			};
			var result = await _app.Request<ClipModel>(
				"clips/show", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Unfavorite(string clipId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "clipId", clipId },
			};
			var result = await _app.Request<EmptyResponse>(
				"clips/unfavorite", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<ClipModel>> Update(string clipId,string name,bool isPublic,string? description = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "clipId", clipId },
				{ "name", name },
				{ "isPublic", isPublic },
				{ "description", description },
			};
			var result = await _app.Request<ClipModel>(
				"clips/update", 
				param, 
				needToken: true
			);
			return result;
		}

		public ClipsApi(App app)
		{
			this._app = app;
		}
	}
}
