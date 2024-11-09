using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IHashtagModel
	{
		public string Tag { get; set; }
		public decimal MentionedUsersCount { get; set; }
		public decimal MentionedLocalUsersCount { get; set; }
		public decimal MentionedRemoteUsersCount { get; set; }
		public decimal AttachedUsersCount { get; set; }
		public decimal AttachedLocalUsersCount { get; set; }
		public decimal AttachedRemoteUsersCount { get; set; }
	}


	public class HashtagModel: IHashtagModel
	{
		public string Tag { get; set; }
		public decimal MentionedUsersCount { get; set; }
		public decimal MentionedLocalUsersCount { get; set; }
		public decimal MentionedRemoteUsersCount { get; set; }
		public decimal AttachedUsersCount { get; set; }
		public decimal AttachedLocalUsersCount { get; set; }
		public decimal AttachedRemoteUsersCount { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
