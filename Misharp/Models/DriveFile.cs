using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IDriveFileModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string Name { get; set; }
		public string Type { get; set; }
		public string Md5 { get; set; }
		public decimal Size { get; set; }
		public bool IsSensitive { get; set; }
		public string? Blurhash { get; set; }
		public DriveFilePropertiesModel Properties { get; set; }
		public Uri Url { get; set; }
		public Uri? ThumbnailUrl { get; set; }
		public string? Comment { get; set; }
		public string? FolderId { get; set; }
		public DriveFolderModel Folder { get; set; }
		public string? UserId { get; set; }
		public UserLiteModel User { get; set; }
	}

	public interface IDriveFilePropertiesModel
	{
		public decimal Width { get; set; }
		public decimal Height { get; set; }
		public decimal Orientation { get; set; }
		public string AvgColor { get; set; }
	}
	public class DriveFilePropertiesModel: IDriveFilePropertiesModel
	{
		public decimal Width { get; set; }
		public decimal Height { get; set; }
		public decimal Orientation { get; set; }
		public string AvgColor { get; set; }
	}

	public class DriveFileModel: IDriveFileModel
	{
		public string Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string Name { get; set; }
		public string Type { get; set; }
		public string Md5 { get; set; }
		public decimal Size { get; set; }
		public bool IsSensitive { get; set; }
		public string? Blurhash { get; set; }
		public DriveFilePropertiesModel Properties { get; set; }
		public Uri Url { get; set; }
		public Uri? ThumbnailUrl { get; set; }
		public string? Comment { get; set; }
		public string? FolderId { get; set; }
		public DriveFolderModel Folder { get; set; }
		public string? UserId { get; set; }
		public UserLiteModel User { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
