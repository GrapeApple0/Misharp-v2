namespace Generator.ApiJsonModels
{
    public enum HttpMethod
    {
        Get,
        Post,
        Put,
        Patch,
        Delete,
    }

    public class ApiJsonModel
    {
        public class InfoObject
        {
            public string Version { get; set; }
            public string Title { get; set; }
        }
        public InfoObject Info { get; set; }

        public ComponentsObject Components { get; set; }

        public Dictionary<string, Dictionary<HttpMethod, PathsObject>> Paths { get; set; }
    }
}
