using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;

namespace Misharp.Controls;

public class PagePushApi
{
    private readonly App _app;

    public async Task<Response<EmptyResponse>> PagePush(string pageId, string @event, JsonNode var)
    {
        var param = new Dictionary<string, object?>
        {
            { "pageId", pageId },
            { "event", @event },
            { "var", var }
        };
        var result = await _app.Request<EmptyResponse>(
            "page-push",
            param,
            successStatusCode: System.Net.HttpStatusCode.NoContent,
            needToken: true
        );
        return result;
    }

    public PagePushApi(App app)
    {
        _app = app;
    }
}