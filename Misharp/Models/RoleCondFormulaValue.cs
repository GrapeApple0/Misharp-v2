using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IRoleCondFormulaValueModel: IRoleCondFormulaLogicsModel, IRoleCondFormulaValueNotModel, IRoleCondFormulaValueIsLocalOrRemoteModel, IRoleCondFormulaValueUserSettingBooleanSchemaModel, IRoleCondFormulaValueAssignedRoleModel, IRoleCondFormulaValueCreatedModel, IRoleCondFormulaFollowersOrFollowingOrNotesModel
	{
	}

	public class RoleCondFormulaValue : IRoleCondFormulaValueModel
    {
       
    }
}
