using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IAntennaModel
	{
		public string id { get; set; }
		public DateTime createdAt { get; set; }
		public string name { get; set; }
		public array keywords { get; set; }
		public array excludeKeywords { get; set; }
		public string src { get; set; }
		public string? userListId { get; set; }
		public array users { get; set; }
		public bool caseSensitive { get; set; }
		public bool localOnly { get; set; }
		public bool excludeBots { get; set; }
		public bool withReplies { get; set; }
		public bool withFile { get; set; }
		public bool isActive { get; set; }
		public bool hasUnreadNote { get; set; }
		public bool notify { get; set; }
	}
}
