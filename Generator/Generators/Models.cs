using Generator.Extensions;
using System.Diagnostics;
using System.Text;
using static Generator.Models.ApiJsonModel;
using static Generator.Models.ApiJsonModel.ComponentsObject;

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
            var dependencies = new List<string>();
            var properties = component.AllOf ?? component.AnyOf ?? component.OneOf;
            if (properties != null)
            {
                Debug.WriteLine($"Dependencies of {key} count: {properties.Count}");
                properties.ForEach(p =>
                {
                    if (p.Ref != null)
                    {
                        var reference = p.Ref.Replace("#/components/schemas/", "");
                        Debug.WriteLine($"Found dependency of {key}: {reference}");
                        dependencies.Add(reference);
                    }
                });
            }
            sb.AppendLine("using System.Text.Json;");
            sb.AppendLine("using System.Text.Json.Nodes;");
            sb.AppendLine("using System.Text;");
            sb.AppendLine();
            sb.AppendLine("namespace Misharp.Models");
            sb.AppendLine("{");
            sb.AppendWithIndent($"public interface I{key}Model", indent);
            if (dependencies.Count > 0)
            {
                sb.Append(": ");
                sb.Append(string.Join(", ", dependencies.Select(d => $"I{d}Model")));
            }
            sb.AppendLine();
            sb.AppendLineWithIndent("{", indent);
            if (component.Properties != null)
            {
                foreach (var property in component.Properties)
                {
                    var value = property.Value;
                    if (value.Type != null)
                    {
                        var type = Tools.ParseObjectType(sb, value.Type, value.Format, value.Default?.ToString());
                        var isRequired = value.Required?.Contains(property.Key) ?? false;
                        if (type.Type == "object")
                        {

                        }
                        sb.AppendLineWithIndent($"public {(isRequired ? "required " : "")}{type.Type}{(type.IsNullable ? "?" : "")} {property.Key} {{ get; set; }}", indent + 1);
                    }
                }
            }
            if (properties != null)
            {
                properties.ForEach(p =>
                {
                    
                });
            }
            sb.AppendLineWithIndent("}", indent);
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
