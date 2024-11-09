using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IMetaDetailedOnlyModel
	{
		public MetaDetailedOnlyFeaturesModel Features { get; set; }
		public string? ProxyAccountName { get; set; }
		public bool RequireSetup { get; set; }
		public bool CacheRemoteFiles { get; set; }
		public bool CacheRemoteSensitiveFiles { get; set; }
	}

	public interface IMetaDetailedOnlyFeaturesModel
	{
		public bool Registration { get; set; }
		public bool EmailRequiredForSignup { get; set; }
		public bool LocalTimeline { get; set; }
		public bool GlobalTimeline { get; set; }
		public bool Hcaptcha { get; set; }
		public bool Turnstile { get; set; }
		public bool Recaptcha { get; set; }
		public bool ObjectStorage { get; set; }
		public bool ServiceWorker { get; set; }
		public bool Miauth { get; set; }
	}
	public class MetaDetailedOnlyFeaturesModel: IMetaDetailedOnlyFeaturesModel
	{
		public bool Registration { get; set; }
		public bool EmailRequiredForSignup { get; set; }
		public bool LocalTimeline { get; set; }
		public bool GlobalTimeline { get; set; }
		public bool Hcaptcha { get; set; }
		public bool Turnstile { get; set; }
		public bool Recaptcha { get; set; }
		public bool ObjectStorage { get; set; }
		public bool ServiceWorker { get; set; }
		public bool Miauth { get; set; }
	}

	public class MetaDetailedOnlyModel: IMetaDetailedOnlyModel
	{
		public MetaDetailedOnlyFeaturesModel Features { get; set; }
		public string? ProxyAccountName { get; set; }
		public bool RequireSetup { get; set; }
		public bool CacheRemoteFiles { get; set; }
		public bool CacheRemoteSensitiveFiles { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
