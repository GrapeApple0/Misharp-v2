using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IPageModel
	{
		public string id { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime updatedAt { get; set; }
		public string userId { get; set; }
		public object user { get; set; }
		public array content { get; set; }
		public array variables { get; set; }
		public string title { get; set; }
		public string name { get; set; }
		public string? summary { get; set; }
		public bool hideTitleWhenPinned { get; set; }
		public bool alignCenter { get; set; }
		public string font { get; set; }
		public string script { get; set; }
		public string? eyeCatchingImageId { get; set; }
		public object? eyeCatchingImage { get; set; }
		public array attachedFiles { get; set; }
		public decimal likedCount { get; set; }
		public bool isLiked { get; set; }
	}
}
