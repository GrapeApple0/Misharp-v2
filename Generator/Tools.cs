using Generator.ApiJsonModels;
using Generator.Extensions;
using System.Diagnostics;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using System.Text.Unicode;

namespace Generator
{
    public static class Tools
    {
        public struct ObjectType
        {
            public string Type { get; set; }
            public string Default { get; set; }
            public bool IsNullable { get; set; }
        }

        public static string ConvertToPascalCase(string str)
        {
            var res = Regex.Replace(str, @"(^\w|-\w|_\w|:\w)", (e) => e.Value.Replace("-", "").Replace("_", "").Replace(":", "").ToUpper());
            return res;
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
            if (type == "DateTime") nullable = true;
            return new ObjectType
            {
                Type = type,
                IsNullable = nullable
            };
        }

        public static ObjectType ParseObjectType(string? type, string? format = null)
        {
            var nullable = false;
            type = type ?? "JsonNode";
            type = ConvertTypeToString(type, format);
            if (type == "DateTime") nullable = true;
            return new ObjectType
            {
                Type = type,
                IsNullable = nullable
            };
        }

        public static ComponentObject ParseRef(ComponentsObject components, string reference)
        {
            return components.Schemas[reference];
        }

        public static void GenerateEnums(StringBuilder sb, string enumName, List<string> values, int indent = 2)
        {
            sb.AppendLineWithIndent($"public enum {ConvertToPascalCase(enumName)}Enum {{", indent);
            foreach (var value in values.ToHashSet())
            {
                if (value != null)
                {
                    var v = new StringBuilder(ConvertToPascalCase(Regex.Replace(value, @"^[+-]", match => match.Value == "+" ? "Plus" : "Minus")));
                    v.Replace("@", "At");
                    sb.AppendLineWithIndent($"[EnumMember(Value = \"{value}\")]", indent + 1);
                    sb.AppendLineWithIndent($"{v},", indent + 1);
                }
            }
            sb.AppendLineWithIndent("}", indent);
        }

        public static Dictionary<string, PropertiesObject> CompareProperties(List<PropertiesObject> multipleProperties)
        {
            var uniqueProperties = new Dictionary<string, PropertiesObject>();
            var enums = new Dictionary<string, List<string>>();
            foreach (var properties in multipleProperties)
            {
                if (properties.Properties != null)
                {
                    uniqueProperties = uniqueProperties.Merge(properties.Properties);
                    foreach (var (name, property) in properties.Properties)
                    {
                        if (property.Enum != null)
                        {
                            if (enums.ContainsKey(name))
                            {
                                enums[name] = enums[name].Concat(property.Enum).ToList();
                            }
                            else
                            {
                                enums[name] = property.Enum;
                            }
                        }
                    }
                }
            }
            foreach (var (name, uniqueProperty) in uniqueProperties)
            {
                if (enums.ContainsKey(name))
                {
                    uniqueProperty.Enum = uniqueProperty.Enum.Concat(enums[name]).ToHashSet().ToList();
                }
            }
            return uniqueProperties;
        }

