using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IGalleryPostModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string UserId { get; set; }
		public UserLiteModel User { get; set; }
		public string Title { get; set; }
		public string? Description { get; set; }
		public List<string> FileIds { get; set; }
		public List<DriveFileModel> Files { get; set; }
		public List<string> Tags { get; set; }
		public bool IsSensitive { get; set; }
		public decimal LikedCount { get; set; }
		public bool IsLiked { get; set; }
	}


	public class GalleryPostModel: IGalleryPostModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string UserId { get; set; }
		public UserLiteModel User { get; set; }
		public string Title { get; set; }
		public string? Description { get; set; }
		public List<string> FileIds { get; set; }
		public List<DriveFileModel> Files { get; set; }
		public List<string> Tags { get; set; }
		public bool IsSensitive { get; set; }
		public decimal LikedCount { get; set; }
		public bool IsLiked { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
