using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IFlashModel
	{
		public string id { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime updatedAt { get; set; }
		public string userId { get; set; }
		public object user { get; set; }
		public string title { get; set; }
		public string summary { get; set; }
		public string script { get; set; }
		public string visibility { get; set; }
		public decimal? likedCount { get; set; }
		public bool isLiked { get; set; }
	}
}
