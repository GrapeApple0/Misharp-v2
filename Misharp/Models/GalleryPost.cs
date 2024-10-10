using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IGalleryPostModel
	{
		public string id { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime updatedAt { get; set; }
		public string userId { get; set; }
		public object user { get; set; }
		public string title { get; set; }
		public string? description { get; set; }
		public array fileIds { get; set; }
		public array files { get; set; }
		public array tags { get; set; }
		public bool isSensitive { get; set; }
		public decimal likedCount { get; set; }
		public bool isLiked { get; set; }
	}
}
