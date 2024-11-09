using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IClipModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? LastClippedAt { get; set; }
		public string UserId { get; set; }
		public UserLiteModel User { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
		public bool IsPublic { get; set; }
		public decimal FavoritedCount { get; set; }
		public bool IsFavorited { get; set; }
		public int NotesCount { get; set; }
	}


	public class ClipModel: IClipModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? LastClippedAt { get; set; }
		public string UserId { get; set; }
		public UserLiteModel User { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
		public bool IsPublic { get; set; }
		public decimal FavoritedCount { get; set; }
		public bool IsFavorited { get; set; }
		public int NotesCount { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
