using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace Misharp.Models
{
	public interface IMetaLiteModel
	{
		public string? maintainerName { get; set; }
		public string? maintainerEmail { get; set; }
		public string version { get; set; }
		public bool providesTarball { get; set; }
		public string? name { get; set; }
		public string? shortName { get; set; }
		public Uri uri { get; set; }
		public string? description { get; set; }
		public array langs { get; set; }
		public string? tosUrl { get; set; }
		public string? repositoryUrl { get; set; }
		public string? feedbackUrl { get; set; }
		public string? defaultDarkTheme { get; set; }
		public string? defaultLightTheme { get; set; }
		public bool disableRegistration { get; set; }
		public bool emailRequiredForSignup { get; set; }
		public bool enableHcaptcha { get; set; }
		public string? hcaptchaSiteKey { get; set; }
		public bool enableMcaptcha { get; set; }
		public string? mcaptchaSiteKey { get; set; }
		public string? mcaptchaInstanceUrl { get; set; }
		public bool enableRecaptcha { get; set; }
		public string? recaptchaSiteKey { get; set; }
		public bool enableTurnstile { get; set; }
		public string? turnstileSiteKey { get; set; }
		public string? swPublickey { get; set; }
		public string mascotImageUrl { get; set; }
		public string? bannerUrl { get; set; }
		public string? serverErrorImageUrl { get; set; }
		public string? infoImageUrl { get; set; }
		public string? notFoundImageUrl { get; set; }
		public string? iconUrl { get; set; }
		public decimal maxNoteTextLength { get; set; }
		public array ads { get; set; }
		public decimal notesPerOneAd { get; set; }
		public bool enableEmail { get; set; }
		public bool enableServiceWorker { get; set; }
		public bool translatorAvailable { get; set; }
		public string mediaProxy { get; set; }
		public bool enableUrlPreview { get; set; }
		public string? backgroundImageUrl { get; set; }
		public string? impressumUrl { get; set; }
		public string? logoImageUrl { get; set; }
		public string? privacyPolicyUrl { get; set; }
		public string? inquiryUrl { get; set; }
		public array serverRules { get; set; }
		public string? themeColor { get; set; }
		public object policies { get; set; }
		public string noteSearchableScope { get; set; }
		public decimal maxFileSize { get; set; }
	}
}
