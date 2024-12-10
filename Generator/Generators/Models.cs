using Generator.ApiJsonModels;
using Generator.Extensions;
using System.Diagnostics;
using System.Text;

namespace Generator.Generators
{
    public static class Models
    {
        public static void GenerateModel(StringBuilder sb, ComponentsObject components,
                                            string interfaceName, Dictionary<string, PropertiesObject>? properties,
                                            List<PropertiesObject>? multipleProperties, int indent = 1)
        {
            Debug.WriteLine($"Generating interface: I{interfaceName}Model");
            var propertiesSB = new StringBuilder();
            var subSB = new StringBuilder();
            sb.AppendWithIndent($"public interface I{interfaceName}Model", indent);
            List<string> dependencies = Tools.GetDependencies(multipleProperties);
            if (dependencies.Count > 0)
            {
                sb.Append(": ");
                sb.Append(string.Join(", ", dependencies.Select(d => $"I{d}Model")));
            }
            sb.AppendLine();
            sb.AppendLineWithIndent("{", indent);
            if (properties != null)
            {
                Tools.GenerateProperties(propertiesSB, subSB, properties, interfaceName, indent);
                sb.Append(propertiesSB);
            }
            if (multipleProperties != null)
            {
                // 複数あるモデルをまとめる
                var multiplePropertiesSB = new StringBuilder();
                Dictionary<string, PropertiesObject> uniqueProperties = Tools.CompareProperties(multipleProperties);
                foreach (PropertiesObject property in multipleProperties)
                {
                    if (property.Properties != null)
                    {
                        uniqueProperties = uniqueProperties.Merge(property.Properties);
                    }
                }
                Tools.GenerateProperties(multiplePropertiesSB, new StringBuilder(), uniqueProperties, interfaceName, indent);
                sb.Append(multiplePropertiesSB);
            }
            sb.AppendLineWithIndent("}", indent);
            sb.AppendLine();
            sb.Append(subSB);
            sb.AppendLine();
            subSB = new StringBuilder();
            // Generate Model class
            sb.AppendLineWithIndent($"public class {interfaceName}Model: I{interfaceName}Model", indent);
            sb.AppendLineWithIndent("{", indent);
            if (properties != null)
            {
                sb.Append(propertiesSB);
            }
            if (multipleProperties != null)
            {
                var multiplePropertiesSB = new StringBuilder();
                Dictionary<string, PropertiesObject> uniqueProperties = Tools.CompareProperties(multipleProperties);//new Dictionary<string, PropertiesObject>();
                Dictionary<string, List<string>> enums = new();
                foreach (PropertiesObject property in multipleProperties)
                {
                    if (property.Ref != null)
                    {
                        var refProperty = Tools.ExtractRef(property.Ref, components.Schemas);
                        uniqueProperties = uniqueProperties.Merge(refProperty);
                        foreach (var (key, p) in refProperty)
                        {
                            if (uniqueProperties[key].SourceInterfaceName == null)
                            {
                                uniqueProperties[key].SourceInterfaceName = property.Ref;
                            }
                            if (p.Enum != null)
                            {
                                if (enums.ContainsKey(key))
                                {
                                    enums[key] = enums[key].Concat(p.Enum).ToList();
                                }
                                else
                                {
                                    enums[key] = p.Enum;
                                }
                            }
                        }
                    }
                    if (property.Properties != null)
                    {
                        uniqueProperties = uniqueProperties.Merge(property.Properties);
                    }
                }
                Tools.GenerateProperties(multiplePropertiesSB, subSB, uniqueProperties, interfaceName, indent);
                sb.Append(multiplePropertiesSB);
            }
            Tools.GenerateToString(sb, indent + 1);
            if (dependencies.Count > 0)
            {
                foreach (var dependency in dependencies)
                {
                    Tools.GenerateConverter(sb, components.Schemas, interfaceName, dependency, indent + 1);
                }
            }
            sb.AppendLineWithIndent("}", indent);
            sb.Append(subSB);
        }


        public static string GenerateClass(ComponentsObject components,
                                            string key,
                                            ComponentObject component,
                                            StringBuilder sb, int indent = 1)
        {
            Console.WriteLine($"Generating {key}");
            // 継承元を取得
            List<PropertiesObject>? multipleProperties = component.AllOf ?? component.AnyOf ?? component.OneOf;
            sb.AppendLine("using System.Text.Json;");
            sb.AppendLine("using System.Text.Json.Nodes;");
            sb.AppendLine("using System.Text;");
            sb.AppendLine("using System.Runtime.Serialization;");
            sb.AppendLine("using Misharp.Converters;");
            sb.AppendLine();
            sb.AppendLine("namespace Misharp.Models");
            sb.AppendLine("{");
            GenerateModel(sb, components, key, component.Properties, multipleProperties, indent);
            sb.AppendLine("}");
            return sb.ToString();
        }

        public static void Generate(ComponentsObject components, int indent = 0)
        {
            if (!Directory.Exists("./Models")) Directory.CreateDirectory("./Models");
            foreach (var (key, component) in components.Schemas)
            {
                if (key.StartsWith("RoleCondFormula")) continue;
                if (key.StartsWith("Reversi")) continue;
                var sb = new StringBuilder();
                GenerateClass(components, key, component, sb);
                File.WriteAllText($"./Models/{key}.cs", sb.ToString());
            }
        }
    }
}
