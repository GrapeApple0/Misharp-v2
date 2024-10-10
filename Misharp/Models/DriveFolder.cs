using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IDriveFolderModel
	{
		public string id { get; set; }
		public DateTime createdAt { get; set; }
		public string name { get; set; }
		public string? parentId { get; set; }
		public decimal foldersCount { get; set; }
		public decimal filesCount { get; set; }
		public object? parent { get; set; }
	}
}
