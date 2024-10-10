using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IUserListModel
	{
		public string id { get; set; }
		public DateTime createdAt { get; set; }
		public string name { get; set; }
		public array userIds { get; set; }
		public bool isPublic { get; set; }
	}
}
