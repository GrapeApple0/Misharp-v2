namespace Generator.ApiJsonModels
{
    public class ApiJsonModel
    {
        public class InfoObject
        {
            public string Version { get; set; }
            public string Title { get; set; }
        }
        public InfoObject Info { get; set; }

        public ComponentsObject Components { get; set; }
    }
}
