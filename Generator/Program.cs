using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Text;
using Generator.ApiJsonModels;

namespace Generator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var raw = File.ReadAllText("api.json");
            JsonSerializerOptions options = new()
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                PropertyNameCaseInsensitive = true
            };
            var jsonNode = JsonSerializer.Deserialize<ApiJsonModel>(new StringBuilder(raw).Replace("$ref", "ref").Replace("\u001a", "").ToString(), options);
            if (jsonNode == null) return;
            Console.WriteLine($"Api.json's Misskey Version: {jsonNode.Info.Version}");
            Console.WriteLine("Generating Models...");
            Generators.Models.Generate(jsonNode.Components);
        }
    }
}
