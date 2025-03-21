using Misharp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.Serialization;

namespace Misharp.Controls
{
    public class AdminApi
    {
        private readonly App _app;

        public async Task<Response<AbuseReportNotificationRecipientModel>> Create(bool isActive, string name,
            AdminAbuseReportNotificationRecipientCreatePropertiesMethodEnum method, string userId,
            string systemWebhookId)
        {
            var param = new Dictionary<string, object?>
            {
                { "isActive", isActive },
                { "name", name },
                { "method", method },
                { "userId", userId },
                { "systemWebhookId", systemWebhookId }
            };
            var result = await _app.Request<AbuseReportNotificationRecipientModel>(
                "admin/abuse-report/notification-recipient/create",
                param,
                true
            );
            return result;
        }

        public enum AdminAbuseReportNotificationRecipientCreatePropertiesMethodEnum
        {
            [EnumMember(Value = "email")] Email,
            [EnumMember(Value = "webhook")] Webhook
        }

        public async Task<Response<EmptyResponse>> Delete(string id)
        {
            var param = new Dictionary<string, object?>
            {
                { "id", id }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/abuse-report/notification-recipient/delete",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<List<AbuseReportNotificationRecipientModel>>> List(List<string>? method = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "method", method }
            };
            var result = await _app.Request<List<AbuseReportNotificationRecipientModel>>(
                "admin/abuse-report/notification-recipient/list",
                param,
                true
            );
            return result;
        }

        public async Task<Response<AbuseReportNotificationRecipientModel>> Show(string id)
        {
            var param = new Dictionary<string, object?>
            {
                { "id", id }
            };
            var result = await _app.Request<AbuseReportNotificationRecipientModel>(
                "admin/abuse-report/notification-recipient/show",
                param,
                true
            );
            return result;
        }

        public async Task<Response<AbuseReportNotificationRecipientModel>> Update(string id, bool isActive, string name,
            AdminAbuseReportNotificationRecipientUpdatePropertiesMethodEnum method, string userId,
            string systemWebhookId)
        {
            var param = new Dictionary<string, object?>
            {
                { "id", id },
                { "isActive", isActive },
                { "name", name },
                { "method", method },
                { "userId", userId },
                { "systemWebhookId", systemWebhookId }
            };
            var result = await _app.Request<AbuseReportNotificationRecipientModel>(
                "admin/abuse-report/notification-recipient/update",
                param,
                true
            );
            return result;
        }

        public enum AdminAbuseReportNotificationRecipientUpdatePropertiesMethodEnum
        {
            [EnumMember(Value = "email")] Email,
            [EnumMember(Value = "webhook")] Webhook
        }

