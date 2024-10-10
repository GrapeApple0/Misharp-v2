using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IHashtagModel
	{
		public string tag { get; set; }
		public decimal mentionedUsersCount { get; set; }
		public decimal mentionedLocalUsersCount { get; set; }
		public decimal mentionedRemoteUsersCount { get; set; }
		public decimal attachedUsersCount { get; set; }
		public decimal attachedLocalUsersCount { get; set; }
		public decimal attachedRemoteUsersCount { get; set; }
	}
}
