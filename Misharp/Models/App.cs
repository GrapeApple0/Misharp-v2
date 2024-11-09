using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IAppModel
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string? CallbackUrl { get; set; }
		public List<string> Permission { get; set; }
		public string Secret { get; set; }
		public bool IsAuthorized { get; set; }
	}


	public class AppModel: IAppModel
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string? CallbackUrl { get; set; }
		public List<string> Permission { get; set; }
		public string Secret { get; set; }
		public bool IsAuthorized { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
