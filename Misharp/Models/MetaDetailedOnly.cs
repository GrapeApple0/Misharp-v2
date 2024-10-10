using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IMetaDetailedOnlyModel
	{
		public object features { get; set; }
		public string? proxyAccountName { get; set; }
		public bool requireSetup { get; set; }
		public bool cacheRemoteFiles { get; set; }
		public bool cacheRemoteSensitiveFiles { get; set; }
	}
}
