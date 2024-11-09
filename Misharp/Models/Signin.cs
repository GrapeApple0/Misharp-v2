using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface ISigninModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string Ip { get; set; }
		public JsonNode Headers { get; set; }
		public bool Success { get; set; }
	}


	public class SigninModel: ISigninModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string Ip { get; set; }
		public JsonNode Headers { get; set; }
		public bool Success { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
