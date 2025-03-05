using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class GetAvatarDecorationsApi
	{
		private readonly App _app;
		public async Task<Response<List<PostGetAvatarDecorationsItemsModel>>> GetAvatarDecorations()
		{
			var result = await _app.Request<List<PostGetAvatarDecorationsItemsModel>>(
				"get-avatar-decorations", 
				needToken: false
			);
			return result;
		}

		public interface IPostGetAvatarDecorationsItemsModel
		{
			public string Id { get; set; }
			public string Name { get; set; }
			public string Description { get; set; }
			public string Url { get; set; }
			public List<string> RoleIdsThatCanBeUsedThisDecoration { get; set; }
		}
		public class PostGetAvatarDecorationsItemsModel: IPostGetAvatarDecorationsItemsModel
		{
			public string Id { get; set; }
			public string Name { get; set; }
			public string Description { get; set; }
			public string Url { get; set; }
			public List<string> RoleIdsThatCanBeUsedThisDecoration { get; set; }
		}
		public GetAvatarDecorationsApi(App app)
		{
			this._app = app;
		}
	}
}
