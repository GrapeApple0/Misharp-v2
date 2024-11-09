using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IFederationInstanceModel
	{
		public string Id { get; set; }
		public DateTime? FirstRetrievedAt { get; set; }
		public string Host { get; set; }
		public decimal UsersCount { get; set; }
		public decimal NotesCount { get; set; }
		public decimal FollowingCount { get; set; }
		public decimal FollowersCount { get; set; }
		public bool IsNotResponding { get; set; }
		public bool IsSuspended { get; set; }
		public FederationInstanceSuspensionStateEnum SuspensionState { get; set; }
		public bool IsBlocked { get; set; }
		public string? SoftwareName { get; set; }
		public string? SoftwareVersion { get; set; }
		public bool? OpenRegistrations { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public string? MaintainerName { get; set; }
		public string? MaintainerEmail { get; set; }
		public bool IsSilenced { get; set; }
		public bool IsMediaSilenced { get; set; }
		public Uri? IconUrl { get; set; }
		public Uri? FaviconUrl { get; set; }
		public string? ThemeColor { get; set; }
		public DateTime? InfoUpdatedAt { get; set; }
		public DateTime? LatestRequestReceivedAt { get; set; }
		public string? ModerationNote { get; set; }
	}

	public enum FederationInstanceSuspensionStateEnum {
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "manuallySuspended")]
		ManuallySuspended,
		[EnumMember(Value = "goneSuspended")]
		GoneSuspended,
		[EnumMember(Value = "autoSuspendedForNotResponding")]
		AutoSuspendedForNotResponding,
	}

	public class FederationInstanceModel: IFederationInstanceModel
	{
		public string Id { get; set; }
		public DateTime? FirstRetrievedAt { get; set; }
		public string Host { get; set; }
		public decimal UsersCount { get; set; }
		public decimal NotesCount { get; set; }
		public decimal FollowingCount { get; set; }
		public decimal FollowersCount { get; set; }
		public bool IsNotResponding { get; set; }
		public bool IsSuspended { get; set; }
		public FederationInstanceSuspensionStateEnum SuspensionState { get; set; }
		public bool IsBlocked { get; set; }
		public string? SoftwareName { get; set; }
		public string? SoftwareVersion { get; set; }
		public bool? OpenRegistrations { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public string? MaintainerName { get; set; }
		public string? MaintainerEmail { get; set; }
		public bool IsSilenced { get; set; }
		public bool IsMediaSilenced { get; set; }
		public Uri? IconUrl { get; set; }
		public Uri? FaviconUrl { get; set; }
		public string? ThemeColor { get; set; }
		public DateTime? InfoUpdatedAt { get; set; }
		public DateTime? LatestRequestReceivedAt { get; set; }
		public string? ModerationNote { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
