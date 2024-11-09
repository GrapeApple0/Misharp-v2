using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IAdModel
	{
		public string Id { get; set; }
		public DateTime? ExpiresAt { get; set; }
		public DateTime? StartsAt { get; set; }
		public string Place { get; set; }
		public string Priority { get; set; }
		public decimal Ratio { get; set; }
		public string Url { get; set; }
		public string ImageUrl { get; set; }
		public string Memo { get; set; }
		public int DayOfWeek { get; set; }
	}


	public class AdModel: IAdModel
	{
		public string Id { get; set; }
		public DateTime? ExpiresAt { get; set; }
		public DateTime? StartsAt { get; set; }
		public string Place { get; set; }
		public string Priority { get; set; }
		public decimal Ratio { get; set; }
		public string Url { get; set; }
		public string ImageUrl { get; set; }
		public string Memo { get; set; }
		public int DayOfWeek { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
