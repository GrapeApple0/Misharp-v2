using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IQueueCountModel
	{
		public decimal Waiting { get; set; }
		public decimal Active { get; set; }
		public decimal Completed { get; set; }
		public decimal Failed { get; set; }
		public decimal Delayed { get; set; }
	}


	public class QueueCountModel: IQueueCountModel
	{
		public decimal Waiting { get; set; }
		public decimal Active { get; set; }
		public decimal Completed { get; set; }
		public decimal Failed { get; set; }
		public decimal Delayed { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
