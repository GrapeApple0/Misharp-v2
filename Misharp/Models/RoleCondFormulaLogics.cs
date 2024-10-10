using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IRoleCondFormulaLogicsModel
	{
		public string id { get; set; }
		public string type { get; set; }
		public array values { get; set; }
	}
}
