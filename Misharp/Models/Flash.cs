using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IFlashModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string UserId { get; set; }
		public UserLiteModel User { get; set; }
		public string Title { get; set; }
		public string Summary { get; set; }
		public string Script { get; set; }
		public FlashVisibilityEnum Visibility { get; set; }
		public decimal? LikedCount { get; set; }
		public bool IsLiked { get; set; }
	}

	public enum FlashVisibilityEnum {
		[EnumMember(Value = "private")]
		Private,
		[EnumMember(Value = "public")]
		Public,
	}

	public class FlashModel: IFlashModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string UserId { get; set; }
		public UserLiteModel User { get; set; }
		public string Title { get; set; }
		public string Summary { get; set; }
		public string Script { get; set; }
		public FlashVisibilityEnum Visibility { get; set; }
		public decimal? LikedCount { get; set; }
		public bool IsLiked { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
