using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IEmojiDetailedAdminModel
	{
		public string Id { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string Name { get; set; }
		public string? Host { get; set; }
		public string PublicUrl { get; set; }
		public string OriginalUrl { get; set; }
		public string? Uri { get; set; }
		public string? Type { get; set; }
		public List<string> Aliases { get; set; }
		public string? Category { get; set; }
		public string? License { get; set; }
		public bool LocalOnly { get; set; }
		public bool IsSensitive { get; set; }
		public List<EmojiDetailedAdminRoleIdsThatCanBeUsedThisEmojiAsReactionItemsModel> RoleIdsThatCanBeUsedThisEmojiAsReaction { get; set; }
	}

	public interface IEmojiDetailedAdminRoleIdsThatCanBeUsedThisEmojiAsReactionItemsModel
	{
		public string Id { get; set; }
		public string Name { get; set; }
	}
	public class EmojiDetailedAdminRoleIdsThatCanBeUsedThisEmojiAsReactionItemsModel: IEmojiDetailedAdminRoleIdsThatCanBeUsedThisEmojiAsReactionItemsModel
	{
		public string Id { get; set; }
		public string Name { get; set; }
	}

	public class EmojiDetailedAdminModel: IEmojiDetailedAdminModel
	{
		public string Id { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string Name { get; set; }
		public string? Host { get; set; }
		public string PublicUrl { get; set; }
		public string OriginalUrl { get; set; }
		public string? Uri { get; set; }
		public string? Type { get; set; }
		public List<string> Aliases { get; set; }
		public string? Category { get; set; }
		public string? License { get; set; }
		public bool LocalOnly { get; set; }
		public bool IsSensitive { get; set; }
		public List<EmojiDetailedAdminRoleIdsThatCanBeUsedThisEmojiAsReactionItemsModel> RoleIdsThatCanBeUsedThisEmojiAsReaction { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
