namespace Misharp.Test
{
    public class Program
    {
        public static async Task Main()
        {
            var app = new Misharp.App(Config.Server, Config.Token);
            var users = (await app.AdminApi.ShowUsers(sort: Misharp.Controls.AdminApi.AdminShowUsersPropertiesSortEnum.PluscreatedAt, offset: 0)).Result;
            //var fs = new FileStream("image.png", FileMode.Open, FileAccess.Read);
            //var file = (await app.DriveApi.FilesApi.Create(fs)).Result;
            //Console.WriteLine(file);
            //var note = (await app.NotesApi.Create(text: "test", fileIds: new List<string>() { file.Id }, visibility: NotesApi.NotesCreatePropertiesVisibilityEnum.Followers)).Result;
        }
    }
}
