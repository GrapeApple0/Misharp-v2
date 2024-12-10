using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;
namespace Misharp.Controls
{
	public class ServerInfoApi
	{
		private readonly App _app;
		public async Task<Response<ServerInfoServerInfoGetModel>> ServerInfoGet()
		{
			var result = await _app.Request<ServerInfoServerInfoGetModel>(
				"server-info", 
				needToken: false
			);
			return result;
		}

		public interface IServerInfoServerInfoGetCpuModel
		{
			public string Model { get; set; }
			public decimal Cores { get; set; }
		}
		public class ServerInfoServerInfoGetCpuModel: IServerInfoServerInfoGetCpuModel
		{
			public string Model { get; set; }
			public decimal Cores { get; set; }
		}
		public interface IServerInfoServerInfoGetMemModel
		{
			public decimal Total { get; set; }
		}
		public class ServerInfoServerInfoGetMemModel: IServerInfoServerInfoGetMemModel
		{
			public decimal Total { get; set; }
		}
		public interface IServerInfoServerInfoGetFsModel
		{
			public decimal Total { get; set; }
			public decimal Used { get; set; }
		}
		public class ServerInfoServerInfoGetFsModel: IServerInfoServerInfoGetFsModel
		{
			public decimal Total { get; set; }
			public decimal Used { get; set; }
		}
		public interface IServerInfoServerInfoGetModel
		{
			public string Machine { get; set; }
			public ServerInfoServerInfoGetCpuModel Cpu { get; set; }
			public ServerInfoServerInfoGetMemModel Mem { get; set; }
			public ServerInfoServerInfoGetFsModel Fs { get; set; }
		}
		public class ServerInfoServerInfoGetModel: IServerInfoServerInfoGetModel
		{
			public string Machine { get; set; }
			public ServerInfoServerInfoGetCpuModel Cpu { get; set; }
			public ServerInfoServerInfoGetMemModel Mem { get; set; }
			public ServerInfoServerInfoGetFsModel Fs { get; set; }
		}
		public async Task<Response<ServerInfoServerInfoModel>> ServerInfo()
		{
			var result = await _app.Request<ServerInfoServerInfoModel>(
				"server-info", 
				needToken: false
			);
			return result;
		}

		public interface IServerInfoServerInfoCpuModel
		{
			public string Model { get; set; }
			public decimal Cores { get; set; }
		}
		public class ServerInfoServerInfoCpuModel: IServerInfoServerInfoCpuModel
		{
			public string Model { get; set; }
			public decimal Cores { get; set; }
		}
		public interface IServerInfoServerInfoMemModel
		{
			public decimal Total { get; set; }
		}
		public class ServerInfoServerInfoMemModel: IServerInfoServerInfoMemModel
		{
			public decimal Total { get; set; }
		}
		public interface IServerInfoServerInfoFsModel
		{
			public decimal Total { get; set; }
			public decimal Used { get; set; }
		}
		public class ServerInfoServerInfoFsModel: IServerInfoServerInfoFsModel
		{
			public decimal Total { get; set; }
			public decimal Used { get; set; }
		}
		public interface IServerInfoServerInfoModel
		{
			public string Machine { get; set; }
			public ServerInfoServerInfoCpuModel Cpu { get; set; }
			public ServerInfoServerInfoMemModel Mem { get; set; }
			public ServerInfoServerInfoFsModel Fs { get; set; }
		}
		public class ServerInfoServerInfoModel: IServerInfoServerInfoModel
		{
			public string Machine { get; set; }
			public ServerInfoServerInfoCpuModel Cpu { get; set; }
			public ServerInfoServerInfoMemModel Mem { get; set; }
			public ServerInfoServerInfoFsModel Fs { get; set; }
		}
		public ServerInfoApi(App app)
		{
			this._app = app;
		}
	}
}
