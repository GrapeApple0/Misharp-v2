using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IDriveFileModel
	{
		public string id { get; set; }
		public DateTime createdAt { get; set; }
		public string name { get; set; }
		public string type { get; set; }
		public string md5 { get; set; }
		public decimal size { get; set; }
		public bool isSensitive { get; set; }
		public string? blurhash { get; set; }
		public object properties { get; set; }
		public Uri url { get; set; }
		public Uri? thumbnailUrl { get; set; }
		public string? comment { get; set; }
		public string? folderId { get; set; }
		public object? folder { get; set; }
		public string? userId { get; set; }
		public object? user { get; set; }
	}
}
