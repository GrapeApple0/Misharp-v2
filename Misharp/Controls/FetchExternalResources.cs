using Misharp.Models;
using System.Text.Json;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class FetchExternalResourcesApi
	{
		private readonly App _app;
		public async Task<Response<FetchExternalResourcesFetchExternalResourcesModel>> FetchExternalResources(string url,string hash)
		{
			var param = new Dictionary<string, object?>
			{
				{ "url", url },
				{ "hash", hash },
			};
			var result = await _app.Request<FetchExternalResourcesFetchExternalResourcesModel>(
				"fetch-external-resources", 
				param, 
				needToken: true
			);
			return result;
		}

		public interface IFetchExternalResourcesFetchExternalResourcesModel
		{
			public string Type { get; set; }
			public string Data { get; set; }
		}
		public class FetchExternalResourcesFetchExternalResourcesModel: IFetchExternalResourcesFetchExternalResourcesModel
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
