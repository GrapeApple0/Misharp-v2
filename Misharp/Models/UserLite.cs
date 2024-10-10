using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IUserLiteModel
	{
		public string id { get; set; }
		public string? name { get; set; }
		public string username { get; set; }
		public string? host { get; set; }
		public Uri? avatarUrl { get; set; }
		public string? avatarBlurhash { get; set; }
		public array avatarDecorations { get; set; }
		public bool isBot { get; set; }
		public bool isCat { get; set; }
		public object instance { get; set; }
		public object emojis { get; set; }
		public string onlineStatus { get; set; }
		public array badgeRoles { get; set; }
	}
}
