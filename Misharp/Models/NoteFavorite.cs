using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface INoteFavoriteModel
	{
		public string id { get; set; }
		public DateTime createdAt { get; set; }
		public object note { get; set; }
		public string noteId { get; set; }
	}
}
