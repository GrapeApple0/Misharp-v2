using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IRoleLiteModel
	{
		public string id { get; set; }
		public string name { get; set; }
		public string? color { get; set; }
		public string? iconUrl { get; set; }
		public string description { get; set; }
		public bool isModerator { get; set; }
		public bool isAdministrator { get; set; }
		public int displayOrder { get; set; }
	}
}
