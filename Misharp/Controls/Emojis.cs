using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class EmojisApi
	{
		private readonly App _app;
		public async Task<Response<GetEmojisGetModel>> EmojisGet()
		{
			var result = await _app.Request<GetEmojisGetModel>(
				"emojis", 
				needToken: false
			);
			return result;
		}

		public interface IGetEmojisGetModel
		{
			public List<EmojiSimpleModel> Emojis { get; set; }
		}
		public class GetEmojisGetModel: IGetEmojisGetModel
		{
			public List<EmojiSimpleModel> Emojis { get; set; }
		}
		public async Task<Response<PostEmojisModel>> Emojis()
		{
			var result = await _app.Request<PostEmojisModel>(
				"emojis", 
				needToken: false
			);
			return result;
		}

		public interface IPostEmojisModel
		{
			public List<EmojiSimpleModel> Emojis { get; set; }
		}
		public class PostEmojisModel: IPostEmojisModel
		{
			public List<EmojiSimpleModel> Emojis { get; set; }
		}
		public EmojisApi(App app)
		{
			this._app = app;
		}
	}
}
