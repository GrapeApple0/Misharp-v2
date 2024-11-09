using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IRoleLiteModel
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string? Color { get; set; }
		public string? IconUrl { get; set; }
		public string Description { get; set; }
		public bool IsModerator { get; set; }
		public bool IsAdministrator { get; set; }
		public int DisplayOrder { get; set; }
	}


	public class RoleLiteModel: IRoleLiteModel
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string? Color { get; set; }
		public string? IconUrl { get; set; }
		public string Description { get; set; }
		public bool IsModerator { get; set; }
		public bool IsAdministrator { get; set; }
		public int DisplayOrder { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
