using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IAnnouncementModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string Text { get; set; }
		public string Title { get; set; }
		public string? ImageUrl { get; set; }
		public AnnouncementIconEnum Icon { get; set; }
		public AnnouncementDisplayEnum Display { get; set; }
		public bool NeedConfirmationToRead { get; set; }
		public bool Silence { get; set; }
		public bool ForYou { get; set; }
		public bool IsRead { get; set; }
	}

	public enum AnnouncementIconEnum {
		[EnumMember(Value = "info")]
		Info,
		[EnumMember(Value = "warning")]
		Warning,
		[EnumMember(Value = "error")]
		Error,
		[EnumMember(Value = "success")]
		Success,
	}
	public enum AnnouncementDisplayEnum {
		[EnumMember(Value = "dialog")]
		Dialog,
		[EnumMember(Value = "normal")]
		Normal,
		[EnumMember(Value = "banner")]
		Banner,
	}

	public class AnnouncementModel: IAnnouncementModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string Text { get; set; }
		public string Title { get; set; }
		public string? ImageUrl { get; set; }
		public AnnouncementIconEnum Icon { get; set; }
		public AnnouncementDisplayEnum Display { get; set; }
		public bool NeedConfirmationToRead { get; set; }
		public bool Silence { get; set; }
		public bool ForYou { get; set; }
		public bool IsRead { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
