using System.Text.Json.Nodes;

namespace Generator.ApiJsonModels
{
    public class PathsObject
    {
        public class ContentType
        {
            public PropertiesObject Schema { get; set; }
        }

        public class RequestBodyClass
        {
            public bool Required { get; set; }
            public Dictionary<string, ContentType> Content { get; set; }
        }

        public class ResponsesClass
        {
            public string Description { get; set; }
            public Dictionary<string, ContentType> Content { get; set; }
        }

        public string OperationId { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public JsonNode? Security { get; set; }
        public RequestBodyClass? RequestBody { get; set; }
        public Dictionary<int, ResponsesClass>? Responses { get; set; }
    }
}
