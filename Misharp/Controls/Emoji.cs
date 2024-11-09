using Misharp.Models;
using System.Text.Json;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class EmojiApi
	{
		private readonly App _app;
		public async Task<Response<EmojiDetailedModel>> EmojiGet(string name)
		{
			var param = new Dictionary<string, object?>
			{
				{ "name", name },
			};
			var result = await _app.Request<EmojiDetailedModel>(
				"emoji", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<EmojiDetailedModel>> Emoji(string name)
		{
			var param = new Dictionary<string, object?>
			{
				{ "name", name },
			};
			var result = await _app.Request<EmojiDetailedModel>(
				"emoji", 
				param, 
				needToken: false
			);
			return result;
		}

		public EmojiApi(App app)
		{
			this._app = app;
		}
	}
}
