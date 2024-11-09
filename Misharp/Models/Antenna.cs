using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IAntennaModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string Name { get; set; }
		public List<List<List<string>>> Keywords { get; set; }
		public List<List<List<string>>> ExcludeKeywords { get; set; }
		public AntennaSrcEnum Src { get; set; }
		public string? UserListId { get; set; }
		public List<string> Users { get; set; }
		public bool CaseSensitive { get; set; }
		public bool LocalOnly { get; set; }
		public bool ExcludeBots { get; set; }
		public bool WithReplies { get; set; }
		public bool WithFile { get; set; }
		public bool IsActive { get; set; }
		public bool HasUnreadNote { get; set; }
		public bool Notify { get; set; }
	}

	public enum AntennaSrcEnum {
		[EnumMember(Value = "home")]
		Home,
		[EnumMember(Value = "all")]
		All,
		[EnumMember(Value = "users")]
		Users,
		[EnumMember(Value = "list")]
		List,
		[EnumMember(Value = "users_blacklist")]
		UsersBlacklist,
	}

	public class AntennaModel: IAntennaModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string Name { get; set; }
		public List<List<List<string>>> Keywords { get; set; }
		public List<List<List<string>>> ExcludeKeywords { get; set; }
		public AntennaSrcEnum Src { get; set; }
		public string? UserListId { get; set; }
		public List<string> Users { get; set; }
		public bool CaseSensitive { get; set; }
		public bool LocalOnly { get; set; }
		public bool ExcludeBots { get; set; }
		public bool WithReplies { get; set; }
		public bool WithFile { get; set; }
		public bool IsActive { get; set; }
		public bool HasUnreadNote { get; set; }
		public bool Notify { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
