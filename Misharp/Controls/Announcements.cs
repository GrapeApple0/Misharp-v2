using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class AnnouncementsApi
	{
		private readonly App _app;
		public async Task<Response<List<AnnouncementModel>>> Announcements(int limit = 10,string? sinceId = null,string? untilId = null,bool isActive = true)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "isActive", isActive },
			};
			var result = await _app.Request<List<AnnouncementModel>>(
				"announcements", 
				param, 
				needToken: false
			);
			return result;
		}

		public async Task<Response<AnnouncementModel>> Show(string announcementId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "announcementId", announcementId },
			};
			var result = await _app.Request<AnnouncementModel>(
				"announcements/show", 
				param, 
				needToken: false
			);
			return result;
		}

		public AnnouncementsApi(App app)
		{
			this._app = app;
		}
	}
}
