using Generator.ApiJsonModels;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

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
            var sb = new StringBuilder(raw).Replace("$ref", "ref").Replace("#/components/schemas/", "").Replace("\u001a", "");
            var jsonNode = JsonSerializer.Deserialize<ApiJsonModel>(sb.ToString(), options);
            if (jsonNode == null) return;
            Console.WriteLine($"Api.json's Misskey Version: {jsonNode.Info.Version}");
            // Models
            //Console.WriteLine("Generating Models...");
            //Generators.Models.Generate(jsonNode.Components);
            //Console.WriteLine("Done!");
            //Controls(Paths)
            Console.WriteLine("Generating Controls...");
            Generators.Controls.Generate(jsonNode.Paths);
        }
    }
}