        public async Task<Response<List<PostAbuseUserReportsItemsModel>>> AbuseUserReports(int limit = 10,
            string? sinceId = null, string? untilId = null, string? state = null,
            AdminAbuseUserReportsPropertiesReporterOriginEnum reporterOrigin =
                AdminAbuseUserReportsPropertiesReporterOriginEnum.Combined,
            AdminAbuseUserReportsPropertiesTargetUserOriginEnum targetUserOrigin =
                AdminAbuseUserReportsPropertiesTargetUserOriginEnum.Combined)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "state", state },
                { "reporterOrigin", reporterOrigin },
                { "targetUserOrigin", targetUserOrigin }
            };
            var result = await _app.Request<List<PostAbuseUserReportsItemsModel>>(
                "admin/abuse-user-reports",
                param,
                true
            );
            return result;
        }

        public enum AdminAbuseUserReportsPropertiesReporterOriginEnum
        {
            [EnumMember(Value = "combined")] Combined,
            [EnumMember(Value = "local")] Local,
            [EnumMember(Value = "remote")] Remote
        }

        public enum AdminAbuseUserReportsPropertiesTargetUserOriginEnum
        {
            [EnumMember(Value = "combined")] Combined,
            [EnumMember(Value = "local")] Local,
            [EnumMember(Value = "remote")] Remote
        }

        public enum PostAbuseUserReportsItemsResolvedAsEnum
        {
            [EnumMember(Value = "accept")] Accept,
            [EnumMember(Value = "reject")] Reject
        }

        public interface IPostAbuseUserReportsItemsModel
        {
            public string Id { get; set; }
            public DateTime? CreatedAt { get; set; }
            public string Comment { get; set; }
            public bool Resolved { get; set; }
            public string ReporterId { get; set; }
            public string TargetUserId { get; set; }
            public string? AssigneeId { get; set; }
            public UserDetailedNotMeModel Reporter { get; set; }
            public UserDetailedNotMeModel TargetUser { get; set; }
            public UserDetailedNotMeModel Assignee { get; set; }
            public bool Forwarded { get; set; }
            public PostAbuseUserReportsItemsResolvedAsEnum? ResolvedAs { get; set; }
            public string ModerationNote { get; set; }
        }

        public class PostAbuseUserReportsItemsModel : IPostAbuseUserReportsItemsModel
        {
            public string Id { get; set; }
            public DateTime? CreatedAt { get; set; }
            public string Comment { get; set; }
            public bool Resolved { get; set; }
            public string ReporterId { get; set; }
            public string TargetUserId { get; set; }
            public string? AssigneeId { get; set; }
            public UserDetailedNotMeModel Reporter { get; set; }
            public UserDetailedNotMeModel TargetUser { get; set; }
            public UserDetailedNotMeModel Assignee { get; set; }
            public bool Forwarded { get; set; }
            public PostAbuseUserReportsItemsResolvedAsEnum? ResolvedAs { get; set; }
            public string ModerationNote { get; set; }
        }

        public async Task<Response<EmptyResponse>> DeleteAccount(string userId)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/delete-account",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> DeleteAllFilesOfAUser(string userId)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/delete-all-files-of-a-user",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> ForwardAbuseUserReport(string reportId)
        {
            var param = new Dictionary<string, object?>
            {
                { "reportId", reportId }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/forward-abuse-user-report",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<List<PostGetIndexStatsItemsModel>>> GetIndexStats()
        {
            var result = await _app.Request<List<PostGetIndexStatsItemsModel>>(
                "admin/get-index-stats",
                true
            );
            return result;
        }

        public interface IPostGetIndexStatsItemsModel
        {
            public string Tablename { get; set; }
            public string Indexname { get; set; }
        }

        public class PostGetIndexStatsItemsModel : IPostGetIndexStatsItemsModel
        {
            public string Tablename { get; set; }
            public string Indexname { get; set; }
        }

        public async Task<Response<Dictionary<string, object>>> GetTableStats()
        {
            var result = await _app.Request<Dictionary<string, object>>(
                "admin/get-table-stats",
                true
            );
            return result;
        }

        public async Task<Response<List<PostGetUserIpsItemsModel>>> GetUserIps(string userId)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId }
            };
            var result = await _app.Request<List<PostGetUserIpsItemsModel>>(
                "admin/get-user-ips",
                param,
                true
            );
            return result;
        }

        public interface IPostGetUserIpsItemsModel
        {
            public string Ip { get; set; }
            public DateTime? CreatedAt { get; set; }
        }

        public class PostGetUserIpsItemsModel : IPostGetUserIpsItemsModel
        {
            public string Ip { get; set; }
            public DateTime? CreatedAt { get; set; }
        }

        public async Task<Response<PostMetaModel>> Meta()
        {
            var result = await _app.Request<PostMetaModel>(
                "admin/meta",
                true
            );
            return result;
        }

        public enum PostMetaFederationEnum
        {
            [EnumMember(Value = "all")] All,
            [EnumMember(Value = "specified")] Specified,
            [EnumMember(Value = "none")] None
        }

        public interface IPostMetaModel
        {
            public bool CacheRemoteFiles { get; set; }
            public bool CacheRemoteSensitiveFiles { get; set; }
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
            public string? MascotImageUrl { get; set; }
            public string? BannerUrl { get; set; }
            public string? ServerErrorImageUrl { get; set; }
            public string? InfoImageUrl { get; set; }
            public string? NotFoundImageUrl { get; set; }
            public string? IconUrl { get; set; }
            public string? App192IconUrl { get; set; }
            public string? App512IconUrl { get; set; }
            public bool EnableEmail { get; set; }
            public bool EnableServiceWorker { get; set; }
            public bool TranslatorAvailable { get; set; }
            public List<string> SilencedHosts { get; set; }
            public List<string> MediaSilencedHosts { get; set; }
            public List<string> PinnedUsers { get; set; }
            public List<string> HiddenTags { get; set; }
            public List<string> BlockedHosts { get; set; }
            public List<string> SensitiveWords { get; set; }
            public List<string> ProhibitedWords { get; set; }
            public List<string> ProhibitedWordsForNameOfUser { get; set; }
            public List<string> BannedEmailDomains { get; set; }
            public List<string> PreservedUsernames { get; set; }
            public string? HcaptchaSecretKey { get; set; }
            public string? McaptchaSecretKey { get; set; }
            public string? RecaptchaSecretKey { get; set; }
            public string? TurnstileSecretKey { get; set; }
            public string SensitiveMediaDetection { get; set; }
            public string SensitiveMediaDetectionSensitivity { get; set; }
            public bool SetSensitiveFlagAutomatically { get; set; }
            public bool EnableSensitiveMediaDetectionForVideos { get; set; }
            public string? ProxyAccountId { get; set; }
            public string? Email { get; set; }
            public bool SmtpSecure { get; set; }
            public string? SmtpHost { get; set; }
            public decimal? SmtpPort { get; set; }
            public string? SmtpUser { get; set; }
            public string? SmtpPass { get; set; }
            public string? SwPrivateKey { get; set; }
            public bool UseObjectStorage { get; set; }
            public string? ObjectStorageBaseUrl { get; set; }
            public string? ObjectStorageBucket { get; set; }
            public string? ObjectStoragePrefix { get; set; }
            public string? ObjectStorageEndpoint { get; set; }
            public string? ObjectStorageRegion { get; set; }
            public decimal? ObjectStoragePort { get; set; }
            public string? ObjectStorageAccessKey { get; set; }
            public string? ObjectStorageSecretKey { get; set; }
            public bool ObjectStorageUseSSL { get; set; }
            public bool ObjectStorageUseProxy { get; set; }
            public bool ObjectStorageSetPublicRead { get; set; }
            public bool EnableIpLogging { get; set; }
            public bool EnableActiveEmailValidation { get; set; }
            public bool EnableVerifymailApi { get; set; }
            public string? VerifymailAuthKey { get; set; }
            public bool EnableTruemailApi { get; set; }
            public string? TruemailInstance { get; set; }
            public string? TruemailAuthKey { get; set; }
            public bool EnableChartsForRemoteUser { get; set; }
            public bool EnableChartsForFederatedInstances { get; set; }
            public bool EnableStatsForFederatedInstances { get; set; }
            public bool EnableServerMachineStats { get; set; }
            public bool EnableIdenticonGeneration { get; set; }
            public string ManifestJsonOverride { get; set; }
            public JsonNode Policies { get; set; }
            public bool EnableFanoutTimeline { get; set; }
            public bool EnableFanoutTimelineDbFallback { get; set; }
            public decimal PerLocalUserUserTimelineCacheMax { get; set; }
            public decimal PerRemoteUserUserTimelineCacheMax { get; set; }
            public decimal PerUserHomeTimelineCacheMax { get; set; }
            public decimal PerUserListTimelineCacheMax { get; set; }
            public bool EnableReactionsBuffering { get; set; }
            public decimal NotesPerOneAd { get; set; }
            public string? BackgroundImageUrl { get; set; }
            public string? DeeplAuthKey { get; set; }
            public bool DeeplIsPro { get; set; }
            public string? DefaultDarkTheme { get; set; }
            public string? DefaultLightTheme { get; set; }
            public string? Description { get; set; }
            public bool DisableRegistration { get; set; }
            public string? ImpressumUrl { get; set; }
            public string? MaintainerEmail { get; set; }
            public string? MaintainerName { get; set; }
            public string? Name { get; set; }
            public string? ShortName { get; set; }
            public bool ObjectStorageS3ForcePathStyle { get; set; }
            public string? PrivacyPolicyUrl { get; set; }
            public string? InquiryUrl { get; set; }
            public string? RepositoryUrl { get; set; }
            public string? SummalyProxy { get; set; }
            public string? ThemeColor { get; set; }
            public string? TosUrl { get; set; }
            public string Uri { get; set; }
            public string Version { get; set; }
            public bool UrlPreviewEnabled { get; set; }
            public decimal UrlPreviewTimeout { get; set; }
            public decimal UrlPreviewMaximumContentLength { get; set; }
            public bool UrlPreviewRequireContentLength { get; set; }
            public string? UrlPreviewUserAgent { get; set; }
            public string? UrlPreviewSummaryProxyUrl { get; set; }
            public PostMetaFederationEnum Federation { get; set; }
            public List<string> FederationHosts { get; set; }
        }

        public class PostMetaModel : IPostMetaModel
        {
            public bool CacheRemoteFiles { get; set; }
            public bool CacheRemoteSensitiveFiles { get; set; }
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
            public string? MascotImageUrl { get; set; }
            public string? BannerUrl { get; set; }
            public string? ServerErrorImageUrl { get; set; }
            public string? InfoImageUrl { get; set; }
            public string? NotFoundImageUrl { get; set; }
            public string? IconUrl { get; set; }
            public string? App192IconUrl { get; set; }
            public string? App512IconUrl { get; set; }
            public bool EnableEmail { get; set; }
            public bool EnableServiceWorker { get; set; }
            public bool TranslatorAvailable { get; set; }
            public List<string> SilencedHosts { get; set; }
            public List<string> MediaSilencedHosts { get; set; }
            public List<string> PinnedUsers { get; set; }
            public List<string> HiddenTags { get; set; }
            public List<string> BlockedHosts { get; set; }
            public List<string> SensitiveWords { get; set; }
            public List<string> ProhibitedWords { get; set; }
            public List<string> ProhibitedWordsForNameOfUser { get; set; }
            public List<string> BannedEmailDomains { get; set; }
            public List<string> PreservedUsernames { get; set; }
            public string? HcaptchaSecretKey { get; set; }
            public string? McaptchaSecretKey { get; set; }
            public string? RecaptchaSecretKey { get; set; }
            public string? TurnstileSecretKey { get; set; }
            public string SensitiveMediaDetection { get; set; }
            public string SensitiveMediaDetectionSensitivity { get; set; }
            public bool SetSensitiveFlagAutomatically { get; set; }
            public bool EnableSensitiveMediaDetectionForVideos { get; set; }
            public string? ProxyAccountId { get; set; }
            public string? Email { get; set; }
            public bool SmtpSecure { get; set; }
            public string? SmtpHost { get; set; }
            public decimal? SmtpPort { get; set; }
            public string? SmtpUser { get; set; }
            public string? SmtpPass { get; set; }
            public string? SwPrivateKey { get; set; }
            public bool UseObjectStorage { get; set; }
            public string? ObjectStorageBaseUrl { get; set; }
            public string? ObjectStorageBucket { get; set; }
            public string? ObjectStoragePrefix { get; set; }
            public string? ObjectStorageEndpoint { get; set; }
            public string? ObjectStorageRegion { get; set; }
            public decimal? ObjectStoragePort { get; set; }
            public string? ObjectStorageAccessKey { get; set; }
            public string? ObjectStorageSecretKey { get; set; }
            public bool ObjectStorageUseSSL { get; set; }
            public bool ObjectStorageUseProxy { get; set; }
            public bool ObjectStorageSetPublicRead { get; set; }
            public bool EnableIpLogging { get; set; }
            public bool EnableActiveEmailValidation { get; set; }
            public bool EnableVerifymailApi { get; set; }
            public string? VerifymailAuthKey { get; set; }
            public bool EnableTruemailApi { get; set; }
            public string? TruemailInstance { get; set; }
            public string? TruemailAuthKey { get; set; }
            public bool EnableChartsForRemoteUser { get; set; }
            public bool EnableChartsForFederatedInstances { get; set; }
            public bool EnableStatsForFederatedInstances { get; set; }
            public bool EnableServerMachineStats { get; set; }
            public bool EnableIdenticonGeneration { get; set; }
            public string ManifestJsonOverride { get; set; }

            public JsonNode Policies { get; set; }

            public bool EnableFanoutTimeline { get; set; }
            public bool EnableFanoutTimelineDbFallback { get; set; }
            public decimal PerLocalUserUserTimelineCacheMax { get; set; }
            public decimal PerRemoteUserUserTimelineCacheMax { get; set; }
            public decimal PerUserHomeTimelineCacheMax { get; set; }
            public decimal PerUserListTimelineCacheMax { get; set; }
            public bool EnableReactionsBuffering { get; set; }
            public decimal NotesPerOneAd { get; set; }
            public string? BackgroundImageUrl { get; set; }
            public string? DeeplAuthKey { get; set; }
            public bool DeeplIsPro { get; set; }
            public string? DefaultDarkTheme { get; set; }
            public string? DefaultLightTheme { get; set; }
            public string? Description { get; set; }
            public bool DisableRegistration { get; set; }
            public string? ImpressumUrl { get; set; }
            public string? MaintainerEmail { get; set; }
            public string? MaintainerName { get; set; }
            public string? Name { get; set; }
            public string? ShortName { get; set; }
            public bool ObjectStorageS3ForcePathStyle { get; set; }
            public string? PrivacyPolicyUrl { get; set; }
            public string? InquiryUrl { get; set; }
            public string? RepositoryUrl { get; set; }
            public string? SummalyProxy { get; set; }
            public string? ThemeColor { get; set; }
            public string? TosUrl { get; set; }
            public string Uri { get; set; }
            public string Version { get; set; }
            public bool UrlPreviewEnabled { get; set; }
            public decimal UrlPreviewTimeout { get; set; }
            public decimal UrlPreviewMaximumContentLength { get; set; }
            public bool UrlPreviewRequireContentLength { get; set; }
            public string? UrlPreviewUserAgent { get; set; }
            public string? UrlPreviewSummaryProxyUrl { get; set; }
            public PostMetaFederationEnum Federation { get; set; }
            public List<string> FederationHosts { get; set; }
        }

        public async Task<Response<PostResetPasswordModel>> ResetPassword(string userId)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId }
            };
            var result = await _app.Request<PostResetPasswordModel>(
                "admin/reset-password",
                param,
                true
            );
            return result;
        }

        public interface IPostResetPasswordModel
        {
            public string Password { get; set; }
        }

        public class PostResetPasswordModel : IPostResetPasswordModel
        {
            public string Password { get; set; }
        }

        public async Task<Response<EmptyResponse>> ResolveAbuseUserReport(string reportId,
            AdminResolveAbuseUserReportPropertiesResolvedAsEnum? resolvedAs = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "reportId", reportId },
                { "resolvedAs", resolvedAs }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/resolve-abuse-user-report",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public enum AdminResolveAbuseUserReportPropertiesResolvedAsEnum
        {
            [EnumMember(Value = "accept")] Accept,
            [EnumMember(Value = "reject")] Reject
        }

        public async Task<Response<EmptyResponse>> SendEmail(string to, string subject, string text)
        {
            var param = new Dictionary<string, object?>
            {
                { "to", to },
                { "subject", subject },
                { "text", text }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/send-email",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<PostServerInfoModel>> ServerInfo()
        {
            var result = await _app.Request<PostServerInfoModel>(
                "admin/server-info",
                true
            );
            return result;
        }

        public interface IPostServerInfoCpuModel
        {
            public string Model { get; set; }
            public decimal Cores { get; set; }
        }

        public class PostServerInfoCpuModel : IPostServerInfoCpuModel
        {
            public string Model { get; set; }
            public decimal Cores { get; set; }
        }

        public interface IPostServerInfoMemModel
        {
            public decimal Total { get; set; }
        }

        public class PostServerInfoMemModel : IPostServerInfoMemModel
        {
            public decimal Total { get; set; }
        }

        public interface IPostServerInfoFsModel
        {
            public decimal Total { get; set; }
            public decimal Used { get; set; }
        }

        public class PostServerInfoFsModel : IPostServerInfoFsModel
        {
            public decimal Total { get; set; }
            public decimal Used { get; set; }
        }

        public interface IPostServerInfoNetModel
        {
            public string Interface { get; set; }
        }

        public class PostServerInfoNetModel : IPostServerInfoNetModel
        {
            public string Interface { get; set; }
        }

        public interface IPostServerInfoModel
        {
            public string Machine { get; set; }
            public string Os { get; set; }
            public string Node { get; set; }
            public string Psql { get; set; }
            public PostServerInfoCpuModel Cpu { get; set; }
            public PostServerInfoMemModel Mem { get; set; }
            public PostServerInfoFsModel Fs { get; set; }
            public PostServerInfoNetModel Net { get; set; }
        }

        public class PostServerInfoModel : IPostServerInfoModel
        {
            public string Machine { get; set; }
            public string Os { get; set; }
            public string Node { get; set; }
            public string Psql { get; set; }
            public PostServerInfoCpuModel Cpu { get; set; }
            public PostServerInfoMemModel Mem { get; set; }
            public PostServerInfoFsModel Fs { get; set; }
            public PostServerInfoNetModel Net { get; set; }
        }

        public async Task<Response<List<PostShowModerationLogsItemsModel>>> ShowModerationLogs(int limit = 10,
            string? sinceId = null, string? untilId = null, string? type = null, string? userId = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "type", type },
                { "userId", userId }
            };
            var result = await _app.Request<List<PostShowModerationLogsItemsModel>>(
                "admin/show-moderation-logs",
                param,
                true
            );
            return result;
        }

        public interface IPostShowModerationLogsItemsModel
        {
            public string Id { get; set; }
            public DateTime? CreatedAt { get; set; }
            public string Type { get; set; }

            public JsonNode Info { get; set; }

            public string UserId { get; set; }
            public UserDetailedNotMeModel User { get; set; }
        }

        public class PostShowModerationLogsItemsModel : IPostShowModerationLogsItemsModel
        {
            public string Id { get; set; }
            public DateTime? CreatedAt { get; set; }
            public string Type { get; set; }

            public JsonNode Info { get; set; }

            public string UserId { get; set; }
            public UserDetailedNotMeModel User { get; set; }
        }

        public async Task<Response<PostShowUserModel>> ShowUser(string userId)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId }
            };
            var result = await _app.Request<PostShowUserModel>(
                "admin/show-user",
                param,
                true
            );
            return result;
        }

        public interface IPostShowUserNotificationRecieveConfigModel
        {
            public object Note { get; set; }
            public object Follow { get; set; }
            public object Mention { get; set; }
            public object Reply { get; set; }
            public object Renote { get; set; }
            public object Quote { get; set; }
            public object Reaction { get; set; }
            public object PollEnded { get; set; }
            public object ReceiveFollowRequest { get; set; }
            public object FollowRequestAccepted { get; set; }
            public object RoleAssigned { get; set; }
            public object AchievementEarned { get; set; }
            public object App { get; set; }
            public object Test { get; set; }
        }

        public class PostShowUserNotificationRecieveConfigModel : IPostShowUserNotificationRecieveConfigModel
        {
            public object Note { get; set; }
            public object Follow { get; set; }
            public object Mention { get; set; }
            public object Reply { get; set; }
            public object Renote { get; set; }
            public object Quote { get; set; }
            public object Reaction { get; set; }
            public object PollEnded { get; set; }
            public object ReceiveFollowRequest { get; set; }
            public object FollowRequestAccepted { get; set; }
            public object RoleAssigned { get; set; }
            public object AchievementEarned { get; set; }
            public object App { get; set; }
            public object Test { get; set; }
        }

        public interface IPostShowUserRoleAssignsItemsModel
        {
            public string CreatedAt { get; set; }
            public string? ExpiresAt { get; set; }
            public string RoleId { get; set; }
        }

        public class PostShowUserRoleAssignsItemsModel : IPostShowUserRoleAssignsItemsModel
        {
            public string CreatedAt { get; set; }
            public string? ExpiresAt { get; set; }
            public string RoleId { get; set; }
        }

        public interface IPostShowUserModel
        {
            public string? Email { get; set; }
            public bool EmailVerified { get; set; }
            public string? FollowedMessage { get; set; }
            public bool AutoAcceptFollowed { get; set; }
            public bool NoCrawle { get; set; }
            public bool PreventAiLearning { get; set; }
            public bool AlwaysMarkNsfw { get; set; }
            public bool AutoSensitive { get; set; }
            public bool CarefulBot { get; set; }
            public bool InjectFeaturedNote { get; set; }
            public bool ReceiveAnnouncementEmail { get; set; }
            public List<List<string>> MutedWords { get; set; }
            public List<string> MutedInstances { get; set; }
            public PostShowUserNotificationRecieveConfigModel NotificationRecieveConfig { get; set; }
            public bool IsModerator { get; set; }
            public bool IsSilenced { get; set; }
            public bool IsSuspended { get; set; }
            public bool IsHibernated { get; set; }
            public string? LastActiveDate { get; set; }
            public string ModerationNote { get; set; }
            public List<SigninModel> Signins { get; set; }
            public RolePoliciesModel Policies { get; set; }
            public List<RoleModel> Roles { get; set; }
            public List<PostShowUserRoleAssignsItemsModel> RoleAssigns { get; set; }
        }

        public class PostShowUserModel : IPostShowUserModel
        {
            public string? Email { get; set; }
            public bool EmailVerified { get; set; }
            public string? FollowedMessage { get; set; }
            public bool AutoAcceptFollowed { get; set; }
            public bool NoCrawle { get; set; }
            public bool PreventAiLearning { get; set; }
            public bool AlwaysMarkNsfw { get; set; }
            public bool AutoSensitive { get; set; }
            public bool CarefulBot { get; set; }
            public bool InjectFeaturedNote { get; set; }
            public bool ReceiveAnnouncementEmail { get; set; }
            public List<List<string>> MutedWords { get; set; }
            public List<string> MutedInstances { get; set; }
            public PostShowUserNotificationRecieveConfigModel NotificationRecieveConfig { get; set; }
            public bool IsModerator { get; set; }
            public bool IsSilenced { get; set; }
            public bool IsSuspended { get; set; }
            public bool IsHibernated { get; set; }
            public string? LastActiveDate { get; set; }
            public string ModerationNote { get; set; }
            public List<SigninModel> Signins { get; set; }
            public RolePoliciesModel Policies { get; set; }
            public List<RoleModel> Roles { get; set; }
            public List<PostShowUserRoleAssignsItemsModel> RoleAssigns { get; set; }
        }

        public async Task<Response<List<UserDetailedModel>>> ShowUsers(AdminShowUsersPropertiesSortEnum sort,
            int limit = 10, int offset = 0,
            AdminShowUsersPropertiesStateEnum state = AdminShowUsersPropertiesStateEnum.All,
            AdminShowUsersPropertiesOriginEnum origin = AdminShowUsersPropertiesOriginEnum.Combined,
            string? username = null, string? hostname = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "offset", offset },
                { "sort", sort },
                { "state", state },
                { "origin", origin },
                { "username", username },
                { "hostname", hostname }
            };
            var result = await _app.Request<List<UserDetailedModel>>(
                "admin/show-users",
                param,
                true
            );
            return result;
        }

        public enum AdminShowUsersPropertiesSortEnum
        {
            [EnumMember(Value = "+follower")] Plusfollower,
            [EnumMember(Value = "-follower")] Minusfollower,
            [EnumMember(Value = "+createdAt")] PluscreatedAt,
            [EnumMember(Value = "-createdAt")] MinuscreatedAt,
            [EnumMember(Value = "+updatedAt")] PlusupdatedAt,
            [EnumMember(Value = "-updatedAt")] MinusupdatedAt,

            [EnumMember(Value = "+lastActiveDate")]
            PluslastActiveDate,

            [EnumMember(Value = "-lastActiveDate")]
            MinuslastActiveDate
        }

        public enum AdminShowUsersPropertiesStateEnum
        {
            [EnumMember(Value = "all")] All,
            [EnumMember(Value = "alive")] Alive,
            [EnumMember(Value = "available")] Available,
            [EnumMember(Value = "admin")] Admin,
            [EnumMember(Value = "moderator")] Moderator,

            [EnumMember(Value = "adminOrModerator")]
            AdminOrModerator,
            [EnumMember(Value = "suspended")] Suspended
        }

        public enum AdminShowUsersPropertiesOriginEnum
        {
            [EnumMember(Value = "combined")] Combined,
            [EnumMember(Value = "local")] Local,
            [EnumMember(Value = "remote")] Remote
        }

        public async Task<Response<EmptyResponse>> SuspendUser(string userId)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/suspend-user",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> UnsetUserAvatar(string userId)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/unset-user-avatar",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> UnsetUserBanner(string userId)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/unset-user-banner",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> UnsuspendUser(string userId)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/unsuspend-user",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> UpdateAbuseUserReport(string reportId, string moderationNote)
        {
            var param = new Dictionary<string, object?>
            {
                { "reportId", reportId },
                { "moderationNote", moderationNote }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/update-abuse-user-report",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> UpdateMeta(bool cacheRemoteFiles, bool cacheRemoteSensitiveFiles,
            bool emailRequiredForSignup, bool enableHcaptcha, bool enableMcaptcha, bool enableRecaptcha,
            bool enableTurnstile, bool enableTestcaptcha,
            AdminUpdateMetaPropertiesSensitiveMediaDetectionEnum sensitiveMediaDetection,
            AdminUpdateMetaPropertiesSensitiveMediaDetectionSensitivityEnum sensitiveMediaDetectionSensitivity,
            bool setSensitiveFlagAutomatically, bool enableSensitiveMediaDetectionForVideos, bool deeplIsPro,
            bool enableEmail, bool smtpSecure, bool enableServiceWorker, bool useObjectStorage,
            bool objectStorageUseSSL, bool objectStorageUseProxy, bool objectStorageSetPublicRead,
            bool objectStorageS3ForcePathStyle, bool enableIpLogging, bool enableActiveEmailValidation,
            bool enableVerifymailApi, bool enableTruemailApi, bool enableChartsForRemoteUser,
            bool enableChartsForFederatedInstances, bool enableStatsForFederatedInstances,
            bool enableServerMachineStats, bool enableIdenticonGeneration, string manifestJsonOverride,
            bool enableFanoutTimeline, bool enableFanoutTimelineDbFallback, int perLocalUserUserTimelineCacheMax,
            int perRemoteUserUserTimelineCacheMax, int perUserHomeTimelineCacheMax, int perUserListTimelineCacheMax,
            bool enableReactionsBuffering, int notesPerOneAd, bool urlPreviewEnabled, int urlPreviewTimeout,
            int urlPreviewMaximumContentLength, bool urlPreviewRequireContentLength,
            AdminUpdateMetaPropertiesFederationEnum federation, bool? disableRegistration = null,
            List<string>? pinnedUsers = null, List<string>? hiddenTags = null, List<string>? blockedHosts = null,
            List<string>? sensitiveWords = null, List<string>? prohibitedWords = null,
            List<string>? prohibitedWordsForNameOfUser = null, string? themeColor = null, string? mascotImageUrl = null,
            string? bannerUrl = null, string? serverErrorImageUrl = null, string? infoImageUrl = null,
            string? notFoundImageUrl = null, string? iconUrl = null, string? app192IconUrl = null,
            string? app512IconUrl = null, string? backgroundImageUrl = null, string? logoImageUrl = null,
            string? name = null, string? shortName = null, string? description = null, string? defaultLightTheme = null,
            string? defaultDarkTheme = null, string? hcaptchaSiteKey = null, string? hcaptchaSecretKey = null,
            string? mcaptchaSiteKey = null, string? mcaptchaInstanceUrl = null, string? mcaptchaSecretKey = null,
            string? recaptchaSiteKey = null, string? recaptchaSecretKey = null, string? turnstileSiteKey = null,
            string? turnstileSecretKey = null, string? googleAnalyticsMeasurementId = null,
            string? proxyAccountId = null, string? maintainerName = null, string? maintainerEmail = null,
            List<string>? langs = null, string? deeplAuthKey = null, string? email = null, string? smtpHost = null,
            int? smtpPort = null, string? smtpUser = null, string? smtpPass = null, string? swPublicKey = null,
            string? swPrivateKey = null, string? tosUrl = null, string? repositoryUrl = null,
            string? feedbackUrl = null, string? impressumUrl = null, string? privacyPolicyUrl = null,
            string? inquiryUrl = null, string? objectStorageBaseUrl = null, string? objectStorageBucket = null,
            string? objectStoragePrefix = null, string? objectStorageEndpoint = null,
            string? objectStorageRegion = null, int? objectStoragePort = null, string? objectStorageAccessKey = null,
            string? objectStorageSecretKey = null, string? verifymailAuthKey = null, string? truemailInstance = null,
            string? truemailAuthKey = null, List<string>? serverRules = null, List<string>? bannedEmailDomains = null,
            List<string>? preservedUsernames = null, List<string>? silencedHosts = null,
            List<string>? mediaSilencedHosts = null, string? summalyProxy = null, string? urlPreviewUserAgent = null,
            string? urlPreviewSummaryProxyUrl = null, List<string>? federationHosts = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "disableRegistration", disableRegistration },
                { "pinnedUsers", pinnedUsers },
                { "hiddenTags", hiddenTags },
                { "blockedHosts", blockedHosts },
                { "sensitiveWords", sensitiveWords },
                { "prohibitedWords", prohibitedWords },
                { "prohibitedWordsForNameOfUser", prohibitedWordsForNameOfUser },
                { "themeColor", themeColor },
                { "mascotImageUrl", mascotImageUrl },
                { "bannerUrl", bannerUrl },
                { "serverErrorImageUrl", serverErrorImageUrl },
                { "infoImageUrl", infoImageUrl },
                { "notFoundImageUrl", notFoundImageUrl },
                { "iconUrl", iconUrl },
                { "app192IconUrl", app192IconUrl },
                { "app512IconUrl", app512IconUrl },
                { "backgroundImageUrl", backgroundImageUrl },
                { "logoImageUrl", logoImageUrl },
                { "name", name },
                { "shortName", shortName },
                { "description", description },
                { "defaultLightTheme", defaultLightTheme },
                { "defaultDarkTheme", defaultDarkTheme },
                { "cacheRemoteFiles", cacheRemoteFiles },
                { "cacheRemoteSensitiveFiles", cacheRemoteSensitiveFiles },
                { "emailRequiredForSignup", emailRequiredForSignup },
                { "enableHcaptcha", enableHcaptcha },
                { "hcaptchaSiteKey", hcaptchaSiteKey },
                { "hcaptchaSecretKey", hcaptchaSecretKey },
                { "enableMcaptcha", enableMcaptcha },
                { "mcaptchaSiteKey", mcaptchaSiteKey },
                { "mcaptchaInstanceUrl", mcaptchaInstanceUrl },
                { "mcaptchaSecretKey", mcaptchaSecretKey },
                { "enableRecaptcha", enableRecaptcha },
                { "recaptchaSiteKey", recaptchaSiteKey },
                { "recaptchaSecretKey", recaptchaSecretKey },
                { "enableTurnstile", enableTurnstile },
                { "turnstileSiteKey", turnstileSiteKey },
                { "turnstileSecretKey", turnstileSecretKey },
                { "enableTestcaptcha", enableTestcaptcha },
                { "googleAnalyticsMeasurementId", googleAnalyticsMeasurementId },
                { "sensitiveMediaDetection", sensitiveMediaDetection },
                { "sensitiveMediaDetectionSensitivity", sensitiveMediaDetectionSensitivity },
                { "setSensitiveFlagAutomatically", setSensitiveFlagAutomatically },
                { "enableSensitiveMediaDetectionForVideos", enableSensitiveMediaDetectionForVideos },
                { "proxyAccountId", proxyAccountId },
                { "maintainerName", maintainerName },
                { "maintainerEmail", maintainerEmail },
                { "langs", langs },
                { "deeplAuthKey", deeplAuthKey },
                { "deeplIsPro", deeplIsPro },
                { "enableEmail", enableEmail },
                { "email", email },
                { "smtpSecure", smtpSecure },
                { "smtpHost", smtpHost },
                { "smtpPort", smtpPort },
                { "smtpUser", smtpUser },
                { "smtpPass", smtpPass },
                { "enableServiceWorker", enableServiceWorker },
                { "swPublicKey", swPublicKey },
                { "swPrivateKey", swPrivateKey },
                { "tosUrl", tosUrl },
                { "repositoryUrl", repositoryUrl },
                { "feedbackUrl", feedbackUrl },
                { "impressumUrl", impressumUrl },
                { "privacyPolicyUrl", privacyPolicyUrl },
                { "inquiryUrl", inquiryUrl },
                { "useObjectStorage", useObjectStorage },
                { "objectStorageBaseUrl", objectStorageBaseUrl },
                { "objectStorageBucket", objectStorageBucket },
                { "objectStoragePrefix", objectStoragePrefix },
                { "objectStorageEndpoint", objectStorageEndpoint },
                { "objectStorageRegion", objectStorageRegion },
                { "objectStoragePort", objectStoragePort },
                { "objectStorageAccessKey", objectStorageAccessKey },
                { "objectStorageSecretKey", objectStorageSecretKey },
                { "objectStorageUseSSL", objectStorageUseSSL },
                { "objectStorageUseProxy", objectStorageUseProxy },
                { "objectStorageSetPublicRead", objectStorageSetPublicRead },
                { "objectStorageS3ForcePathStyle", objectStorageS3ForcePathStyle },
                { "enableIpLogging", enableIpLogging },
                { "enableActiveEmailValidation", enableActiveEmailValidation },
                { "enableVerifymailApi", enableVerifymailApi },
                { "verifymailAuthKey", verifymailAuthKey },
                { "enableTruemailApi", enableTruemailApi },
                { "truemailInstance", truemailInstance },
                { "truemailAuthKey", truemailAuthKey },
                { "enableChartsForRemoteUser", enableChartsForRemoteUser },
                { "enableChartsForFederatedInstances", enableChartsForFederatedInstances },
                { "enableStatsForFederatedInstances", enableStatsForFederatedInstances },
                { "enableServerMachineStats", enableServerMachineStats },
                { "enableIdenticonGeneration", enableIdenticonGeneration },
                { "serverRules", serverRules },
                { "bannedEmailDomains", bannedEmailDomains },
                { "preservedUsernames", preservedUsernames },
                { "manifestJsonOverride", manifestJsonOverride },
                { "enableFanoutTimeline", enableFanoutTimeline },
                { "enableFanoutTimelineDbFallback", enableFanoutTimelineDbFallback },
                { "perLocalUserUserTimelineCacheMax", perLocalUserUserTimelineCacheMax },
                { "perRemoteUserUserTimelineCacheMax", perRemoteUserUserTimelineCacheMax },
                { "perUserHomeTimelineCacheMax", perUserHomeTimelineCacheMax },
                { "perUserListTimelineCacheMax", perUserListTimelineCacheMax },
                { "enableReactionsBuffering", enableReactionsBuffering },
                { "notesPerOneAd", notesPerOneAd },
                { "silencedHosts", silencedHosts },
                { "mediaSilencedHosts", mediaSilencedHosts },
                { "summalyProxy", summalyProxy },
                { "urlPreviewEnabled", urlPreviewEnabled },
                { "urlPreviewTimeout", urlPreviewTimeout },
                { "urlPreviewMaximumContentLength", urlPreviewMaximumContentLength },
                { "urlPreviewRequireContentLength", urlPreviewRequireContentLength },
                { "urlPreviewUserAgent", urlPreviewUserAgent },
                { "urlPreviewSummaryProxyUrl", urlPreviewSummaryProxyUrl },
                { "federation", federation },
                { "federationHosts", federationHosts }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/update-meta",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public enum AdminUpdateMetaPropertiesSensitiveMediaDetectionEnum
        {
            [EnumMember(Value = "none")] None,
            [EnumMember(Value = "all")] All,
            [EnumMember(Value = "local")] Local,
            [EnumMember(Value = "remote")] Remote
        }

        public enum AdminUpdateMetaPropertiesSensitiveMediaDetectionSensitivityEnum
        {
            [EnumMember(Value = "medium")] Medium,
            [EnumMember(Value = "low")] Low,
            [EnumMember(Value = "high")] High,
            [EnumMember(Value = "veryLow")] VeryLow,
            [EnumMember(Value = "veryHigh")] VeryHigh
        }

        public enum AdminUpdateMetaPropertiesFederationEnum
        {
            [EnumMember(Value = "all")] All,
            [EnumMember(Value = "none")] None,
            [EnumMember(Value = "specified")] Specified
        }

        public async Task<Response<EmptyResponse>> UpdateUserNote(string userId, string text)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
                { "text", text }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/update-user-note",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public readonly Admin.AccountsApi AccountsApi;
        public readonly Admin.AdApi AdApi;
        public readonly Admin.AnnouncementsApi AnnouncementsApi;
        public readonly Admin.AvatarDecorationsApi AvatarDecorationsApi;
        public readonly Admin.CaptchaApi CaptchaApi;
        public readonly Admin.DriveApi DriveApi;
        public readonly Admin.EmojiApi EmojiApi;
        public readonly Admin.FederationApi FederationApi;
        public readonly Admin.InviteApi InviteApi;
        public readonly Admin.PromoApi PromoApi;
        public readonly Admin.QueueApi QueueApi;
        public readonly Admin.RelaysApi RelaysApi;
        public readonly Admin.RolesApi RolesApi;
        public readonly Admin.SystemWebhookApi SystemWebhookApi;

        public AdminApi(App app)
        {
            _app = app;
            AccountsApi = new Admin.AccountsApi(_app);
            AdApi = new Admin.AdApi(_app);
            AnnouncementsApi = new Admin.AnnouncementsApi(_app);
            AvatarDecorationsApi = new Admin.AvatarDecorationsApi(_app);
            CaptchaApi = new Admin.CaptchaApi(_app);
            DriveApi = new Admin.DriveApi(_app);
            EmojiApi = new Admin.EmojiApi(_app);
            FederationApi = new Admin.FederationApi(_app);
            InviteApi = new Admin.InviteApi(_app);
            PromoApi = new Admin.PromoApi(_app);
            QueueApi = new Admin.QueueApi(_app);
            RelaysApi = new Admin.RelaysApi(_app);
            RolesApi = new Admin.RolesApi(_app);
            SystemWebhookApi = new Admin.SystemWebhookApi(_app);
        }
    }
}

