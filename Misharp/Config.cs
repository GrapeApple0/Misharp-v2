using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Misharp
{
    public class Config
    {
        public readonly static JsonSerializerOptions JsonSerializerOptions = new()
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            PropertyNameCaseInsensitive = true,
            Converters = { new Converters.JsonEnumMemberStringEnumConverter() }
        };
    }
}
