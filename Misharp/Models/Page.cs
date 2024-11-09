using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IPageModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string UserId { get; set; }
		public UserLiteModel User { get; set; }
		public List<PageBlockModel> Content { get; set; }
		public JsonNode Variables { get; set; }
		public string Title { get; set; }
		public string Name { get; set; }
		public string? Summary { get; set; }
		public bool HideTitleWhenPinned { get; set; }
		public bool AlignCenter { get; set; }
		public string Font { get; set; }
		public string Script { get; set; }
		public string? EyeCatchingImageId { get; set; }
		public DriveFileModel EyeCatchingImage { get; set; }
		public List<DriveFileModel> AttachedFiles { get; set; }
		public decimal LikedCount { get; set; }
		public bool IsLiked { get; set; }
	}


	public class PageModel: IPageModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string UserId { get; set; }
		public UserLiteModel User { get; set; }
		public List<PageBlockModel> Content { get; set; }
		public JsonNode Variables { get; set; }
		public string Title { get; set; }
		public string Name { get; set; }
		public string? Summary { get; set; }
		public bool HideTitleWhenPinned { get; set; }
		public bool AlignCenter { get; set; }
		public string Font { get; set; }
		public string Script { get; set; }
		public string? EyeCatchingImageId { get; set; }
		public DriveFileModel EyeCatchingImage { get; set; }
		public List<DriveFileModel> AttachedFiles { get; set; }
		public decimal LikedCount { get; set; }
		public bool IsLiked { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