namespace Misharp.Controls.Admin
{
    public class AccountsApi
    {
        private readonly App _app;

        public AccountsApi(App app)
        {
            _app = app;
        }

        public async Task<Response<MeDetailedModel>> Create(string username, string password,
            string? setupPassword = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "username", username },
                { "password", password },
                { "setupPassword", setupPassword }
            };
            var result = await _app.Request<MeDetailedModel>(
                "admin/accounts/create",
                param,
                false
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> Delete(string userId)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/accounts/delete",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<UserDetailedNotMeModel>> FindByEmail(string email)
        {
            var param = new Dictionary<string, object?>
            {
                { "email", email }
            };
            var result = await _app.Request<UserDetailedNotMeModel>(
                "admin/accounts/find-by-email",
                param,
                true
            );
            return result;
        }
    }
}

namespace Misharp.Controls.Admin
{
    public class AdApi
    {
        private readonly App _app;

        public AdApi(App app)
        {
            _app = app;
        }

        public async Task<Response<AdModel>> Create(string url, string memo, string place, string priority, int ratio,
            int expiresAt, int startsAt, string imageUrl, int dayOfWeek)
        {
            var param = new Dictionary<string, object?>
            {
                { "url", url },
                { "memo", memo },
                { "place", place },
                { "priority", priority },
                { "ratio", ratio },
                { "expiresAt", expiresAt },
                { "startsAt", startsAt },
                { "imageUrl", imageUrl },
                { "dayOfWeek", dayOfWeek }
            };
            var result = await _app.Request<AdModel>(
                "admin/ad/create",
                param,
                true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> Delete(string id)
        {
            var param = new Dictionary<string, object?>
            {
                { "id", id }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/ad/delete",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<List<AdModel>>> List(int limit = 10, string? sinceId = null, string? untilId = null,
            bool? publishing = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "publishing", publishing }
            };
            var result = await _app.Request<List<AdModel>>(
                "admin/ad/list",
                param,
                true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> Update(string id, string memo, string url, string imageUrl,
            string place, string priority, int ratio, int expiresAt, int startsAt, int dayOfWeek)
        {
            var param = new Dictionary<string, object?>
            {
                { "id", id },
                { "memo", memo },
                { "url", url },
                { "imageUrl", imageUrl },
                { "place", place },
                { "priority", priority },
                { "ratio", ratio },
                { "expiresAt", expiresAt },
                { "startsAt", startsAt },
                { "dayOfWeek", dayOfWeek }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/ad/update",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }
    }
}

namespace Misharp.Controls.Admin
{
    public class AnnouncementsApi
    {
        private readonly App _app;

        public AnnouncementsApi(App app)
        {
            _app = app;
        }

        public async Task<Response<PostCreateModel>> Create(string title, string text, string? imageUrl = null,
            AdminAnnouncementsCreatePropertiesIconEnum icon = AdminAnnouncementsCreatePropertiesIconEnum.Info,
            AdminAnnouncementsCreatePropertiesDisplayEnum display =
                AdminAnnouncementsCreatePropertiesDisplayEnum.Normal, bool forExistingUsers = false,
            bool silence = false, bool needConfirmationToRead = false, string? userId = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "title", title },
                { "text", text },
                { "imageUrl", imageUrl },
                { "icon", icon },
                { "display", display },
                { "forExistingUsers", forExistingUsers },
                { "silence", silence },
                { "needConfirmationToRead", needConfirmationToRead },
                { "userId", userId }
            };
            var result = await _app.Request<PostCreateModel>(
                "admin/announcements/create",
                param,
                true
            );
            return result;
        }

        public enum AdminAnnouncementsCreatePropertiesIconEnum
        {
            [EnumMember(Value = "info")] Info,
            [EnumMember(Value = "warning")] Warning,
            [EnumMember(Value = "error")] Error,
            [EnumMember(Value = "success")] Success
        }

        public enum AdminAnnouncementsCreatePropertiesDisplayEnum
        {
            [EnumMember(Value = "normal")] Normal,
            [EnumMember(Value = "banner")] Banner,
            [EnumMember(Value = "dialog")] Dialog
        }

        public interface IPostCreateModel
        {
            public string Id { get; set; }
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
            public string Title { get; set; }
            public string Text { get; set; }
            public string? ImageUrl { get; set; }
        }

        public class PostCreateModel : IPostCreateModel
        {
            public string Id { get; set; }
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
            public string Title { get; set; }
            public string Text { get; set; }
            public string? ImageUrl { get; set; }
        }

        public async Task<Response<EmptyResponse>> Delete(string id)
        {
            var param = new Dictionary<string, object?>
            {
                { "id", id }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/announcements/delete",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<List<PostListItemsModel>>> List(int limit = 10, string? sinceId = null,
            string? untilId = null, string? userId = null,
            AdminAnnouncementsListPropertiesStatusEnum status = AdminAnnouncementsListPropertiesStatusEnum.Active)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "userId", userId },
                { "status", status }
            };
            var result = await _app.Request<List<PostListItemsModel>>(
                "admin/announcements/list",
                param,
                true
            );
            return result;
        }

        public enum AdminAnnouncementsListPropertiesStatusEnum
        {
            [EnumMember(Value = "all")] All,
            [EnumMember(Value = "active")] Active,
            [EnumMember(Value = "archived")] Archived
        }

        public interface IPostListItemsModel
        {
            public string Id { get; set; }
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
            public string Text { get; set; }
            public string Title { get; set; }
            public string? ImageUrl { get; set; }
            public decimal Reads { get; set; }
        }

        public class PostListItemsModel : IPostListItemsModel
        {
            public string Id { get; set; }
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
            public string Text { get; set; }
            public string Title { get; set; }
            public string? ImageUrl { get; set; }
            public decimal Reads { get; set; }
        }

        public async Task<Response<EmptyResponse>> Update(string id, string title, string text,
            AdminAnnouncementsUpdatePropertiesIconEnum icon, AdminAnnouncementsUpdatePropertiesDisplayEnum display,
            bool forExistingUsers, bool silence, bool needConfirmationToRead, bool isActive, string? imageUrl = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "id", id },
                { "title", title },
                { "text", text },
                { "imageUrl", imageUrl },
                { "icon", icon },
                { "display", display },
                { "forExistingUsers", forExistingUsers },
                { "silence", silence },
                { "needConfirmationToRead", needConfirmationToRead },
                { "isActive", isActive }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/announcements/update",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public enum AdminAnnouncementsUpdatePropertiesIconEnum
        {
            [EnumMember(Value = "info")] Info,
            [EnumMember(Value = "warning")] Warning,
            [EnumMember(Value = "error")] Error,
            [EnumMember(Value = "success")] Success
        }

        public enum AdminAnnouncementsUpdatePropertiesDisplayEnum
        {
            [EnumMember(Value = "normal")] Normal,
            [EnumMember(Value = "banner")] Banner,
            [EnumMember(Value = "dialog")] Dialog
        }
    }
}

namespace Misharp.Controls.Admin
{
    public class AvatarDecorationsApi
    {
        private readonly App _app;

