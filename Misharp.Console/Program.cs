using System.Text;
using Misharp.Controls;
using Misharp.Streaming;
using Misharp.Streaming.Enums;

namespace Misharp.Test;

public abstract class Program
{
    public static async Task Main()
    {
        var app = new App(Config.Server, Config.Token);
        await using var image = File.OpenRead("image.png");
        var file = (await app.DriveApi.FilesApi.Create(image)).Result;
        var note = (await app.NotesApi.Create(text: "Test", fileIds: new List<string> { file.Id },
            visibility: NotesApi.NotesCreatePropertiesVisibilityEnum.Home)).Result;
        Console.WriteLine(note.ToString());
    }
}