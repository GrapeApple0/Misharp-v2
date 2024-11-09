using Misharp.Models;
using System.Text.Json;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class FlashApi
	{
		private readonly App _app;
		public async Task<Response<FlashModel>> Create(string title,string summary,string script,List<string>? permissions = null,FlashCreatePropertiesVisibilityEnum visibility = FlashCreatePropertiesVisibilityEnum.Public)
		{
			var param = new Dictionary<string, object?>
			{
				{ "title", title },
				{ "summary", summary },
				{ "script", script },
				{ "permissions", permissions },
				{ "visibility", visibility },
			};
			var result = await _app.Request<FlashModel>(
				"flash/create", 
				param, 
				needToken: true
			);
			return result;
		}

		public enum FlashCreatePropertiesVisibilityEnum {
			[EnumMember(Value = "public")]
			Public,
			[EnumMember(Value = "private")]
			Private,
		}
		public async Task<Response<EmptyResponse>> Delete(string flashId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "flashId", flashId },
			};
			var result = await _app.Request<EmptyResponse>(
				"flash/delete", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<FlashModel>>> Featured(int offset = 0,int limit = 10)
		{
			var param = new Dictionary<string, object?>
			{
				{ "offset", offset },
				{ "limit", limit },
			};
			var result = await _app.Request<List<FlashModel>>(
				"flash/featured", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Like(string flashId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "flashId", flashId },
			};
			var result = await _app.Request<EmptyResponse>(
				"flash/like", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<FlashModel>> Show(string flashId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "flashId", flashId },
			};
			var result = await _app.Request<FlashModel>(
				"flash/show", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Unlike(string flashId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "flashId", flashId },
			};
			var result = await _app.Request<EmptyResponse>(
				"flash/unlike", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Update(string flashId,string title,string summary,string script,FlashUpdatePropertiesVisibilityEnum visibility,List<string>? permissions = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "flashId", flashId },
				{ "title", title },
				{ "summary", summary },
				{ "script", script },
				{ "permissions", permissions },
				{ "visibility", visibility },
			};
			var result = await _app.Request<EmptyResponse>(
				"flash/update", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public enum FlashUpdatePropertiesVisibilityEnum {
			[EnumMember(Value = "public")]
			Public,
			[EnumMember(Value = "private")]
			Private,
		}
		public async Task<Response<List<FlashModel>>> My(int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<FlashModel>>(
				"flash/my", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<FlashMyLikesItemsModel>>> MyLikes(int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<FlashMyLikesItemsModel>>(
				"flash/my-likes", 
				param, 
				needToken: true
			);
			return result;
		}

		public interface IFlashMyLikesItemsModel
		{
			public string Id { get; set; }
			public FlashModel Flash { get; set; }
		}
		public class FlashMyLikesItemsModel: IFlashMyLikesItemsModel
		{
			public string Id { get; set; }
			public FlashModel Flash { get; set; }
		}
		public FlashApi(App app)
		{
			this._app = app;
		}
	}
}
