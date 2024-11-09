using Misharp.Models;
using System.Text.Json;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class GalleryApi
	{
		private readonly App _app;
		public async Task<Response<List<GalleryPostModel>>> Featured(int limit = 10,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<GalleryPostModel>>(
				"gallery/featured", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<GalleryPostModel>>> Popular()
		{
			var result = await _app.Request<List<GalleryPostModel>>(
				"gallery/popular", 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<GalleryPostModel>>> Posts(int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<GalleryPostModel>>(
				"gallery/posts", 
				param, 
				needToken: false
			);
			return result;
		}

		public readonly Gallery.PostsApi PostsApi;
		public GalleryApi(App app)
		{
			this._app = app;
			this.PostsApi = new Gallery.PostsApi(this._app);
		}
	}
}
namespace Misharp.Controls.Gallery
{
	public class PostsApi
	{
		private readonly App _app;
		public PostsApi(App app)
		{
			this._app = app;
		}
		public async Task<Response<GalleryPostModel>> Create(string title,string? description = null,List<string>? fileIds = null,bool isSensitive = false)
		{
			var param = new Dictionary<string, object?>
			{
				{ "title", title },
				{ "description", description },
				{ "fileIds", fileIds },
				{ "isSensitive", isSensitive },
			};
			var result = await _app.Request<GalleryPostModel>(
				"gallery/posts/create", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Delete(string postId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "postId", postId },
			};
			var result = await _app.Request<EmptyResponse>(
				"gallery/posts/delete", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Like(string postId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "postId", postId },
			};
			var result = await _app.Request<EmptyResponse>(
				"gallery/posts/like", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<GalleryPostModel>> Show(string postId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "postId", postId },
			};
			var result = await _app.Request<GalleryPostModel>(
				"gallery/posts/show", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Unlike(string postId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "postId", postId },
			};
			var result = await _app.Request<EmptyResponse>(
				"gallery/posts/unlike", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<GalleryPostModel>> Update(string postId,string title,string? description = null,List<string>? fileIds = null,bool isSensitive = false)
		{
			var param = new Dictionary<string, object?>
			{
				{ "postId", postId },
				{ "title", title },
				{ "description", description },
				{ "fileIds", fileIds },
				{ "isSensitive", isSensitive },
			};
			var result = await _app.Request<GalleryPostModel>(
				"gallery/posts/update", 
				param, 
				needToken: true
			);
			return result;
		}

	}
}
