using Generator.ApiJsonModels;
using System.ComponentModel;
using System;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using static Generator.ApiJsonModels.ComponentsObject;
using Generator.Extensions;
using System.Diagnostics;
using System.Xml.Linq;

namespace Generator
{
    public static class Tools
    {
        public static string ConvertToPascalCase(string str)
        {
            return Regex.Replace(str, @"(^\w|-\w)", (e) => e.Value.Replace("-", "").ToUpper());//Regex.Replace(str, @"\b\p{Ll}", match => match.Value.ToUpper());
        }

        public static ComponentObject ParseRef(ComponentsObject components, string reference)
        {
            return components.Schemas[reference];
        }

        public static void CompareModels()
        {

        }
        
        public static void GenerateObject(StringBuilder sb, PropertiesObject? property, string interfaceName, string propertyName, int indent)
        {
            string name = "";
            var type = new ObjectType();
            if (property != null)
            {
                if (property.Type != null)
                {
                    type = ParseObjectType(property.Type, property.Format);
                    if (type.Type == "object")
                    {
                        if (property.Ref != null)
                        {
                            type.Type = $"{property.Ref.Replace("#/components/schemas/", "")}Model";
                        }
                        else
                        {
                            var objectIterfaceName = interfaceName + ConvertToPascalCase(propertyName);
                            sb.AppendLineWithIndent($"public interface I{objectIterfaceName}Model", indent + 1);
                            sb.AppendLineWithIndent("{", indent + 1);
                            GenerateObject(sb, property.Properties, interfaceName, ConvertToPascalCase(propertyName), indent + 1);
                            sb.AppendLineWithIndent("}", indent + 1);
                            type.Type = $"{objectIterfaceName}Model";
                        }
                    }
                    else if (type.Type == "array")
                    {
                        if (property.Items != null)
                        {
                            if (property.Items.Type != null)
                            {
                                var itemsType = ParseObjectType(property.Items.Type, property.Items.Format);
                                if (itemsType.Type == "object")
                                {
                                    if (property.Items.Ref != null)
                                    {
                                        var itemsRef = property.Items.Ref.Replace("#/components/schemas/", "");
                                        type.Type = $"List<{itemsRef}Model>";
                                    }
                                    else
                                    {
                                        var itemsIterfaceName = interfaceName + ConvertToPascalCase(propertyName) + "Items";
                                        sb.AppendLineWithIndent($"public interface I{itemsIterfaceName}Model", indent + 1);
                                        sb.AppendLineWithIndent("{", indent + 1);
                                        GenerateObject(sb, property.Items, interfaceName, ConvertToPascalCase(propertyName) + "Items", indent + 1);
                                        sb.AppendLineWithIndent("}", indent + 1);
                                        type.Type = $"List<{itemsIterfaceName}Model>";
                                    }
                                }
                                else
                                {
                                    type.Type = ParseObjectType(property.Items.Type, property.Items.Format).Type;
                                }
                            }
                        }
                    }
                    name = ConvertToPascalCase(propertyName);
                }
            }
            sb.AppendLineWithIndent($"public {type.Type}{(type.IsNullable ? "?" : "")} {name} {{ get; set; }}", indent + 1);
        }

        public static List<string> GetDependencies(List<PropertiesObject>? multipleProperties)
        {
            var dependencies = new List<string>();
            if (multipleProperties != null)
            {
                Debug.WriteLine($"Dependencies count: {multipleProperties.Count}");
                multipleProperties.ForEach(p =>
                {
                    if (p.Ref != null)
                    {
                        var reference = p.Ref.Replace("#/components/schemas/", "");
                        Debug.WriteLine($"Found dependency: {reference}");
                        dependencies.Add(reference);
                    }
                });
            }
            return dependencies;
        }

        public static void GenerateInterface(StringBuilder sb, string interfaceName,
                                            Dictionary<string, PropertiesObject>? properties,
                                            List<PropertiesObject>? multipleProperties,
                                            List<string> dependencies, int indent = 1)
        {
            Debug.WriteLine($"Generating interface: I{interfaceName}Model");
            sb.AppendWithIndent($"public interface I{interfaceName}Model", indent);
            if (dependencies.Count > 0)
            {
                sb.Append(": ");
                sb.Append(string.Join(", ", dependencies.Select(d => $"I{d}Model")));
            }
            sb.AppendLine();
            sb.AppendLineWithIndent("{", indent);
            if (properties != null)
            {
                foreach (var property in properties)
                {
                    var value = property.Value;
                    GenerateObject(sb, property.Value, interfaceName, property.Key, indent);
                }
            }
            if (multipleProperties != null)
            {
                multipleProperties.ForEach(p =>
                {

                });
            }
            sb.AppendLineWithIndent("}", indent);
        }

        public static string ConvertTypeToString(string type, string? format = null)
        {
            if (type == "number") return "decimal";
            if (type == "integer") return "int";
            if (type == "boolean") return "bool";
            if (type == "string")
            {
                if (format == "date-time") return "DateTime";
                if (format == "url") return "Uri";
                if (format == "uuid") return "Guid";
            }
            return type;
        }

        public struct ObjectType
        {
            public string Type { get; set; }
            public string Default { get; set; }
            public bool IsNullable { get; set; }
        }

        public static ObjectType ParseObjectType(JsonNode jsonNode, string? format = null)
        {
            var type = "JsonNode";
            var nullable = false;
            if (jsonNode is JsonValue jv && jv.AsValue().TryGetValue<string>(out var s))
            {
                type = s;
            }
            else if (jsonNode is JsonArray ja && ja != null && ja.Count > 0 && ja[0] != null)
            {
                nullable = true;
                type = ja[0]?.ToString() ?? "JsonNode";
            }
            type = ConvertTypeToString(type, format);
            return new ObjectType
            {
                Type = type,
                IsNullable = nullable
            };
        }

        public static ObjectType ParseObjectType(string? type, string? format = null)
        {
            type = type ?? "JsonNode";
            type = ConvertTypeToString(type, format);
            return new ObjectType
            {
                Type = type,
                IsNullable = false
            };
        }
    }
}
