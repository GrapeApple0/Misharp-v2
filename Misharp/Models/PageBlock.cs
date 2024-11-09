using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IPageBlockModel
	{
		public string Id { get; set; }
		public PageBlockTypeEnum Type { get; set; }
		public string Text { get; set; }
		public string Title { get; set; }
		public List<PageBlockModel> Children { get; set; }
		public string? FileId { get; set; }
		public bool Detailed { get; set; }
		public string? Note { get; set; }
	}


	public class PageBlockModel: IPageBlockModel
	{
		public string Id { get; set; }
		public PageBlockTypeEnum Type { get; set; }
		public string Text { get; set; }
		public string Title { get; set; }
		public List<PageBlockModel> Children { get; set; }
		public string? FileId { get; set; }
		public bool Detailed { get; set; }
		public string? Note { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
	public enum PageBlockTypeEnum {
		[EnumMember(Value = "text")]
		Text,
		[EnumMember(Value = "section")]
		Section,
		[EnumMember(Value = "image")]
		Image,
		[EnumMember(Value = "note")]
		Note,
	}
}
