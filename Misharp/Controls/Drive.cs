using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class DriveApi
	{
		private readonly App _app;
		public async Task<Response<DriveDriveModel>> Drive()
		{
			var result = await _app.Request<DriveDriveModel>(
				"drive", 
				needToken: true
			);
			return result;
		}

		public interface IDriveDriveModel
		{
			public decimal Capacity { get; set; }
			public decimal Usage { get; set; }
		}
		public class DriveDriveModel: IDriveDriveModel
		{
			public decimal Capacity { get; set; }
			public decimal Usage { get; set; }
		}
		public async Task<Response<List<DriveFileModel>>> Files(int limit = 10,string? sinceId = null,string? untilId = null,string? folderId = null,string? type = null,DriveFilesPropertiesSortEnum? sort = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "folderId", folderId },
				{ "type", type },
				{ "sort", sort },
			};
			var result = await _app.Request<List<DriveFileModel>>(
				"drive/files", 
				param, 
				needToken: true
			);
			return result;
		}

		public enum DriveFilesPropertiesSortEnum {
			[EnumMember(Value = "+createdAt")]
			PluscreatedAt,
			[EnumMember(Value = "-createdAt")]
			MinuscreatedAt,
			[EnumMember(Value = "+name")]
			Plusname,
			[EnumMember(Value = "-name")]
			Minusname,
			[EnumMember(Value = "+size")]
			Plussize,
			[EnumMember(Value = "-size")]
			Minussize,
		}
		public async Task<Response<List<DriveFolderModel>>> Folders(int limit = 10,string? sinceId = null,string? untilId = null,string? folderId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "folderId", folderId },
			};
			var result = await _app.Request<List<DriveFolderModel>>(
				"drive/folders", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<DriveFileModel>>> Stream(string type,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "type", type },
			};
			var result = await _app.Request<List<DriveFileModel>>(
				"drive/stream", 
				param, 
				needToken: true
			);
			return result;
		}

		public readonly Drive.FilesApi FilesApi;
		public readonly Drive.FoldersApi FoldersApi;
		public DriveApi(App app)
		{
			this._app = app;
			this.FilesApi = new Drive.FilesApi(this._app);
			this.FoldersApi = new Drive.FoldersApi(this._app);
		}
	}
}
namespace Misharp.Controls.Drive
{
	public class FilesApi
	{
		private readonly App _app;
		public FilesApi(App app)
		{
			this._app = app;
		}
		public async Task<Response<List<NoteModel>>> AttachedNotes(string fileId,string? sinceId = null,string? untilId = null,int limit = 10)
		{
			var param = new Dictionary<string, object?>
			{
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
				{ "fileId", fileId },
			};
			var result = await _app.Request<List<NoteModel>>(
				"drive/files/attached-notes", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<DriveFileModel>> Create(Stream file,string? folderId = null,string? name = null,string? comment = null,bool isSensitive = false,bool force = false)
		{
			var param = new Dictionary<string, object?>
			{
				{ "folderId", folderId },
				{ "name", name },
				{ "comment", comment },
				{ "isSensitive", isSensitive },
				{ "force", force },
				{ "file", file },
			};
			var result = await _app.RequestFormData<DriveFileModel>(
				"drive/files/create", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Delete(string fileId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "fileId", fileId },
			};
			var result = await _app.Request<EmptyResponse>(
				"drive/files/delete", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<DriveFileModel>>> FindByHash(string md5)
		{
			var param = new Dictionary<string, object?>
			{
				{ "md5", md5 },
			};
			var result = await _app.Request<List<DriveFileModel>>(
				"drive/files/find-by-hash", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<DriveFileModel>>> Find(string name,string? folderId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "name", name },
				{ "folderId", folderId },
			};
			var result = await _app.Request<List<DriveFileModel>>(
				"drive/files/find", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<DriveFileModel>> Show(string fileId,string url)
		{
			var param = new Dictionary<string, object?>
			{
				{ "fileId", fileId },
				{ "url", url },
			};
			var result = await _app.Request<DriveFileModel>(
				"drive/files/show", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<DriveFileModel>> Update(string fileId,string name,bool isSensitive,string? folderId = null,string? comment = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "fileId", fileId },
				{ "folderId", folderId },
				{ "name", name },
				{ "isSensitive", isSensitive },
				{ "comment", comment },
			};
			var result = await _app.Request<DriveFileModel>(
				"drive/files/update", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> UploadFromUrl(string url,string? folderId = null,bool isSensitive = false,string? comment = null,string? marker = null,bool force = false)
		{
			var param = new Dictionary<string, object?>
			{
				{ "url", url },
				{ "folderId", folderId },
				{ "isSensitive", isSensitive },
				{ "comment", comment },
				{ "marker", marker },
				{ "force", force },
			};
			var result = await _app.Request<EmptyResponse>(
				"drive/files/upload-from-url", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

	}
}
namespace Misharp.Controls.Drive
{
	public class FoldersApi
	{
		private readonly App _app;
		public FoldersApi(App app)
		{
			this._app = app;
		}
		public async Task<Response<DriveFolderModel>> Create(string name = "Untitled",string? parentId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "name", name },
				{ "parentId", parentId },
			};
			var result = await _app.Request<DriveFolderModel>(
				"drive/folders/create", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<EmptyResponse>> Delete(string folderId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "folderId", folderId },
			};
			var result = await _app.Request<EmptyResponse>(
				"drive/folders/delete", 
				param, 
				successStatusCode: System.Net.HttpStatusCode.NoContent, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<List<DriveFolderModel>>> Find(string name,string? parentId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "name", name },
				{ "parentId", parentId },
			};
			var result = await _app.Request<List<DriveFolderModel>>(
				"drive/folders/find", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<DriveFolderModel>> Show(string folderId)
		{
			var param = new Dictionary<string, object?>
			{
				{ "folderId", folderId },
			};
			var result = await _app.Request<DriveFolderModel>(
				"drive/folders/show", 
				param, 
				needToken: true
			);
			return result;
		}

		public async Task<Response<DriveFolderModel>> Update(string folderId,string name,string? parentId = null)
		{
			var param = new Dictionary<string, object?>
			{
				{ "folderId", folderId },
				{ "name", name },
				{ "parentId", parentId },
			};
			var result = await _app.Request<DriveFolderModel>(
				"drive/folders/update", 
				param, 
				needToken: true
			);
			return result;
		}

	}
}
