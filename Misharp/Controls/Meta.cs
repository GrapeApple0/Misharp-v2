using Misharp.Models;
using System.Text.Json;
using System.Runtime.Serialization;

namespace Misharp.Controls
{
	public class MetaApi
	{
		private readonly App _app;
		public async Task<Response<MetaMetaModel>> Meta(bool detail = true)
		{
			var param = new Dictionary<string, object?>
			{
				{ "detail", detail },
			};
			var result = await _app.Request<MetaMetaModel>(
				"meta", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IMetaMetaModel: IMetaLiteModel, IMetaDetailedModel
		{
		}
        public class MetaMetaModel : IMetaMetaModel
        {
            public string? MaintainerName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? MaintainerEmail { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Version { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool ProvidesTarball { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? ShortName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public Uri Uri { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public List<string> Langs { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? TosUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? RepositoryUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? FeedbackUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? DefaultDarkTheme { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? DefaultLightTheme { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool DisableRegistration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool EmailRequiredForSignup { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool EnableHcaptcha { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? HcaptchaSiteKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool EnableMcaptcha { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? McaptchaSiteKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? McaptchaInstanceUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool EnableRecaptcha { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? RecaptchaSiteKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool EnableTurnstile { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? TurnstileSiteKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool EnableTestcaptcha { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? SwPublickey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string MascotImageUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? BannerUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? ServerErrorImageUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? InfoImageUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? NotFoundImageUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? IconUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public decimal MaxNoteTextLength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public List<MetaLiteAdsItemsModel> Ads { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public decimal NotesPerOneAd { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool EnableEmail { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool EnableServiceWorker { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool TranslatorAvailable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string MediaProxy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool EnableUrlPreview { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? BackgroundImageUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? ImpressumUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? LogoImageUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? PrivacyPolicyUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? InquiryUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public List<string> ServerRules { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? ThemeColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public RolePoliciesModel Policies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public MetaLiteNoteSearchableScopeEnum NoteSearchableScope { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public decimal MaxFileSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public MetaDetailedOnlyFeaturesModel Features { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string? ProxyAccountName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool RequireSetup { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool CacheRemoteFiles { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool CacheRemoteSensitiveFiles { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }
        public MetaApi(App app)
		{
			this._app = app;
		}
	}
}
