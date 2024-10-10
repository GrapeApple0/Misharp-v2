using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IRoleCondFormulaValueNotModel
	{
		public string id { get; set; }
		public string type { get; set; }
		public object value { get; set; }
	}
}
