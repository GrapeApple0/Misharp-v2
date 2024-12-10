using System.Text;
using Misharp.Streaming;
using Misharp.Streaming.Enums;

namespace Misharp.Test;

public abstract class Program
{
    public static async Task Main()
    {
        var app = new App(Config.Server, Config.Token);
        await app.Streaming.Start();
        Console.WriteLine("Streaming started");
        await Task.Delay(1000);
        app.Streaming.Received += args => { Console.WriteLine(args.Body.Type); };
        app.Streaming.ReactedReceived += args => { Console.WriteLine(args.Body.Reaction); };
        app.Streaming.UnreactedReceived += args => { Console.WriteLine(args.Body.Reaction); };
        app.Streaming.NoteReceived += args => { Console.WriteLine(args.Body.Text); };
        await app.Streaming.Subscribe(ChannelType.HomeTimeline, "1");
        await app.Streaming.Subscribe(ChannelType.Main, "2");
        //var note = (await app.NotesApi.Create(text: "てすと2")).Result;
        await app.Streaming.Subscribe("a1lif12vox");
        Console.WriteLine("A message was sent");
        await Task.Delay(1000 * 60);
        await app.Streaming.Unsubscribe(1);
        await app.Streaming.Unsubscribe(2);
        await app.Streaming.Unsubscribe("a1lif12vox");
        await app.Streaming.Stop();
    }
}