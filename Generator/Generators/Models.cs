using Generator.ApiJsonModels;
using System.Diagnostics;
using System.Text;
using static Generator.ApiJsonModels.ComponentsObject;

namespace Generator.Generators
{
    public static class Models
    {
        public static string GenerateClass(ComponentsObject components,
                                            string key,
                                            ComponentObject component,
                                            StringBuilder sb, int indent = 1)
        {
            Console.WriteLine($"Generating {key}");
            // 継承元を取得
            var multipleProperties = component.AllOf ?? component.AnyOf ?? component.OneOf;
            var dependencies = Tools.GetDependencies(multipleProperties);
            sb.AppendLine("using System.Text.Json;");
            sb.AppendLine("using System.Text.Json.Nodes;");
            sb.AppendLine("using System.Text;");
            sb.AppendLine();
            sb.AppendLine("namespace Misharp.Models");
            sb.AppendLine("{");
            Tools.GenerateInterface(sb, key, component.Properties, multipleProperties, dependencies, indent);
            sb.AppendLine("}");
            return sb.ToString();
        }

        public static void Generate(ComponentsObject components, int indent = 0)
        {
            if (!Directory.Exists("./Models")) Directory.CreateDirectory("./Models");
            foreach (var schema in components.Schemas)
            {
                var sb = new StringBuilder();
                GenerateClass(components, schema.Key, schema.Value, sb);

                Console.WriteLine(sb.ToString());
                File.WriteAllText($"./Models/{schema.Key}.cs", sb.ToString());
            }
        }
    }
}
