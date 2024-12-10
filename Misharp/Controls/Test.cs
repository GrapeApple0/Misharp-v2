using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class TestApi
	{
		private readonly App _app;
		public async Task<Response<TestTestModel>> Test(bool required,string @string,string id,string @default = "hello",string? nullableDefault = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "required", required },
				{ "string", @string },
				{ "default", @default },
				{ "nullableDefault", nullableDefault },
				{ "id", id },
			};
			var result = await _app.Request<TestTestModel>(
				"test", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface ITestTestModel
		{
			public string Id { get; set; }
			public bool Required { get; set; }
			public string String { get; set; }
			public string Default { get; set; }
			public string? NullableDefault { get; set; }
		}
		public class TestTestModel: ITestTestModel
		{
			public string Id { get; set; }
			public bool Required { get; set; }
			public string String { get; set; }
			public string Default { get; set; }
			public string? NullableDefault { get; set; }
		}
		public TestApi(App app)
		{
			this._app = app;
		}
	}
}
