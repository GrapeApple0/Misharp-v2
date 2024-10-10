using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IClipModel
	{
		public string id { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime? lastClippedAt { get; set; }
		public string userId { get; set; }
		public object user { get; set; }
		public string name { get; set; }
		public string? description { get; set; }
		public bool isPublic { get; set; }
		public decimal favoritedCount { get; set; }
		public bool isFavorited { get; set; }
		public int notesCount { get; set; }
	}
}
