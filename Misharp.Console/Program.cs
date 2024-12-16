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
        await using var fs = new FileStream("image.png", FileMode.Open);
        var file = (await app.DriveApi.FilesApi.Create(fs)).Result;
        var note = (await app.NotesApi.Create(text: "Test", fileIds: new List<string> { file.Id },
            visibility: NotesApi.NotesCreatePropertiesVisibilityEnum.Specified)).Result;
        Console.WriteLine(note.ToString());
    }
}