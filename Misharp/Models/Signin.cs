using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface ISigninModel
	{
		public string id { get; set; }
		public DateTime createdAt { get; set; }
		public string ip { get; set; }
		public object headers { get; set; }
		public bool success { get; set; }
	}
}
