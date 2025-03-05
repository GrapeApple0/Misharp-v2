using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models
{
	public interface IMetaDetailedModel: IMetaLiteModel, IMetaDetailedOnlyModel
	{
	}


	public class MetaDetailedModel: IMetaDetailedModel
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
		public string? GoogleAnalyticsMeasurementId { get; set; }
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
		public MetaLiteFederationEnum Federation { get; set; }
		public MetaDetailedOnlyFeaturesModel Features { get; set; }
		public string? ProxyAccountName { get; set; }
		public bool RequireSetup { get; set; }
		public bool CacheRemoteFiles { get; set; }
		public bool CacheRemoteSensitiveFiles { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
		}
		public static implicit operator MetaLiteModel(MetaDetailedModel metaDetailed)
		{
			return new MetaLiteModel()
			{
				MaintainerName = metaDetailed.MaintainerName,
				MaintainerEmail = metaDetailed.MaintainerEmail,
				Version = metaDetailed.Version,
				ProvidesTarball = metaDetailed.ProvidesTarball,
				Name = metaDetailed.Name,
				ShortName = metaDetailed.ShortName,
				Uri = metaDetailed.Uri,
				Description = metaDetailed.Description,
				Langs = metaDetailed.Langs,
				TosUrl = metaDetailed.TosUrl,
				RepositoryUrl = metaDetailed.RepositoryUrl,
				FeedbackUrl = metaDetailed.FeedbackUrl,
				DefaultDarkTheme = metaDetailed.DefaultDarkTheme,
				DefaultLightTheme = metaDetailed.DefaultLightTheme,
				DisableRegistration = metaDetailed.DisableRegistration,
				EmailRequiredForSignup = metaDetailed.EmailRequiredForSignup,
				EnableHcaptcha = metaDetailed.EnableHcaptcha,
				HcaptchaSiteKey = metaDetailed.HcaptchaSiteKey,
				EnableMcaptcha = metaDetailed.EnableMcaptcha,
				McaptchaSiteKey = metaDetailed.McaptchaSiteKey,
				McaptchaInstanceUrl = metaDetailed.McaptchaInstanceUrl,
				EnableRecaptcha = metaDetailed.EnableRecaptcha,
				RecaptchaSiteKey = metaDetailed.RecaptchaSiteKey,
				EnableTurnstile = metaDetailed.EnableTurnstile,
				TurnstileSiteKey = metaDetailed.TurnstileSiteKey,
				EnableTestcaptcha = metaDetailed.EnableTestcaptcha,
				GoogleAnalyticsMeasurementId = metaDetailed.GoogleAnalyticsMeasurementId,
				SwPublickey = metaDetailed.SwPublickey,
				MascotImageUrl = metaDetailed.MascotImageUrl,
				BannerUrl = metaDetailed.BannerUrl,
				ServerErrorImageUrl = metaDetailed.ServerErrorImageUrl,
				InfoImageUrl = metaDetailed.InfoImageUrl,
				NotFoundImageUrl = metaDetailed.NotFoundImageUrl,
				IconUrl = metaDetailed.IconUrl,
				MaxNoteTextLength = metaDetailed.MaxNoteTextLength,
				Ads = metaDetailed.Ads,
				NotesPerOneAd = metaDetailed.NotesPerOneAd,
				EnableEmail = metaDetailed.EnableEmail,
				EnableServiceWorker = metaDetailed.EnableServiceWorker,
				TranslatorAvailable = metaDetailed.TranslatorAvailable,
				MediaProxy = metaDetailed.MediaProxy,
				EnableUrlPreview = metaDetailed.EnableUrlPreview,
				BackgroundImageUrl = metaDetailed.BackgroundImageUrl,
				ImpressumUrl = metaDetailed.ImpressumUrl,
				LogoImageUrl = metaDetailed.LogoImageUrl,
				PrivacyPolicyUrl = metaDetailed.PrivacyPolicyUrl,
				InquiryUrl = metaDetailed.InquiryUrl,
				ServerRules = metaDetailed.ServerRules,
				ThemeColor = metaDetailed.ThemeColor,
				Policies = metaDetailed.Policies,
				NoteSearchableScope = metaDetailed.NoteSearchableScope,
				MaxFileSize = metaDetailed.MaxFileSize,
				Federation = metaDetailed.Federation,
			};
		}
		public static implicit operator MetaDetailedOnlyModel(MetaDetailedModel metaDetailed)
		{
			return new MetaDetailedOnlyModel()
			{
				Features = metaDetailed.Features,
				ProxyAccountName = metaDetailed.ProxyAccountName,
				RequireSetup = metaDetailed.RequireSetup,
				CacheRemoteFiles = metaDetailed.CacheRemoteFiles,
				CacheRemoteSensitiveFiles = metaDetailed.CacheRemoteSensitiveFiles,
			};
		}
	}
}
