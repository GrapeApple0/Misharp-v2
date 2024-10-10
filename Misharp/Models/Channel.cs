using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IChannelModel
	{
		public string id { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime? lastNotedAt { get; set; }
		public string name { get; set; }
		public string? description { get; set; }
		public string? userId { get; set; }
		public Uri? bannerUrl { get; set; }
		public array pinnedNoteIds { get; set; }
		public string color { get; set; }
		public bool isArchived { get; set; }
		public decimal usersCount { get; set; }
		public decimal notesCount { get; set; }
		public bool isSensitive { get; set; }
		public bool allowRenoteToExternal { get; set; }
		public bool isFollowing { get; set; }
		public bool isFavorited { get; set; }
		public array pinnedNotes { get; set; }
	}
}
