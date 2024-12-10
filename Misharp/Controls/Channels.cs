using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class ChannelsApi
	{
		private readonly App _app;
		public async Task<Response<ChannelModel>> Create(string name,string color,string? description = null,string? bannerId = null,bool? isSensitive = null,bool? allowRenoteToExternal = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "name", name },
				{ "description", description },
				{ "bannerId", bannerId },
				{ "color", color },
				{ "isSensitive", isSensitive },
				{ "allowRenoteToExternal", allowRenoteToExternal },
			};
			var result = await _app.Request<ChannelModel>(
				"channels/create", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<ChannelModel>>> Featured()
		{
			var result = await _app.Request<List<ChannelModel>>(
				"channels/featured", 
				needToken: false
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Follow(string channelId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "channelId", channelId },
			};
			var result = await _app.Request<EmptyResponse>(
				"channels/follow", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<ChannelModel>>> Followed(string? sinceId = null,string? untilId = null,int limit = 5)
		{
			var param = new Dictionary<string, object?>
			{
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<ChannelModel>>(
				"channels/followed", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<ChannelModel>>> Owned(string? sinceId = null,string? untilId = null,int limit = 5)
		{
			var param = new Dictionary<string, object?>
			{
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<ChannelModel>>(
				"channels/owned", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<ChannelModel>> Show(string channelId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "channelId", channelId },
			};
			var result = await _app.Request<ChannelModel>(
				"channels/show", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<List<NoteModel>>> Timeline(string channelId,int limit = 10,string? sinceId = null,string? untilId = null,int? sinceDate = null,int? untilDate = null,bool allowPartial = false)
		{
			var param = new Dictionary<string, object?>
			{
				{ "channelId", channelId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "sinceDate", sinceDate },
				{ "untilDate", untilDate },
				{ "allowPartial", allowPartial },
			};
			var result = await _app.Request<List<NoteModel>>(
				"channels/timeline", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Unfollow(string channelId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "channelId", channelId },
			};
			var result = await _app.Request<EmptyResponse>(
				"channels/unfollow", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<ChannelModel>> Update(string channelId,string name,string color,string? description = null,string? bannerId = null,bool? isArchived = null,List<string>? pinnedNoteIds = null,bool? isSensitive = null,bool? allowRenoteToExternal = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "channelId", channelId },
				{ "name", name },
				{ "description", description },
				{ "bannerId", bannerId },
				{ "isArchived", isArchived },
				{ "pinnedNoteIds", pinnedNoteIds },
				{ "color", color },
				{ "isSensitive", isSensitive },
				{ "allowRenoteToExternal", allowRenoteToExternal },
			};
			var result = await _app.Request<ChannelModel>(
				"channels/update", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Favorite(string channelId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "channelId", channelId },
			};
			var result = await _app.Request<EmptyResponse>(
				"channels/favorite", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Unfavorite(string channelId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "channelId", channelId },
			};
			var result = await _app.Request<EmptyResponse>(
				"channels/unfavorite", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<ChannelModel>>> MyFavorites()
		{
			var result = await _app.Request<List<ChannelModel>>(
				"channels/my-favorites", 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<ChannelModel>>> Search(string query,ChannelsSearchPropertiesTypeEnum type = ChannelsSearchPropertiesTypeEnum.NameAndDescription,string? sinceId = null,string? untilId = null,int limit = 5)
		{
			var param = new Dictionary<string, object?>
			{
				{ "query", query },
				{ "type", type },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<ChannelModel>>(
				"channels/search", 
				param, 
				needToken: false
			);
			return result;
		}

		public enum ChannelsSearchPropertiesTypeEnum {
			[EnumMember(Value = "nameAndDescription")]
			NameAndDescription,
			[EnumMember(Value = "nameOnly")]
			NameOnly,
		}
		public ChannelsApi(App app)
		{
			this._app = app;
		}
	}
}