        public AvatarDecorationsApi(App app)
        {
            _app = app;
        }

        public async Task<Response<PostCreateModel>> Create(string name, string description, string url,
            List<string>? roleIdsThatCanBeUsedThisDecoration = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "name", name },
                { "description", description },
                { "url", url },
                { "roleIdsThatCanBeUsedThisDecoration", roleIdsThatCanBeUsedThisDecoration }
            };
            var result = await _app.Request<PostCreateModel>(
                "admin/avatar-decorations/create",
                param,
                true
            );
            return result;
        }

        public interface IPostCreateModel
        {
            public string Id { get; set; }
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Url { get; set; }
            public List<string> RoleIdsThatCanBeUsedThisDecoration { get; set; }
        }

        public class PostCreateModel : IPostCreateModel
        {
            public string Id { get; set; }
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Url { get; set; }
            public List<string> RoleIdsThatCanBeUsedThisDecoration { get; set; }
        }

        public async Task<Response<EmptyResponse>> Delete(string id)
        {
            var param = new Dictionary<string, object?>
            {
                { "id", id }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/avatar-decorations/delete",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<List<PostListItemsModel>>> List(int limit = 10, string? sinceId = null,
            string? untilId = null, string? userId = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "userId", userId }
            };
            var result = await _app.Request<List<PostListItemsModel>>(
                "admin/avatar-decorations/list",
                param,
                true
            );
            return result;
        }

        public interface IPostListItemsModel
        {
            public string Id { get; set; }
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Url { get; set; }
            public List<string> RoleIdsThatCanBeUsedThisDecoration { get; set; }
        }

        public class PostListItemsModel : IPostListItemsModel
        {
            public string Id { get; set; }
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Url { get; set; }
            public List<string> RoleIdsThatCanBeUsedThisDecoration { get; set; }
        }

        public async Task<Response<EmptyResponse>> Update(string id, string name, string description, string url,
            List<string>? roleIdsThatCanBeUsedThisDecoration = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "id", id },
                { "name", name },
                { "description", description },
                { "url", url },
                { "roleIdsThatCanBeUsedThisDecoration", roleIdsThatCanBeUsedThisDecoration }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/avatar-decorations/update",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }
    }
}

