using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IFollowingModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string FolloweeId { get; set; }
		public string FollowerId { get; set; }
		public UserDetailedNotMeModel Followee { get; set; }
		public UserDetailedNotMeModel Follower { get; set; }
	}


	public class FollowingModel: IFollowingModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string FolloweeId { get; set; }
		public string FollowerId { get; set; }
		public UserDetailedNotMeModel Followee { get; set; }
		public UserDetailedNotMeModel Follower { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
