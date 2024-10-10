using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IAnnouncementModel
	{
		public string id { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime? updatedAt { get; set; }
		public string text { get; set; }
		public string title { get; set; }
		public string? imageUrl { get; set; }
		public string icon { get; set; }
		public string display { get; set; }
		public bool needConfirmationToRead { get; set; }
		public bool silence { get; set; }
		public bool forYou { get; set; }
		public bool isRead { get; set; }
	}
}
