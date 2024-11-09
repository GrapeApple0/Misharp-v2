using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IDriveFolderModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string Name { get; set; }
		public string? ParentId { get; set; }
		public decimal FoldersCount { get; set; }
		public decimal FilesCount { get; set; }
		public DriveFolderModel Parent { get; set; }
	}


	public class DriveFolderModel: IDriveFolderModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string Name { get; set; }
		public string? ParentId { get; set; }
		public decimal FoldersCount { get; set; }
		public decimal FilesCount { get; set; }
		public DriveFolderModel Parent { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
