using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IRenoteMutingModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string MuteeId { get; set; }
		public UserDetailedNotMeModel Mutee { get; set; }
	}


	public class RenoteMutingModel: IRenoteMutingModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string MuteeId { get; set; }
		public UserDetailedNotMeModel Mutee { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
