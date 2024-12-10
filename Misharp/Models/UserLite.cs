using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IUserLiteModel
	{
		public string Id { get; set; }
		public string? Name { get; set; }
		public string Username { get; set; }
		public string? Host { get; set; }
		public Uri? AvatarUrl { get; set; }
		public string? AvatarBlurhash { get; set; }
		public List<UserLiteAvatarDecorationsItemsModel> AvatarDecorations { get; set; }
		public bool IsBot { get; set; }
		public bool IsCat { get; set; }
		public bool RequireSigninToViewContents { get; set; }
		public decimal? MakeNotesFollowersOnlyBefore { get; set; }
		public decimal? MakeNotesHiddenBefore { get; set; }
		public UserLiteInstanceModel Instance { get; set; }
		public Dictionary<string, string> Emojis { get; set; }
		public UserLiteOnlineStatusEnum OnlineStatus { get; set; }
		public List<UserLiteBadgeRolesItemsModel> BadgeRoles { get; set; }
	}

	public interface IUserLiteAvatarDecorationsItemsModel
	{
		public string Id { get; set; }
		public decimal Angle { get; set; }
		public bool FlipH { get; set; }
		public Uri Url { get; set; }
		public decimal OffsetX { get; set; }
		public decimal OffsetY { get; set; }
	}
	public class UserLiteAvatarDecorationsItemsModel: IUserLiteAvatarDecorationsItemsModel
	{
		public string Id { get; set; }
		public decimal Angle { get; set; }
		public bool FlipH { get; set; }
		public Uri Url { get; set; }
		public decimal OffsetX { get; set; }
		public decimal OffsetY { get; set; }
	}
	public interface IUserLiteInstanceModel
	{
		public string? Name { get; set; }
		public string? SoftwareName { get; set; }
		public string? SoftwareVersion { get; set; }
		public string? IconUrl { get; set; }
		public string? FaviconUrl { get; set; }
		public string? ThemeColor { get; set; }
	}
	public class UserLiteInstanceModel: IUserLiteInstanceModel
	{
		public string? Name { get; set; }
		public string? SoftwareName { get; set; }
		public string? SoftwareVersion { get; set; }
		public string? IconUrl { get; set; }
		public string? FaviconUrl { get; set; }
		public string? ThemeColor { get; set; }
	}
	public enum UserLiteOnlineStatusEnum {
		[EnumMember(Value = "unknown")]
		Unknown,
		[EnumMember(Value = "online")]
		Online,
		[EnumMember(Value = "active")]
		Active,
		[EnumMember(Value = "offline")]
		Offline,
	}
	public interface IUserLiteBadgeRolesItemsModel
	{
		public string Name { get; set; }
		public string? IconUrl { get; set; }
		public decimal DisplayOrder { get; set; }
	}
	public class UserLiteBadgeRolesItemsModel: IUserLiteBadgeRolesItemsModel
	{
		public string Name { get; set; }
		public string? IconUrl { get; set; }
		public decimal DisplayOrder { get; set; }
	}

	public class UserLiteModel: IUserLiteModel
	{
		public string Id { get; set; }
		public string? Name { get; set; }
		public string Username { get; set; }
		public string? Host { get; set; }
		public Uri? AvatarUrl { get; set; }
		public string? AvatarBlurhash { get; set; }
		public List<UserLiteAvatarDecorationsItemsModel> AvatarDecorations { get; set; }
		public bool IsBot { get; set; }
		public bool IsCat { get; set; }
		public bool RequireSigninToViewContents { get; set; }
		public decimal? MakeNotesFollowersOnlyBefore { get; set; }
		public decimal? MakeNotesHiddenBefore { get; set; }
		public UserLiteInstanceModel Instance { get; set; }
		public Dictionary<string, string> Emojis { get; set; }
		public UserLiteOnlineStatusEnum OnlineStatus { get; set; }
		public List<UserLiteBadgeRolesItemsModel> BadgeRoles { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
