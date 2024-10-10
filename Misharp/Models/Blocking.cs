using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IBlockingModel
	{
		public string id { get; set; }
		public DateTime createdAt { get; set; }
		public string blockeeId { get; set; }
		public object blockee { get; set; }
	}
}
