using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class PagesApi
	{
		private readonly App _app;
		public async Task<Response<PageModel>> Create(string title,string name,string script,string? summary = null,JsonNode? content = null,JsonNode? variables = null,string? eyeCatchingImageId = null,PagesCreatePropertiesFontEnum font = PagesCreatePropertiesFontEnum.SansSerif,bool alignCenter = false,bool hideTitleWhenPinned = false)
		{
			var param = new Dictionary<string, object?>
			{
				{ "title", title },
				{ "name", name },
				{ "summary", summary },
				{ "content", content },
				{ "variables", variables },
				{ "script", script },
				{ "eyeCatchingImageId", eyeCatchingImageId },
				{ "font", font },
				{ "alignCenter", alignCenter },
				{ "hideTitleWhenPinned", hideTitleWhenPinned },
			};
			var result = await _app.Request<PageModel>(
				"pages/create", 
				param, 
				needToken: true
			);
			return result;
		}

		public enum PagesCreatePropertiesFontEnum {
			[EnumMember(Value = "serif")]
			Serif,
			[EnumMember(Value = "sans-serif")]
			SansSerif,
		}
		public async Task<Response<EmptyResponse>> Delete(string pageId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "pageId", pageId },
			};
			var result = await _app.Request<EmptyResponse>(
				"pages/delete", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<PageModel>>> Featured()
		{
			var result = await _app.Request<List<PageModel>>(
				"pages/featured", 
				needToken: false
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Like(string pageId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "pageId", pageId },
			};
			var result = await _app.Request<EmptyResponse>(
				"pages/like", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<PageModel>> Show(string pageId,string name,string username)
		{
			var param = new Dictionary<string, object?>
			{
				{ "pageId", pageId },
				{ "name", name },
				{ "username", username },
			};
			var result = await _app.Request<PageModel>(
				"pages/show", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Unlike(string pageId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "pageId", pageId },
			};
			var result = await _app.Request<EmptyResponse>(
				"pages/unlike", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Update(string pageId,string title,string name,string script,PagesUpdatePropertiesFontEnum font,bool alignCenter,bool hideTitleWhenPinned,string? summary = null,JsonNode? content = null,JsonNode? variables = null,string? eyeCatchingImageId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "pageId", pageId },
				{ "title", title },
				{ "name", name },
				{ "summary", summary },
				{ "content", content },
				{ "variables", variables },
				{ "script", script },
				{ "eyeCatchingImageId", eyeCatchingImageId },
				{ "font", font },
				{ "alignCenter", alignCenter },
				{ "hideTitleWhenPinned", hideTitleWhenPinned },
			};
			var result = await _app.Request<EmptyResponse>(
				"pages/update", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public enum PagesUpdatePropertiesFontEnum {
			[EnumMember(Value = "serif")]
			Serif,
			[EnumMember(Value = "sans-serif")]
			SansSerif,
		}
		public PagesApi(App app)
		{
			this._app = app;
		}
	}
}
