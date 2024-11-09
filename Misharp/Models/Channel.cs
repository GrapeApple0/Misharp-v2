using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IChannelModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? LastNotedAt { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
		public string? UserId { get; set; }
		public Uri? BannerUrl { get; set; }
		public List<string> PinnedNoteIds { get; set; }
		public string Color { get; set; }
		public bool IsArchived { get; set; }
		public decimal UsersCount { get; set; }
		public decimal NotesCount { get; set; }
		public bool IsSensitive { get; set; }
		public bool AllowRenoteToExternal { get; set; }
		public bool IsFollowing { get; set; }
		public bool IsFavorited { get; set; }
		public List<NoteModel> PinnedNotes { get; set; }
	}


	public class ChannelModel: IChannelModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? LastNotedAt { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
		public string? UserId { get; set; }
		public Uri? BannerUrl { get; set; }
		public List<string> PinnedNoteIds { get; set; }
		public string Color { get; set; }
		public bool IsArchived { get; set; }
		public decimal UsersCount { get; set; }
		public decimal NotesCount { get; set; }
		public bool IsSensitive { get; set; }
		public bool AllowRenoteToExternal { get; set; }
		public bool IsFollowing { get; set; }
		public bool IsFavorited { get; set; }
		public List<NoteModel> PinnedNotes { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
