using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface INoteFavoriteModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public NoteModel Note { get; set; }
		public string NoteId { get; set; }
	}


	public class NoteFavoriteModel: INoteFavoriteModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public NoteModel Note { get; set; }
		public string NoteId { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
