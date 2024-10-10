using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IReversiGameDetailedModel
	{
		public string id { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime? startedAt { get; set; }
		public DateTime? endedAt { get; set; }
		public bool isStarted { get; set; }
		public bool isEnded { get; set; }
		public object? form1 { get; set; }
		public object? form2 { get; set; }
		public bool user1Ready { get; set; }
		public bool user2Ready { get; set; }
		public string user1Id { get; set; }
		public string user2Id { get; set; }
		public object user1 { get; set; }
		public object user2 { get; set; }
		public string? winnerId { get; set; }
		public object? winner { get; set; }
		public string? surrenderedUserId { get; set; }
		public string? timeoutUserId { get; set; }
		public decimal? black { get; set; }
		public string bw { get; set; }
		public bool noIrregularRules { get; set; }
		public bool isLlotheo { get; set; }
		public bool canPutEverywhere { get; set; }
		public bool loopedBoard { get; set; }
		public decimal timeLimitForEachTurn { get; set; }
		public array logs { get; set; }
		public array map { get; set; }
	}
}