namespace Misharp.Controls.Admin
{
    public class CaptchaApi
    {
        private readonly App _app;

        public CaptchaApi(App app)
        {
            _app = app;
        }

        public async Task<Response<PostCurrentModel>> Current()
        {
            var result = await _app.Request<PostCurrentModel>(
                "admin/captcha/current",
                true
            );
            return result;
        }

        public enum PostCurrentProviderEnum
        {
            [EnumMember(Value = "none")] None,
            [EnumMember(Value = "hcaptcha")] Hcaptcha,
            [EnumMember(Value = "mcaptcha")] Mcaptcha,
            [EnumMember(Value = "recaptcha")] Recaptcha,
            [EnumMember(Value = "turnstile")] Turnstile,
            [EnumMember(Value = "testcaptcha")] Testcaptcha
        }

        public interface IPostCurrentHcaptchaModel
        {
            public string? SiteKey { get; set; }
            public string? SecretKey { get; set; }
        }

        public class PostCurrentHcaptchaModel : IPostCurrentHcaptchaModel
        {
            public string? SiteKey { get; set; }
            public string? SecretKey { get; set; }
        }

        public interface IPostCurrentMcaptchaModel
        {
            public string? SiteKey { get; set; }
            public string? SecretKey { get; set; }
            public string? InstanceUrl { get; set; }
        }

