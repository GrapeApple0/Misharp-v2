using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IFederationInstanceModel
	{
		public string id { get; set; }
		public DateTime firstRetrievedAt { get; set; }
		public string host { get; set; }
		public decimal usersCount { get; set; }
		public decimal notesCount { get; set; }
		public decimal followingCount { get; set; }
		public decimal followersCount { get; set; }
		public bool isNotResponding { get; set; }
		public bool isSuspended { get; set; }
		public string suspensionState { get; set; }
		public bool isBlocked { get; set; }
		public string? softwareName { get; set; }
		public string? softwareVersion { get; set; }
		public bool? openRegistrations { get; set; }
		public string? name { get; set; }
		public string? description { get; set; }
		public string? maintainerName { get; set; }
		public string? maintainerEmail { get; set; }
		public bool isSilenced { get; set; }
		public bool isMediaSilenced { get; set; }
		public Uri? iconUrl { get; set; }
		public Uri? faviconUrl { get; set; }
		public string? themeColor { get; set; }
		public DateTime? infoUpdatedAt { get; set; }
		public DateTime? latestRequestReceivedAt { get; set; }
		public string? moderationNote { get; set; }
	}
}