        public static Dictionary<string, PropertiesObject>? ExtractRef(string source, Dictionary<string, ComponentObject> schemas)
        {
            var refProperties = schemas[source].Properties ?? new Dictionary<string, PropertiesObject>();
            var multipleProperties = schemas[source].AllOf ?? schemas[source].AnyOf ?? schemas[source].OneOf;
            if (multipleProperties != null)
            {
                foreach (var property in multipleProperties)
                {
                    if (property.Ref != null)
                    {
                        var properties = ExtractRef(property.Ref, schemas);
                        if (properties != null)
                        {
                            refProperties = refProperties.Merge(properties);
                            foreach (var (name, prop) in properties)
                            {
                                if (refProperties[name].SourceInterfaceName == null)
                                {
                                    refProperties[name].SourceInterfaceName = property.Ref;
                                }
                            }
                        }
                    }
                }
            }
            return refProperties;
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
                        var reference = p.Ref;
                        Debug.WriteLine($"Found dependency: {reference}");
                        dependencies.Add(reference);
                    }
                });
            }
            return dependencies;
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
                if (format == "binary") return "Stream";
            }
            return type;
        }

        public static void GenerateToString(StringBuilder sb, int indent = 3)
        {
            sb.AppendLineWithIndent("public override string ToString()", indent);
            sb.AppendLineWithIndent("{", indent);
            sb.AppendLineWithIndent("return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);", indent + 1);
            sb.AppendLineWithIndent("}", indent);
        }

        public static ObjectType GenerateObjectType(StringBuilder sb, StringBuilder subSB, string interfaceName, string propertyName,
            PropertiesObject property, bool foundSourceInterfaceName, int indent)
        {
            var objectMultipleProperties = property.AllOf ?? property.AnyOf ?? property.OneOf;
            var type = new ObjectType();
            if (property.Ref != null)
            {
                type.Type = $"{property.Ref}Model";
            }
            else if (property.AdditionalProperties != null)
            {
                var additionalPropertiesType = "JsonNode";
                JsonSerializerOptions options = new()
                {
                    WriteIndented = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                    PropertyNameCaseInsensitive = true
                };
                var additionalProperties = JsonSerializer.Deserialize<PropertiesObject>(property.AdditionalProperties, options);
                if (additionalProperties != null)
                {
                    var additionalPropertiesMultipleProperties = additionalProperties.AnyOf ?? additionalProperties.AllOf ?? additionalProperties.OneOf;
                    if (additionalProperties.Type != null)
                    {
                        additionalPropertiesType = ParseObjectType(additionalProperties.Type, additionalProperties.Format).Type;
                    }
                    if (additionalPropertiesMultipleProperties != null &&
                        additionalPropertiesMultipleProperties.Count == 1 &&
                        additionalPropertiesMultipleProperties[0]?.Type != null)
                    {
                        additionalPropertiesType = ParseObjectType(additionalPropertiesMultipleProperties[0].Type, additionalPropertiesMultipleProperties[0].Format).Type;
                    }
                    type.Type = $"Dictionary<string, {additionalPropertiesType}>";
                }
            }
            else if (property.Properties != null)
            {
                var iterfaceName = interfaceName + ConvertToPascalCase(propertyName);
                if (!foundSourceInterfaceName)
                {
                    var tempsb = new StringBuilder();
                    GenerateProperties(tempsb, subSB, property.Properties, iterfaceName, indent);
                    sb.AppendLineWithIndent($"public interface I{iterfaceName}Model", indent);
                    sb.AppendLineWithIndent("{", indent);
                    sb.Append(tempsb);
                    sb.AppendLineWithIndent("}", indent);
                    sb.AppendLineWithIndent($"public class {iterfaceName}Model: I{iterfaceName}Model", indent);
                    sb.AppendLineWithIndent("{", indent);
                    sb.Append(tempsb);
                    sb.AppendLineWithIndent("}", indent);
                }
                type.Type = $"{iterfaceName}Model";
            }
            else if (objectMultipleProperties != null)
            {
                var objectDependencies = GetDependencies(objectMultipleProperties);
                if (objectDependencies.Count > 1)
                {
                    var objectIterfaceName = ConvertToPascalCase(interfaceName) + ConvertToPascalCase(propertyName);
                    if (!foundSourceInterfaceName)
                    {
                        var propertiesSB = new StringBuilder();
                        sb.AppendWithIndent($"public interface I{objectIterfaceName}Model", indent);
                        sb.Append(": ");
                        sb.Append(string.Join(", ", objectDependencies.Select(d => $"I{d}Model")));
                        sb.AppendLine();
                        sb.AppendLineWithIndent("{", indent);
                        GenerateProperties(propertiesSB, subSB, property.Properties, objectIterfaceName, indent);
                        sb.Append(propertiesSB);
                        sb.AppendLineWithIndent("}", indent);
                        sb.AppendLineWithIndent($"public class {objectIterfaceName}Model: I{objectIterfaceName}Model", indent);
                        sb.AppendLineWithIndent("{", indent);
                        sb.Append(propertiesSB);
                        sb.AppendLineWithIndent("}", indent);
                    }
                    type.Type = $"{objectIterfaceName}Model";
                }
                else if (objectMultipleProperties?[0] != null)
                {
                    type.Type = ParseObjectType(objectMultipleProperties[0].Type).Type;
                    if (objectMultipleProperties[0].Ref != null)
                        type.Type = objectMultipleProperties[0].Ref + "Model";
                }
            }
            return type;
        }

        public static ObjectType GenerateArrayType(StringBuilder sb, StringBuilder subSB, string interfaceName, string propertyName, PropertiesObject itemsProperty, bool foundSourceInterfaceName, int indent)
        {
            var type = new ObjectType();
            var itemsType = ParseObjectType(itemsProperty.Type, itemsProperty.Format);
            if (itemsType.Type == "object")
            {
                if (itemsProperty.Ref != null)
                {
                    var itemsRef = itemsProperty.Ref;
                    type.Type = $"List<{itemsRef}Model>";
                }
                else if (itemsProperty.Properties != null)
                {
                    var tempsb = new StringBuilder();
                    var itemsIterfaceName = interfaceName + ConvertToPascalCase(propertyName) + "Items";
                    if (!foundSourceInterfaceName)
                    {
                        GenerateProperties(tempsb, subSB, itemsProperty.Properties, itemsIterfaceName, indent);
                        sb.AppendLineWithIndent($"public interface I{itemsIterfaceName}Model", indent);
                        sb.AppendLineWithIndent("{", indent);
                        sb.Append(tempsb);
                        sb.AppendLineWithIndent("}", indent);
                        sb.AppendLineWithIndent($"public class {itemsIterfaceName}Model: I{itemsIterfaceName}Model", indent);
                        sb.AppendLineWithIndent("{", indent);
                        sb.Append(tempsb);
                        sb.AppendLineWithIndent("}", indent);
                    }
                    type.Type = $"List<{itemsIterfaceName}Model>";
                }
                else
                {
                    var itemsMultipleProperties = itemsProperty.AllOf ?? itemsProperty.AnyOf ?? itemsProperty.OneOf;
                    var itemsDependencies = GetDependencies(itemsMultipleProperties);
                    if (itemsDependencies.Count > 1)
                    {
                        var itemsIterfaceName = interfaceName + ConvertToPascalCase(propertyName) + "Items";
                        if (!foundSourceInterfaceName)
                        {
                            var propertiesSB = new StringBuilder();
                            GenerateProperties(propertiesSB, subSB, itemsProperty.Properties, itemsIterfaceName, indent);
                            sb.AppendWithIndent($"public interface I{itemsIterfaceName}Model", indent);
                            sb.Append(": ");
                            sb.Append(string.Join(", ", itemsDependencies.Select(d => $"I{d}Model")));
                            sb.AppendLine();
                            sb.AppendLineWithIndent("{", indent);
                            sb.Append(propertiesSB);
                            sb.AppendLineWithIndent("}", indent);
                            sb.AppendLineWithIndent($"public class {itemsIterfaceName}Model: I{itemsIterfaceName}Model", indent);
                            sb.AppendLineWithIndent("{", indent);
                            sb.Append(propertiesSB);
                            sb.AppendLineWithIndent("}", indent);
                        }
                        type.Type = $"List<{itemsIterfaceName}Model>";
                    }
                    else if (itemsMultipleProperties?[0] != null)
                    {
                        type = ParseObjectType(itemsMultipleProperties[0].Type);
                    }
                }
            }
            else if (itemsProperty.Items != null)
            {
                type = GenerateArrayType(sb, subSB, interfaceName, propertyName + "Items", itemsProperty.Items, foundSourceInterfaceName, indent);
                type.Type = $"List<List<{type.Type}>>";
            }
            else
            {
                type.Type = $"List<{ParseObjectType(itemsProperty.Type, itemsProperty.Format).Type}>";
            }
            return type;
        }

        public static void GenerateProperties(StringBuilder sb, StringBuilder subSB, Dictionary<string, PropertiesObject>? properties, string interfaceName, int indent)
        {
            if (properties == null) return;
            foreach (var value in properties)
            {
                string name = ConvertToPascalCase(value.Key);
                // 上書きできないのでここで代入
                PropertiesObject property = value.Value;
                if (property == null) continue;
                var type = new ObjectType();
                var multipleProperties = property.AllOf ?? property.AnyOf ?? property.OneOf;
                var root = new Dictionary<string, PropertiesObject>();
                interfaceName = property.SourceInterfaceName ?? interfaceName;
                //if (multipleProperties != null)
                //{
                //    // 1つだけの場合はそのままそれを使う
                //    if (multipleProperties.Count == 1 &&
                //        (multipleProperties[0]?.Type != null || multipleProperties[0]?.Ref != null))
                //    {
                //        property = multipleProperties[0];
                //    }
                //    else
                //    {
                //        property.Type = "object";
                //        property.Properties = Tools.CompareProperties(multipleProperties);
                //    }
                //}
                property.Type ??= "JsonNode";
                type = ParseObjectType(property.Type, property.Format);
                if (type.Type == "object")
                {
                    type = GenerateObjectType(subSB, subSB, interfaceName, value.Key, property, property.SourceInterfaceName != null, indent);
                }
                else if (type.Type == "array" && property.Items?.Type != null)
                {
                    type = GenerateArrayType(subSB, subSB, interfaceName, value.Key, property.Items, property.SourceInterfaceName != null, indent);
                }
                else if (property.Enum != null)
                {
                    if (property.SourceInterfaceName == null)
                        GenerateEnums(subSB, interfaceName + name, property.Enum, indent);
                    type.Type = $"{ConvertToPascalCase(interfaceName) + name}Enum";
                }
                if (type.Type == "")
                {
                    type.Type = "JsonNode";
                }
                sb.AppendLineWithIndent($"public {type.Type}{(type.IsNullable ? "?" : "")} {name} {{ get; set; }}", indent + 1);
            }
        }
    }
}