        public class PostCurrentMcaptchaModel : IPostCurrentMcaptchaModel
        {
            public string? SiteKey { get; set; }
            public string? SecretKey { get; set; }
            public string? InstanceUrl { get; set; }
        }

        public interface IPostCurrentRecaptchaModel
        {
            public string? SiteKey { get; set; }
            public string? SecretKey { get; set; }
        }

        public class PostCurrentRecaptchaModel : IPostCurrentRecaptchaModel
        {
            public string? SiteKey { get; set; }
            public string? SecretKey { get; set; }
        }

        public interface IPostCurrentTurnstileModel
        {
            public string? SiteKey { get; set; }
            public string? SecretKey { get; set; }
        }

        public class PostCurrentTurnstileModel : IPostCurrentTurnstileModel
        {
            public string? SiteKey { get; set; }
            public string? SecretKey { get; set; }
        }

        public interface IPostCurrentModel
        {
            public PostCurrentProviderEnum Provider { get; set; }
            public PostCurrentHcaptchaModel Hcaptcha { get; set; }
            public PostCurrentMcaptchaModel Mcaptcha { get; set; }
            public PostCurrentRecaptchaModel Recaptcha { get; set; }
            public PostCurrentTurnstileModel Turnstile { get; set; }
        }

        public class PostCurrentModel : IPostCurrentModel
        {
            public PostCurrentProviderEnum Provider { get; set; }
            public PostCurrentHcaptchaModel Hcaptcha { get; set; }
            public PostCurrentMcaptchaModel Mcaptcha { get; set; }
            public PostCurrentRecaptchaModel Recaptcha { get; set; }
            public PostCurrentTurnstileModel Turnstile { get; set; }
        }

        public async Task<Response<EmptyResponse>> Save(AdminCaptchaSavePropertiesProviderEnum provider,
            string? captchaResult = null, string? sitekey = null, string? secret = null, string? instanceUrl = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "provider", provider },
                { "captchaResult", captchaResult },
                { "sitekey", sitekey },
                { "secret", secret },
                { "instanceUrl", instanceUrl }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/captcha/save",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public enum AdminCaptchaSavePropertiesProviderEnum
        {
            [EnumMember(Value = "none")] None,
            [EnumMember(Value = "hcaptcha")] Hcaptcha,
            [EnumMember(Value = "mcaptcha")] Mcaptcha,
            [EnumMember(Value = "recaptcha")] Recaptcha,
            [EnumMember(Value = "turnstile")] Turnstile,
            [EnumMember(Value = "testcaptcha")] Testcaptcha
        }
    }
}

namespace Misharp.Controls.Admin
{
    public class DriveApi
    {
        private readonly App _app;

        public DriveApi(App app)
        {
            _app = app;
        }

