using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IUserModel: IUserLiteModel, IUserDetailedModel
	{
	}
}