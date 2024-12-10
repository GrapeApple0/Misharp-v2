using System.Runtime.Serialization;
using System.Text.Json.Nodes;

namespace Misharp.Streaming.Models;

public class Message
{
    public string Type { get; init; }

    public BodyModel Body { get; init; }
}