        public async Task<Response<EmptyResponse>> CleanRemoteFiles()
        {
            var result = await _app.Request<EmptyResponse>(
                "admin/drive/clean-remote-files",
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> Cleanup()
        {
            var result = await _app.Request<EmptyResponse>(
                "admin/drive/cleanup",
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<List<DriveFileModel>>> Files(int limit = 10, string? sinceId = null,
            string? untilId = null, string? userId = null, string? type = null,
            AdminDriveFilesPropertiesOriginEnum origin = AdminDriveFilesPropertiesOriginEnum.Local,
            string? hostname = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "userId", userId },
                { "type", type },
                { "origin", origin },
                { "hostname", hostname }
            };
            var result = await _app.Request<List<DriveFileModel>>(
                "admin/drive/files",
                param,
                true
            );
            return result;
        }

        public enum AdminDriveFilesPropertiesOriginEnum
        {
            [EnumMember(Value = "combined")] Combined,
            [EnumMember(Value = "local")] Local,
            [EnumMember(Value = "remote")] Remote
        }

        public async Task<Response<PostShowFileModel>> ShowFile(string fileId, string url)
        {
            var param = new Dictionary<string, object?>
            {
                { "fileId", fileId },
                { "url", url }
            };
            var result = await _app.Request<PostShowFileModel>(
                "admin/drive/show-file",
                param,
                true
            );
            return result;
        }

        public interface IPostShowFilePropertiesModel
        {
            public decimal Width { get; set; }
            public decimal Height { get; set; }
            public decimal Orientation { get; set; }
            public string AvgColor { get; set; }
        }

        public class PostShowFilePropertiesModel : IPostShowFilePropertiesModel
        {
            public decimal Width { get; set; }
            public decimal Height { get; set; }
            public decimal Orientation { get; set; }
            public string AvgColor { get; set; }
        }

        public interface IPostShowFileModel
        {
            public string Id { get; set; }
            public DateTime? CreatedAt { get; set; }
            public string? UserId { get; set; }
            public string? UserHost { get; set; }
            public string Md5 { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public decimal Size { get; set; }
            public string? Comment { get; set; }
            public string? Blurhash { get; set; }
            public PostShowFilePropertiesModel Properties { get; set; }
            public bool? StoredInternal { get; set; }
            public Uri? Url { get; set; }
            public Uri? ThumbnailUrl { get; set; }
            public Uri? WebpublicUrl { get; set; }
            public string? AccessKey { get; set; }
            public string? ThumbnailAccessKey { get; set; }
            public string? WebpublicAccessKey { get; set; }
            public string? Uri { get; set; }
            public string? Src { get; set; }
            public string? FolderId { get; set; }
            public bool IsSensitive { get; set; }
            public bool IsLink { get; set; }
        }

        public class PostShowFileModel : IPostShowFileModel
        {
            public string Id { get; set; }
            public DateTime? CreatedAt { get; set; }
            public string? UserId { get; set; }
            public string? UserHost { get; set; }
            public string Md5 { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public decimal Size { get; set; }
            public string? Comment { get; set; }
            public string? Blurhash { get; set; }
            public PostShowFilePropertiesModel Properties { get; set; }
            public bool? StoredInternal { get; set; }
            public Uri? Url { get; set; }
            public Uri? ThumbnailUrl { get; set; }
            public Uri? WebpublicUrl { get; set; }
            public string? AccessKey { get; set; }
            public string? ThumbnailAccessKey { get; set; }
            public string? WebpublicAccessKey { get; set; }
            public string? Uri { get; set; }
            public string? Src { get; set; }
            public string? FolderId { get; set; }
            public bool IsSensitive { get; set; }
            public bool IsLink { get; set; }
        }
    }
}

namespace Misharp.Controls.Admin
{
    public class EmojiApi
    {
        private readonly App _app;

        public EmojiApi(App app)
        {
            _app = app;
        }

        public async Task<Response<EmojiDetailedModel>> Add(string name, string fileId, bool isSensitive,
            bool localOnly, string? category = null, List<string>? aliases = null, string? license = null,
            List<string>? roleIdsThatCanBeUsedThisEmojiAsReaction = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "name", name },
                { "fileId", fileId },
                { "category", category },
                { "aliases", aliases },
                { "license", license },
                { "isSensitive", isSensitive },
                { "localOnly", localOnly },
                { "roleIdsThatCanBeUsedThisEmojiAsReaction", roleIdsThatCanBeUsedThisEmojiAsReaction }
            };
            var result = await _app.Request<EmojiDetailedModel>(
                "admin/emoji/add",
                param,
                true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> AddAliasesBulk(List<string>? ids = null,
            List<string>? aliases = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "ids", ids },
                { "aliases", aliases }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/emoji/add-aliases-bulk",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<PostCopyModel>> Copy(string emojiId)
        {
            var param = new Dictionary<string, object?>
            {
                { "emojiId", emojiId }
            };
            var result = await _app.Request<PostCopyModel>(
                "admin/emoji/copy",
                param,
                true
            );
            return result;
        }

        public interface IPostCopyModel
        {
            public string Id { get; set; }
        }

        public class PostCopyModel : IPostCopyModel
        {
            public string Id { get; set; }
        }

        public async Task<Response<EmptyResponse>> Delete(string id)
        {
            var param = new Dictionary<string, object?>
            {
                { "id", id }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/emoji/delete",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> DeleteBulk(List<string>? ids = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "ids", ids }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/emoji/delete-bulk",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> ImportZip(string fileId)
        {
            var param = new Dictionary<string, object?>
            {
                { "fileId", fileId }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/emoji/import-zip",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<List<PostListItemsModel>>> List(string? query = null, int limit = 10,
            string? sinceId = null, string? untilId = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "query", query },
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId }
            };
            var result = await _app.Request<List<PostListItemsModel>>(
                "admin/emoji/list",
                param,
                true
            );
            return result;
        }

        public interface IPostListItemsModel
        {
            public string Id { get; set; }
            public List<string> Aliases { get; set; }
            public string Name { get; set; }
            public string? Category { get; set; }
            public string? Host { get; set; }
            public string Url { get; set; }
        }

        public class PostListItemsModel : IPostListItemsModel
        {
            public string Id { get; set; }
            public List<string> Aliases { get; set; }
            public string Name { get; set; }
            public string? Category { get; set; }
            public string? Host { get; set; }
            public string Url { get; set; }
        }

        public async Task<Response<List<PostListRemoteItemsModel>>> ListRemote(string? query = null,
            string? host = null, int limit = 10, string? sinceId = null, string? untilId = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "query", query },
                { "host", host },
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId }
            };
            var result = await _app.Request<List<PostListRemoteItemsModel>>(
                "admin/emoji/list-remote",
                param,
                true
            );
            return result;
        }

        public interface IPostListRemoteItemsModel
        {
            public string Id { get; set; }
            public List<string> Aliases { get; set; }
            public string Name { get; set; }
            public string? Category { get; set; }
            public string? Host { get; set; }
            public string Url { get; set; }
        }

        public class PostListRemoteItemsModel : IPostListRemoteItemsModel
        {
            public string Id { get; set; }
            public List<string> Aliases { get; set; }
            public string Name { get; set; }
            public string? Category { get; set; }
            public string? Host { get; set; }
            public string Url { get; set; }
        }

        public async Task<Response<EmptyResponse>> RemoveAliasesBulk(List<string>? ids = null,
            List<string>? aliases = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "ids", ids },
                { "aliases", aliases }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/emoji/remove-aliases-bulk",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> SetAliasesBulk(List<string>? ids = null,
            List<string>? aliases = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "ids", ids },
                { "aliases", aliases }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/emoji/set-aliases-bulk",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> SetCategoryBulk(List<string>? ids = null, string? category = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "ids", ids },
                { "category", category }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/emoji/set-category-bulk",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> SetLicenseBulk(List<string>? ids = null, string? license = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "ids", ids },
                { "license", license }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/emoji/set-license-bulk",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> Update(string id, string name, string fileId, bool isSensitive,
            bool localOnly, string? category = null, List<string>? aliases = null, string? license = null,
            List<string>? roleIdsThatCanBeUsedThisEmojiAsReaction = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "id", id },
                { "name", name },
                { "fileId", fileId },
                { "category", category },
                { "aliases", aliases },
                { "license", license },
                { "isSensitive", isSensitive },
                { "localOnly", localOnly },
                { "roleIdsThatCanBeUsedThisEmojiAsReaction", roleIdsThatCanBeUsedThisEmojiAsReaction }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/emoji/update",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }
    }
}

namespace Misharp.Controls.Admin
{
    public class FederationApi
    {
        private readonly App _app;

        public FederationApi(App app)
        {
            _app = app;
        }

