using System.Text.Json.Nodes;

namespace Misharp.Streaming.Models;

public class BodyModel
{
    public string Id { get; set; }
    public Enums.BodyType Type { get; set; }
    public JsonNode Body { get; set; }
}