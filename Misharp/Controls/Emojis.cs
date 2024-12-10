using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class EmojisApi
	{
		private readonly App _app;
		public async Task<Response<EmojisEmojisGetModel>> EmojisGet()
		{
			var result = await _app.Request<EmojisEmojisGetModel>(
				"emojis", 
				needToken: false
			);
			return result;
		}

		public interface IEmojisEmojisGetModel
		{
			public List<EmojiSimpleModel> Emojis { get; set; }
		}
		public class EmojisEmojisGetModel: IEmojisEmojisGetModel
		{
			public List<EmojiSimpleModel> Emojis { get; set; }
		}
		public async Task<Response<EmojisEmojisModel>> Emojis()
		{
			var result = await _app.Request<EmojisEmojisModel>(
				"emojis", 
				needToken: false
			);
			return result;
		}

		public interface IEmojisEmojisModel
		{
			public List<EmojiSimpleModel> Emojis { get; set; }
		}
		public class EmojisEmojisModel: IEmojisEmojisModel
		{
			public List<EmojiSimpleModel> Emojis { get; set; }
		}
		public EmojisApi(App app)
		{
			this._app = app;
		}
	}
}
