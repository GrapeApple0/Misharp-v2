using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IErrorModel
	{
		public ErrorErrorModel Error { get; set; }
	}

	public interface IErrorErrorModel
	{
		public string Code { get; set; }
		public string Message { get; set; }
		public Guid Id { get; set; }
	}
	public class ErrorErrorModel: IErrorErrorModel
	{
		public string Code { get; set; }
		public string Message { get; set; }
		public Guid Id { get; set; }
	}

	public class ErrorModel: IErrorModel
	{
		public ErrorErrorModel Error { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
