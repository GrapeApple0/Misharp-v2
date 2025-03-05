using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class FetchExternalResourcesApi
	{
		private readonly App _app;
		public async Task<Response<PostFetchExternalResourcesModel>> FetchExternalResources(string url,string hash)
		{
			var param = new Dictionary<string, object?>
			{
				{ "url", url },
				{ "hash", hash },
			};
			var result = await _app.Request<PostFetchExternalResourcesModel>(
				"fetch-external-resources", 
				param, 
				needToken: true
			);
			return result;
		}

		public interface IPostFetchExternalResourcesModel
		{
			public string Type { get; set; }
			public string Data { get; set; }
		}
		public class PostFetchExternalResourcesModel: IPostFetchExternalResourcesModel
		{
			public string Type { get; set; }
			public string Data { get; set; }
		}
		public FetchExternalResourcesApi(App app)
		{
			this._app = app;
		}
	}
}
