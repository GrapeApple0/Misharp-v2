using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IMetaLiteModel
	{
		public string? MaintainerName { get; set; }
		public string? MaintainerEmail { get; set; }
		public string Version { get; set; }
		public bool ProvidesTarball { get; set; }
		public string? Name { get; set; }
		public string? ShortName { get; set; }
		public Uri Uri { get; set; }
		public string? Description { get; set; }
		public List<string> Langs { get; set; }
		public string? TosUrl { get; set; }
		public string? RepositoryUrl { get; set; }
		public string? FeedbackUrl { get; set; }
		public string? DefaultDarkTheme { get; set; }
		public string? DefaultLightTheme { get; set; }
		public bool DisableRegistration { get; set; }
		public bool EmailRequiredForSignup { get; set; }
		public bool EnableHcaptcha { get; set; }
		public string? HcaptchaSiteKey { get; set; }
		public bool EnableMcaptcha { get; set; }
		public string? McaptchaSiteKey { get; set; }
		public string? McaptchaInstanceUrl { get; set; }
		public bool EnableRecaptcha { get; set; }
		public string? RecaptchaSiteKey { get; set; }
		public bool EnableTurnstile { get; set; }
		public string? TurnstileSiteKey { get; set; }
		public bool EnableTestcaptcha { get; set; }
		public string? SwPublickey { get; set; }
		public string MascotImageUrl { get; set; }
		public string? BannerUrl { get; set; }
		public string? ServerErrorImageUrl { get; set; }
		public string? InfoImageUrl { get; set; }
		public string? NotFoundImageUrl { get; set; }
		public string? IconUrl { get; set; }
		public decimal MaxNoteTextLength { get; set; }
		public List<MetaLiteAdsItemsModel> Ads { get; set; }
		public decimal NotesPerOneAd { get; set; }
		public bool EnableEmail { get; set; }
		public bool EnableServiceWorker { get; set; }
		public bool TranslatorAvailable { get; set; }
		public string MediaProxy { get; set; }
		public bool EnableUrlPreview { get; set; }
		public string? BackgroundImageUrl { get; set; }
		public string? ImpressumUrl { get; set; }
		public string? LogoImageUrl { get; set; }
		public string? PrivacyPolicyUrl { get; set; }
		public string? InquiryUrl { get; set; }
		public List<string> ServerRules { get; set; }
		public string? ThemeColor { get; set; }
		public RolePoliciesModel Policies { get; set; }
		public MetaLiteNoteSearchableScopeEnum NoteSearchableScope { get; set; }
		public decimal MaxFileSize { get; set; }
	}

	public interface IMetaLiteAdsItemsModel
	{
		public string Id { get; set; }
		public Uri Url { get; set; }
		public string Place { get; set; }
		public decimal Ratio { get; set; }
		public Uri ImageUrl { get; set; }
		public int DayOfWeek { get; set; }
	}
	public class MetaLiteAdsItemsModel: IMetaLiteAdsItemsModel
	{
		public string Id { get; set; }
		public Uri Url { get; set; }
		public string Place { get; set; }
		public decimal Ratio { get; set; }
		public Uri ImageUrl { get; set; }
		public int DayOfWeek { get; set; }
	}
	public enum MetaLiteNoteSearchableScopeEnum {
		[EnumMember(Value = "local")]
		Local,
		[EnumMember(Value = "global")]
		Global,
	}

	public class MetaLiteModel: IMetaLiteModel
	{
		public string? MaintainerName { get; set; }
		public string? MaintainerEmail { get; set; }
		public string Version { get; set; }
		public bool ProvidesTarball { get; set; }
		public string? Name { get; set; }
		public string? ShortName { get; set; }
		public Uri Uri { get; set; }
		public string? Description { get; set; }
		public List<string> Langs { get; set; }
		public string? TosUrl { get; set; }
		public string? RepositoryUrl { get; set; }
		public string? FeedbackUrl { get; set; }
		public string? DefaultDarkTheme { get; set; }
		public string? DefaultLightTheme { get; set; }
		public bool DisableRegistration { get; set; }
		public bool EmailRequiredForSignup { get; set; }
		public bool EnableHcaptcha { get; set; }
		public string? HcaptchaSiteKey { get; set; }
		public bool EnableMcaptcha { get; set; }
		public string? McaptchaSiteKey { get; set; }
		public string? McaptchaInstanceUrl { get; set; }
		public bool EnableRecaptcha { get; set; }
		public string? RecaptchaSiteKey { get; set; }
		public bool EnableTurnstile { get; set; }
		public string? TurnstileSiteKey { get; set; }
		public bool EnableTestcaptcha { get; set; }
		public string? SwPublickey { get; set; }
		public string MascotImageUrl { get; set; }
		public string? BannerUrl { get; set; }
		public string? ServerErrorImageUrl { get; set; }
		public string? InfoImageUrl { get; set; }
		public string? NotFoundImageUrl { get; set; }
		public string? IconUrl { get; set; }
		public decimal MaxNoteTextLength { get; set; }
		public List<MetaLiteAdsItemsModel> Ads { get; set; }
		public decimal NotesPerOneAd { get; set; }
		public bool EnableEmail { get; set; }
		public bool EnableServiceWorker { get; set; }
		public bool TranslatorAvailable { get; set; }
		public string MediaProxy { get; set; }
		public bool EnableUrlPreview { get; set; }
		public string? BackgroundImageUrl { get; set; }
		public string? ImpressumUrl { get; set; }
		public string? LogoImageUrl { get; set; }
		public string? PrivacyPolicyUrl { get; set; }
		public string? InquiryUrl { get; set; }
		public List<string> ServerRules { get; set; }
		public string? ThemeColor { get; set; }
		public RolePoliciesModel Policies { get; set; }
		public MetaLiteNoteSearchableScopeEnum NoteSearchableScope { get; set; }
		public decimal MaxFileSize { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
	}
}
