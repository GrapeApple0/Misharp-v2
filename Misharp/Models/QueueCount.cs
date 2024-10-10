using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IQueueCountModel
	{
		public decimal waiting { get; set; }
		public decimal active { get; set; }
		public decimal completed { get; set; }
		public decimal failed { get; set; }
		public decimal delayed { get; set; }
	}
}
