using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IAdModel
	{
		public string id { get; set; }
		public DateTime expiresAt { get; set; }
		public DateTime startsAt { get; set; }
		public string place { get; set; }
		public string priority { get; set; }
		public decimal ratio { get; set; }
		public string url { get; set; }
		public string imageUrl { get; set; }
		public string memo { get; set; }
		public int dayOfWeek { get; set; }
	}
}
