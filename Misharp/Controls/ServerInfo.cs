using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class ServerInfoApi
	{
		private readonly App _app;
		public async Task<Response<GetServerInfoGetModel>> ServerInfoGet()
		{
			var result = await _app.Request<GetServerInfoGetModel>(
				"server-info", 
				needToken: false
			);
			return result;
		}

		public interface IGetServerInfoGetCpuModel
		{
			public string Model { get; set; }
			public decimal Cores { get; set; }
		}
		public class GetServerInfoGetCpuModel: IGetServerInfoGetCpuModel
		{
			public string Model { get; set; }
			public decimal Cores { get; set; }
		}
		public interface IGetServerInfoGetMemModel
		{
			public decimal Total { get; set; }
		}
		public class GetServerInfoGetMemModel: IGetServerInfoGetMemModel
		{
			public decimal Total { get; set; }
		}
		public interface IGetServerInfoGetFsModel
		{
			public decimal Total { get; set; }
			public decimal Used { get; set; }
		}
		public class GetServerInfoGetFsModel: IGetServerInfoGetFsModel
		{
			public decimal Total { get; set; }
			public decimal Used { get; set; }
		}
		public interface IGetServerInfoGetModel
		{
			public string Machine { get; set; }
			public GetServerInfoGetCpuModel Cpu { get; set; }
			public GetServerInfoGetMemModel Mem { get; set; }
			public GetServerInfoGetFsModel Fs { get; set; }
		}
		public class GetServerInfoGetModel: IGetServerInfoGetModel
		{
			public string Machine { get; set; }
			public GetServerInfoGetCpuModel Cpu { get; set; }
			public GetServerInfoGetMemModel Mem { get; set; }
			public GetServerInfoGetFsModel Fs { get; set; }
		}
		public async Task<Response<PostServerInfoModel>> ServerInfo()
		{
			var result = await _app.Request<PostServerInfoModel>(
				"server-info", 
				needToken: false
			);
			return result;
		}

		public interface IPostServerInfoCpuModel
		{
			public string Model { get; set; }
			public decimal Cores { get; set; }
		}
		public class PostServerInfoCpuModel: IPostServerInfoCpuModel
		{
			public string Model { get; set; }
			public decimal Cores { get; set; }
		}
		public interface IPostServerInfoMemModel
		{
			public decimal Total { get; set; }
		}
		public class PostServerInfoMemModel: IPostServerInfoMemModel
		{
			public decimal Total { get; set; }
		}
		public interface IPostServerInfoFsModel
		{
			public decimal Total { get; set; }
			public decimal Used { get; set; }
		}
		public class PostServerInfoFsModel: IPostServerInfoFsModel
		{
			public decimal Total { get; set; }
			public decimal Used { get; set; }
		}
		public interface IPostServerInfoModel
		{
			public string Machine { get; set; }
			public PostServerInfoCpuModel Cpu { get; set; }
			public PostServerInfoMemModel Mem { get; set; }
			public PostServerInfoFsModel Fs { get; set; }
		}
		public class PostServerInfoModel: IPostServerInfoModel
		{
			public string Machine { get; set; }
			public PostServerInfoCpuModel Cpu { get; set; }
			public PostServerInfoMemModel Mem { get; set; }
			public PostServerInfoFsModel Fs { get; set; }
		}
		public ServerInfoApi(App app)
		{
			this._app = app;
		}
	}
}
