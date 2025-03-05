using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;

namespace Misharp.Controls
{
	public class MetaApi
	{
		private readonly App _app;
		public async Task<Response<PostMetaModel>> Meta(bool detail = true)
		{
			var param = new Dictionary<string, object?>
			{
				{ "detail", detail },
			};
			var result = await _app.Request<PostMetaModel>(
				"meta", 
				param, 
				needToken: false
			);
			return result;
		}

		public interface IPostMetaModel: IMetaLiteModel, IMetaDetailedModel
		{
		}
        public class PostMetaModel : IPostMetaModel
        {
            string? IMetaLiteModel.MaintainerName { get; set; }
            string? IMetaLiteModel.MaintainerEmail { get; set; }
            string IMetaLiteModel.Version { get; set; }
            bool IMetaLiteModel.ProvidesTarball { get; set; }
            string? IMetaLiteModel.Name { get; set; }
            string? IMetaLiteModel.ShortName { get; set; }
            Uri IMetaLiteModel.Uri { get; set; }
            string? IMetaLiteModel.Description { get; set; }
            List<string> IMetaLiteModel.Langs { get; set; }
            string? IMetaLiteModel.TosUrl { get; set; }
            string? IMetaLiteModel.RepositoryUrl { get; set; }
            string? IMetaLiteModel.FeedbackUrl { get; set; }
            string? IMetaLiteModel.DefaultDarkTheme { get; set; }
            string? IMetaLiteModel.DefaultLightTheme { get; set; }
            bool IMetaLiteModel.DisableRegistration { get; set; }
            bool IMetaLiteModel.EmailRequiredForSignup { get; set; }
            bool IMetaLiteModel.EnableHcaptcha { get; set; }
            string? IMetaLiteModel.HcaptchaSiteKey { get; set; }
            bool IMetaLiteModel.EnableMcaptcha { get; set; }
            string? IMetaLiteModel.McaptchaSiteKey { get; set; }
            string? IMetaLiteModel.McaptchaInstanceUrl { get; set; }
            bool IMetaLiteModel.EnableRecaptcha { get; set; }
            string? IMetaLiteModel.RecaptchaSiteKey { get; set; }
            bool IMetaLiteModel.EnableTurnstile { get; set; }
            string? IMetaLiteModel.TurnstileSiteKey { get; set; }
            bool IMetaLiteModel.EnableTestcaptcha { get; set; }
            string? IMetaLiteModel.GoogleAnalyticsMeasurementId { get; set; }
            string? IMetaLiteModel.SwPublickey { get; set; }
            string IMetaLiteModel.MascotImageUrl { get; set; }
            string? IMetaLiteModel.BannerUrl { get; set; }
            string? IMetaLiteModel.ServerErrorImageUrl { get; set; }
            string? IMetaLiteModel.InfoImageUrl { get; set; }
            string? IMetaLiteModel.NotFoundImageUrl { get; set; }
            string? IMetaLiteModel.IconUrl { get; set; }
            decimal IMetaLiteModel.MaxNoteTextLength { get; set; }
            List<MetaLiteAdsItemsModel> IMetaLiteModel.Ads { get; set; }
            decimal IMetaLiteModel.NotesPerOneAd { get; set; }
            bool IMetaLiteModel.EnableEmail { get; set; }
            bool IMetaLiteModel.EnableServiceWorker { get; set; }
            bool IMetaLiteModel.TranslatorAvailable { get; set; }
            string IMetaLiteModel.MediaProxy { get; set; }
            bool IMetaLiteModel.EnableUrlPreview { get; set; }
            string? IMetaLiteModel.BackgroundImageUrl { get; set; }
            string? IMetaLiteModel.ImpressumUrl { get; set; }
            string? IMetaLiteModel.LogoImageUrl { get; set; }
            string? IMetaLiteModel.PrivacyPolicyUrl { get; set; }
            string? IMetaLiteModel.InquiryUrl { get; set; }
            List<string> IMetaLiteModel.ServerRules { get; set; }
            string? IMetaLiteModel.ThemeColor { get; set; }
            RolePoliciesModel IMetaLiteModel.Policies { get; set; }
            MetaLiteNoteSearchableScopeEnum IMetaLiteModel.NoteSearchableScope { get; set; }
            decimal IMetaLiteModel.MaxFileSize { get; set; }
            MetaLiteFederationEnum IMetaLiteModel.Federation { get; set; }
            MetaDetailedOnlyFeaturesModel IMetaDetailedOnlyModel.Features { get; set; }
            string? IMetaDetailedOnlyModel.ProxyAccountName { get; set; }
            bool IMetaDetailedOnlyModel.RequireSetup { get; set; }
            bool IMetaDetailedOnlyModel.CacheRemoteFiles { get; set; }
            bool IMetaDetailedOnlyModel.CacheRemoteSensitiveFiles { get; set; }
        }
        public MetaApi(App app)
		{
			this._app = app;
		}
	}
}
