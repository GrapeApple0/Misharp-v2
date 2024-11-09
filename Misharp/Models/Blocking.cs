using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IBlockingModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string BlockeeId { get; set; }
		public UserDetailedNotMeModel Blockee { get; set; }
	}


	public class BlockingModel: IBlockingModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string BlockeeId { get; set; }
		public UserDetailedNotMeModel Blockee { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
