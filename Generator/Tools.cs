using System;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using static Generator.Models.ApiJsonModel;
using static Generator.Models.ApiJsonModel.ComponentsObject;

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

        public static void GenerateObject(PropertiesObject properties)
        {

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

        public static ObjectType ParseObjectType(StringBuilder sb, JsonNode jsonNode, string? format = null, string? defaultValue = null)
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
    }
}
