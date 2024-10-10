using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IErrorModel
	{
		public object error { get; set; }
	}
}
