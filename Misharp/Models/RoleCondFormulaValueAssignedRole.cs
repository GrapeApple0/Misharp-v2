using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IRoleCondFormulaValueAssignedRoleModel
	{
		public string id { get; set; }
		public string type { get; set; }
		public string roleId { get; set; }
	}
}
