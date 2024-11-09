using System.Text.Json.Nodes;

namespace Generator.ApiJsonModels
{
    public class PropertiesObject
    {
        // string又は配列
        public JsonNode? Type { get; set; }
        public Tools.ObjectType? ObjectType { get; set; }
        public string? Format { get; set; }
        public JsonNode? Default { get; set; }
        public JsonNode? Example { get; set; }
        public Dictionary<string, PropertiesObject>? Properties { get; set; }
        public JsonNode? AdditionalProperties { get; set; }
        public PropertiesObject? Items { get; set; }
        public string? Ref { get; set; }
        public List<string>? Required { get; set; }
        public List<string>? Enum { get; set; }
        public List<PropertiesObject>? AllOf { get; set; }
        public List<PropertiesObject>? AnyOf { get; set; }
        public List<PropertiesObject>? OneOf { get; set; }
        public string? SourceInterfaceName { get; set; }
    }

    public class ComponentObject
    {
        public string? Type { get; set; }
        public string? Format { get; set; }
        public List<string>? Required { get; set; }
        public string? Ref { get; set; }
        public Dictionary<string, PropertiesObject>? Properties { get; set; }
        public List<PropertiesObject>? AllOf { get; set; }
        public List<PropertiesObject>? AnyOf { get; set; }
        public List<PropertiesObject>? OneOf { get; set; }
    }

    public class ComponentsObject
    {
        public Dictionary<string, ComponentObject> Schemas { get; set; }
    }
}
