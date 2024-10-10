using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IFollowingModel
	{
		public string id { get; set; }
		public DateTime createdAt { get; set; }
		public string followeeId { get; set; }
		public string followerId { get; set; }
		public object followee { get; set; }
		public object follower { get; set; }
	}
}
