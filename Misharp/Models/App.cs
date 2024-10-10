using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IAppModel
	{
		public string id { get; set; }
		public string name { get; set; }
		public string? callbackUrl { get; set; }
		public array permission { get; set; }
		public string secret { get; set; }
		public bool isAuthorized { get; set; }
	}
}
