using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IUserListModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string Name { get; set; }
		public List<string> UserIds { get; set; }
		public bool IsPublic { get; set; }
	}


	public class UserListModel: IUserListModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string Name { get; set; }
		public List<string> UserIds { get; set; }
		public bool IsPublic { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