        public async Task<Response<EmptyResponse>> DeleteAllFiles(string host)
        {
            var param = new Dictionary<string, object?>
            {
                { "host", host }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/federation/delete-all-files",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> RefreshRemoteInstanceMetadata(string host)
        {
            var param = new Dictionary<string, object?>
            {
                { "host", host }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/federation/refresh-remote-instance-metadata",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> RemoveAllFollowing(string host)
        {
            var param = new Dictionary<string, object?>
            {
                { "host", host }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/federation/remove-all-following",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> UpdateInstance(string host, bool isSuspended, string moderationNote)
        {
            var param = new Dictionary<string, object?>
            {
                { "host", host },
                { "isSuspended", isSuspended },
                { "moderationNote", moderationNote }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/federation/update-instance",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }
    }
}

namespace Misharp.Controls.Admin
{
    public class InviteApi
    {
        private readonly App _app;

        public InviteApi(App app)
        {
            _app = app;
        }

        public async Task<Response<List<InviteCodeModel>>> Create(int count = 1, string? expiresAt = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "count", count },
                { "expiresAt", expiresAt }
            };
            var result = await _app.Request<List<InviteCodeModel>>(
                "admin/invite/create",
                param,
                true
            );
            return result;
        }

        public async Task<Response<List<InviteCodeModel>>> List(AdminInviteListPropertiesSortEnum sort, int limit = 30,
            int offset = 0, AdminInviteListPropertiesTypeEnum type = AdminInviteListPropertiesTypeEnum.All)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "offset", offset },
                { "type", type },
                { "sort", sort }
            };
            var result = await _app.Request<List<InviteCodeModel>>(
                "admin/invite/list",
                param,
                true
            );
            return result;
        }

        public enum AdminInviteListPropertiesTypeEnum
        {
            [EnumMember(Value = "unused")] Unused,
            [EnumMember(Value = "used")] Used,
            [EnumMember(Value = "expired")] Expired,
            [EnumMember(Value = "all")] All
        }

        public enum AdminInviteListPropertiesSortEnum
        {
            [EnumMember(Value = "+createdAt")] PluscreatedAt,
            [EnumMember(Value = "-createdAt")] MinuscreatedAt,
            [EnumMember(Value = "+usedAt")] PlususedAt,
            [EnumMember(Value = "-usedAt")] MinususedAt
        }
    }
}

namespace Misharp.Controls.Admin
{
    public class PromoApi
    {
        private readonly App _app;

        public PromoApi(App app)
        {
            _app = app;
        }

        public async Task<Response<EmptyResponse>> Create(string noteId, int expiresAt)
        {
            var param = new Dictionary<string, object?>
            {
                { "noteId", noteId },
                { "expiresAt", expiresAt }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/promo/create",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }
    }
}

namespace Misharp.Controls.Admin
{
    public class QueueApi
    {
        private readonly App _app;

        public QueueApi(App app)
        {
            _app = app;
        }

        public async Task<Response<EmptyResponse>> Clear()
        {
            var result = await _app.Request<EmptyResponse>(
                "admin/queue/clear",
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<List<JsonNode>>> DeliverDelayed()
        {
            var result = await _app.Request<List<JsonNode>>(
                "admin/queue/deliver-delayed",
                true
            );
            return result;
        }

        public async Task<Response<List<JsonNode>>> InboxDelayed()
        {
            var result = await _app.Request<List<JsonNode>>(
                "admin/queue/inbox-delayed",
                true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> Promote(AdminQueuePromotePropertiesTypeEnum type)
        {
            var param = new Dictionary<string, object?>
            {
                { "type", type }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/queue/promote",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public enum AdminQueuePromotePropertiesTypeEnum
        {
            [EnumMember(Value = "deliver")] Deliver,
            [EnumMember(Value = "inbox")] Inbox
        }

        public async Task<Response<PostStatsModel>> Stats()
        {
            var result = await _app.Request<PostStatsModel>(
                "admin/queue/stats",
                true
            );
            return result;
        }

        public interface IPostStatsModel
        {
            public JsonNode Deliver { get; set; }
            public JsonNode Inbox { get; set; }
            public JsonNode Db { get; set; }
            public JsonNode ObjectStorage { get; set; }
        }

        public class PostStatsModel : IPostStatsModel
        {
            public JsonNode Deliver { get; set; }
            public JsonNode Inbox { get; set; }
            public JsonNode Db { get; set; }
            public JsonNode ObjectStorage { get; set; }
        }
    }
}

namespace Misharp.Controls.Admin
{
    public class RelaysApi
    {
        private readonly App _app;

        public RelaysApi(App app)
        {
            _app = app;
        }

        public async Task<Response<PostAddModel>> Add(string inbox)
        {
            var param = new Dictionary<string, object?>
            {
                { "inbox", inbox }
            };
            var result = await _app.Request<PostAddModel>(
                "admin/relays/add",
                param,
                true
            );
            return result;
        }

        public enum PostAddStatusEnum
        {
            [EnumMember(Value = "requesting")] Requesting,
            [EnumMember(Value = "accepted")] Accepted,
            [EnumMember(Value = "rejected")] Rejected
        }

        public interface IPostAddModel
        {
            public string Id { get; set; }
            public Uri Inbox { get; set; }
            public PostAddStatusEnum Status { get; set; }
        }

        public class PostAddModel : IPostAddModel
        {
            public string Id { get; set; }
            public Uri Inbox { get; set; }
            public PostAddStatusEnum Status { get; set; }
        }

        public async Task<Response<List<PostListItemsModel>>> List()
        {
            var result = await _app.Request<List<PostListItemsModel>>(
                "admin/relays/list",
                true
            );
            return result;
        }

        public enum PostListItemsStatusEnum
        {
            [EnumMember(Value = "requesting")] Requesting,
            [EnumMember(Value = "accepted")] Accepted,
            [EnumMember(Value = "rejected")] Rejected
        }

        public interface IPostListItemsModel
        {
            public string Id { get; set; }
            public Uri Inbox { get; set; }
            public PostListItemsStatusEnum Status { get; set; }
        }

        public class PostListItemsModel : IPostListItemsModel
        {
            public string Id { get; set; }
            public Uri Inbox { get; set; }
            public PostListItemsStatusEnum Status { get; set; }
        }

        public async Task<Response<EmptyResponse>> Remove(string inbox)
        {
            var param = new Dictionary<string, object?>
            {
                { "inbox", inbox }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/relays/remove",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }
    }
}

namespace Misharp.Controls.Admin
{
    public class RolesApi
    {
        private readonly App _app;

        public RolesApi(App app)
        {
            _app = app;
        }

        public async Task<Response<EmptyResponse>> Assign(string roleId, string userId, int? expiresAt = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "roleId", roleId },
                { "userId", userId },
                { "expiresAt", expiresAt }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/roles/assign",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<RoleModel>> Create(string name, string description,
            AdminRolesCreatePropertiesTargetEnum target, JsonNode condFormula, bool isPublic, bool isModerator,
            bool isAdministrator, bool asBadge, bool canEditMembersByModerator, decimal displayOrder,
            RolePoliciesModel policies,
            string? color = null, string? iconUrl = null, bool isExplorable = false)
        {
            var param = new Dictionary<string, object?>
            {
                { "name", name },
                { "description", description },
                { "color", color },
                { "iconUrl", iconUrl },
                { "target", target },
                { "condFormula", condFormula },
                { "isPublic", isPublic },
                { "isModerator", isModerator },
                { "isAdministrator", isAdministrator },
                { "isExplorable", isExplorable },
                { "asBadge", asBadge },
                { "canEditMembersByModerator", canEditMembersByModerator },
                { "displayOrder", displayOrder },
                { "policies", policies }
            };
            var result = await _app.Request<RoleModel>(
                "admin/roles/create",
                param,
                true
            );
            return result;
        }

        public enum AdminRolesCreatePropertiesTargetEnum
        {
            [EnumMember(Value = "manual")] Manual,
            [EnumMember(Value = "conditional")] Conditional
        }

        public async Task<Response<EmptyResponse>> Delete(string roleId)
        {
            var param = new Dictionary<string, object?>
            {
                { "roleId", roleId }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/roles/delete",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<List<RoleModel>>> List()
        {
            var result = await _app.Request<List<RoleModel>>(
                "admin/roles/list",
                true
            );
            return result;
        }

        public async Task<Response<RoleModel>> Show(string roleId)
        {
            var param = new Dictionary<string, object?>
            {
                { "roleId", roleId }
            };
            var result = await _app.Request<RoleModel>(
                "admin/roles/show",
                param,
                true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> Unassign(string roleId, string userId)
        {
            var param = new Dictionary<string, object?>
            {
                { "roleId", roleId },
                { "userId", userId }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/roles/unassign",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> Update(string roleId, string name, string description,
            AdminRolesUpdatePropertiesTargetEnum target, JsonNode condFormula, bool isPublic, bool isModerator,
            bool isAdministrator, bool isExplorable, bool asBadge, bool canEditMembersByModerator, decimal displayOrder,
            RolePoliciesModel policies, string? color = null, string? iconUrl = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "roleId", roleId },
                { "name", name },
                { "description", description },
                { "color", color },
                { "iconUrl", iconUrl },
                { "target", target },
                { "condFormula", condFormula },
                { "isPublic", isPublic },
                { "isModerator", isModerator },
                { "isAdministrator", isAdministrator },
                { "isExplorable", isExplorable },
                { "asBadge", asBadge },
                { "canEditMembersByModerator", canEditMembersByModerator },
                { "displayOrder", displayOrder },
                { "policies", policies }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/roles/update",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public enum AdminRolesUpdatePropertiesTargetEnum
        {
            [EnumMember(Value = "manual")] Manual,
            [EnumMember(Value = "conditional")] Conditional
        }

        public async Task<Response<EmptyResponse>> UpdateDefaultPolicies(RolePoliciesModel policies)
        {
            var param = new Dictionary<string, object?>
            {
                { "policies", policies }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/roles/update-default-policies",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<List<PostUsersItemsModel>>> Users(string roleId, string? sinceId = null,
            string? untilId = null, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "roleId", roleId },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "limit", limit }
            };
            var result = await _app.Request<List<PostUsersItemsModel>>(
                "admin/roles/users",
                param,
                false
            );
            return result;
        }

        public interface IPostUsersItemsModel
        {
            public string Id { get; set; }
            public DateTime? CreatedAt { get; set; }
            public JsonNode User { get; set; }
            public DateTime? ExpiresAt { get; set; }
        }

        public class PostUsersItemsModel : IPostUsersItemsModel
        {
            public string Id { get; set; }
            public DateTime? CreatedAt { get; set; }
            public JsonNode User { get; set; }
            public DateTime? ExpiresAt { get; set; }
        }
    }
}

namespace Misharp.Controls.Admin
{
    public class SystemWebhookApi
    {
        private readonly App _app;

        public SystemWebhookApi(App app)
        {
            _app = app;
        }

        public async Task<Response<SystemWebhookModel>> Create(bool isActive, string name, string url, string secret,
            List<string>? on = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "isActive", isActive },
                { "name", name },
                { "on", on },
                { "url", url },
                { "secret", secret }
            };
            var result = await _app.Request<SystemWebhookModel>(
                "admin/system-webhook/create",
                param,
                true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> Delete(string id)
        {
            var param = new Dictionary<string, object?>
            {
                { "id", id }
            };
            var result = await _app.Request<EmptyResponse>(
                "admin/system-webhook/delete",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public async Task<Response<List<SystemWebhookModel>>> List(bool isActive, List<string>? on = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "isActive", isActive },
                { "on", on }
            };
            var result = await _app.Request<List<SystemWebhookModel>>(
                "admin/system-webhook/list",
                param,
                true
            );
            return result;
        }

        public async Task<Response<SystemWebhookModel>> Show(string id)
        {
            var param = new Dictionary<string, object?>
            {
                { "id", id }
            };
            var result = await _app.Request<SystemWebhookModel>(
                "admin/system-webhook/show",
                param,
                true
            );
            return result;
        }

        public async Task<Response<EmptyResponse>> Test(string webhookId, AdminSystemWebhookTestPropertiesTypeEnum type,
            AdminSystemWebhookTestPropertiesOverrideModel @override)
        {
            var param = new Dictionary<string, object?>
            {
                { "webhookId", webhookId },
                { "type", type },
                { "override", @override }
            };

            var result = await _app.Request<EmptyResponse>(
                "admin/system-webhook/test",
                param,
                successStatusCode: System.Net.HttpStatusCode.NoContent,
                needToken: true
            );
            return result;
        }

        public enum AdminSystemWebhookTestPropertiesTypeEnum
        {
            [EnumMember(Value = "abuseReport")] AbuseReport,

            [EnumMember(Value = "abuseReportResolved")]
            AbuseReportResolved,
            [EnumMember(Value = "userCreated")] UserCreated,

            [EnumMember(Value = "inactiveModeratorsWarning")]
            InactiveModeratorsWarning,

            [EnumMember(Value = "inactiveModeratorsInvitationOnlyChanged")]
            InactiveModeratorsInvitationOnlyChanged
        }

        public interface IAdminSystemWebhookTestPropertiesOverrideModel
        {
            public string Url { get; set; }
            public string Secret { get; set; }
        }

        public class AdminSystemWebhookTestPropertiesOverrideModel : IAdminSystemWebhookTestPropertiesOverrideModel
        {
            public string Url { get; set; }
            public string Secret { get; set; }
        }

        public async Task<Response<SystemWebhookModel>> Update(string id, bool isActive, string name, string url,
            string secret, List<string>? on = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "id", id },
                { "isActive", isActive },
                { "name", name },
                { "on", on },
                { "url", url },
                { "secret", secret }
            };
            var result = await _app.Request<SystemWebhookModel>(
                "admin/system-webhook/update",
                param,
                true
            );
            return result;
        }
    }
}