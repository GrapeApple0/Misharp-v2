using System.Net.Mime;
using System.Net;
using System.Text.Json;
using System.Text;
using Misharp.Controls;

namespace Misharp
{
    public class App
    {
        public string Host { get; }
        public string Token { get; }
        public bool UseHttps { get; }
        private HttpClient _httpClient { get; }
        // API classes
        public AdminApi AdminApi { get; }
        public AnnouncementsApi AnnouncementsApi { get; }
        public AntennasApi AntennasApi { get; }
        public ApApi ApApi { get; }
        public AppApi AppApi { get; }
        public AuthApi AuthApi { get; }
        public BlockingApi BlockingApi { get; }
        public ChannelsApi ChannelsApi { get; }
        public ChartsApi ChartsApi { get; }
        public ClipsApi ClipsApi { get; }
        public DriveApi DriveApi { get; }
        public EmailAddressApi EmailAddressApi { get; }
        public EndpointApi EndpointApi { get; }
        public EndpointsApi EndpointsApi { get; }
        public ExportCustomEmojisApi ExportCustomEmojisApi { get; }
        public FederationApi FederationApi { get; }
        public FollowingApi FollowingApi { get; }
        public GalleryApi GalleryApi { get; }
        public GetOnlineUsersCountApi GetOnlineUsersCountApi { get; }
        public GetAvatarDecorationsApi GetAvatarDecorationsApi { get; }
        public HashtagsApi HashtagsApi { get; }
        public IApi IApi { get; }
        public InviteApi InviteApi { get; }
        public MetaApi MetaApi { get; }
        public EmojisApi EmojisApi { get; }
        public EmojiApi EmojiApi { get; }
        public MiauthApi MiauthApi { get; }
        public MuteApi MuteApi { get; }
        public RenoteMuteApi RenoteMuteApi { get; }
        public MyApi MyApi { get; }
        public NotesApi NotesApi { get; }
        public NotificationsApi NotificationsApi { get; }
        public PagePushApi PagePushApi { get; }
        public PagesApi PagesApi { get; }
        public FlashApi FlashApi { get; }
        public PingApi PingApi { get; }
        public PinnedUsersApi PinnedUsersApi { get; }
        public PromoApi PromoApi { get; }
        public RolesApi RolesApi { get; }
        public RequestResetPasswordApi RequestResetPasswordApi { get; }
        public ResetPasswordApi ResetPasswordApi { get; }
        public ServerInfoApi ServerInfoApi { get; }
        public StatsApi StatsApi { get; }
        public SwApi SwApi { get; }
        public TestApi TestApi { get; }
        public UsernameApi UsernameApi { get; }
        public UsersApi UsersApi { get; }
        public FetchExternalResourcesApi FetchExternalResourcesApi { get; }
        public RetentionApi RetentionApi { get; }

        public App(string host, string token = "", HttpClient? httpClient = null, bool useHttps = true)
        {
            this.Host = host;
            this.Token = token;
            this.UseHttps = useHttps;
            this._httpClient = httpClient ?? new HttpClient();
            this.AdminApi = new AdminApi(this);
            this.AnnouncementsApi = new AnnouncementsApi(this);
            this.AntennasApi = new AntennasApi(this);
            this.ApApi = new ApApi(this);
            this.AppApi = new AppApi(this);
            this.AuthApi = new AuthApi(this);
            this.BlockingApi = new BlockingApi(this);
            this.ChannelsApi = new ChannelsApi(this);
            this.ChartsApi = new ChartsApi(this);
            this.ClipsApi = new ClipsApi(this);
            this.DriveApi = new DriveApi(this);
            this.EmailAddressApi = new EmailAddressApi(this);
            this.EndpointApi = new EndpointApi(this);
            this.EndpointsApi = new EndpointsApi(this);
            this.ExportCustomEmojisApi = new ExportCustomEmojisApi(this);
            this.FederationApi = new FederationApi(this);
            this.FollowingApi = new FollowingApi(this);
            this.GalleryApi = new Controls.GalleryApi(this);
            this.GetOnlineUsersCountApi = new GetOnlineUsersCountApi(this);
            this.GetAvatarDecorationsApi = new GetAvatarDecorationsApi(this);
            this.HashtagsApi = new HashtagsApi(this);
            this.IApi = new IApi(this);
            this.InviteApi = new InviteApi(this);
            this.MetaApi = new MetaApi(this);
            this.EmojisApi = new EmojisApi(this);
            this.EmojiApi = new EmojiApi(this);
            this.MiauthApi = new MiauthApi(this);
            this.MuteApi = new MuteApi(this);
            this.RenoteMuteApi = new RenoteMuteApi(this);
            this.MyApi = new MyApi(this);
            this.NotesApi = new NotesApi(this);
            this.NotificationsApi = new NotificationsApi(this);
            this.PagePushApi = new PagePushApi(this);
            this.PagesApi = new PagesApi(this);
            this.FlashApi = new FlashApi(this);
            this.PingApi = new PingApi(this);
            this.PinnedUsersApi = new PinnedUsersApi(this);
            this.PromoApi = new PromoApi(this);
            this.RolesApi = new RolesApi(this);
            this.RequestResetPasswordApi = new RequestResetPasswordApi(this);
            this.ResetPasswordApi = new ResetPasswordApi(this);
            this.ServerInfoApi = new ServerInfoApi(this);
            this.StatsApi = new StatsApi(this);
            this.SwApi = new SwApi(this);
            this.TestApi = new TestApi(this);
            this.UsernameApi = new UsernameApi(this);
            this.UsersApi = new UsersApi(this);
            this.FetchExternalResourcesApi = new FetchExternalResourcesApi(this);
            this.RetentionApi = new RetentionApi(this);
        }

        private static async Task<Response<T>> ReturnResponse<T>(HttpResponseMessage response, HttpStatusCode successStatusCode) where T : class
        {
            var resultContent = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == successStatusCode)
            {
                if (response.StatusCode == HttpStatusCode.NoContent)
                {
                    return new Response<T>(response.StatusCode);
                }
                var result = JsonSerializer.Deserialize<T>(resultContent, Config.JsonSerializerOptions);
                if (result != null)
                {
                    return new Response<T>(response.StatusCode, result);
                }
            }
            else
            {
                throw new Exception(resultContent);
                //var error = JsonSerializer.Deserialize<Models.ErrorModel>(resultContent, options);
                //if (error != null) throw new Exception(error.Error.ToString());
            }
            throw new Exception(resultContent);
        }

        private string BuildStringParameters(Dictionary<string, object?>? ps, bool needToken)
        {
            Dictionary<string, object> param = ps != null ? Tools.RemoveNullValues(ps) : new Dictionary<string, object>();

            if (this.Token != "")
            {
                param.Add("i", this.Token);
            }
            else if (needToken)
            {
                throw new Exception("This endpoint requires token");
            }

            return JsonSerializer.Serialize(param, Config.JsonSerializerOptions);
        }

        public async Task<Response<T>> Request<T>(string endpoint, Dictionary<string, object?> ps, bool needToken = false, HttpStatusCode successStatusCode = HttpStatusCode.OK) where T : class
        {
            var data = BuildStringParameters(ps, needToken);//JsonSerializer.Serialize(param, Config.JsonSerializerOptions);
            var content = new StringContent(data, Encoding.UTF8, MediaTypeNames.Application.Json);
            var response = await this._httpClient.PostAsync($"http{(UseHttps ? 's' : string.Empty)}://{this.Host}/api/{endpoint}", content);
            return await ReturnResponse<T>(response, successStatusCode);
        }

        public async Task<Response<T>> Request<T>(string endpoint, bool needToken = false, HttpStatusCode successStatusCode = HttpStatusCode.OK) where T : class
        {
            var data = BuildStringParameters(null, needToken);
            var content = new StringContent(data, Encoding.UTF8, MediaTypeNames.Application.Json);
            var response = await this._httpClient.PostAsync($"http{(UseHttps ? 's' : string.Empty)}://{this.Host}/api/{endpoint}", content);
            return await ReturnResponse<T>(response, successStatusCode);
        }

        public async Task<Response<T>> RequestGet<T>(string endpoint, Dictionary<string, object?>? ps, bool needToken = false, HttpStatusCode successStatusCode = HttpStatusCode.OK) where T : class
        {
            Dictionary<string, string> param;
            if (ps != null)
            {
                param = (from kv in Tools.RemoveNullValues(ps) select kv).ToDictionary(kv => kv.Key, kv =>
                {
                    if (kv.Value is Enum @enum)
                    {
                        return @enum.GetEnumMemberValue() ?? kv.Value.ToString() ?? "";
                    }
                    return kv.Value.ToString() ?? "";
                });
            }
            else
            {
                param = new Dictionary<string, string>();
            }
            if (this.Token != "")
            {
                param.Add("i", this.Token);
            }
            else if (needToken)
            {
                throw new Exception("This endpoint requires token");
            }

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"http{(UseHttps ? 's' : string.Empty)}://{this.Host}/api/{endpoint}?{await new FormUrlEncodedContent(param).ReadAsStringAsync()}"),
            };

            var response = await this._httpClient.SendAsync(request);
            return await ReturnResponse<T>(response, successStatusCode);
        }

        public async Task<Response<T>> RequestGet<T>(string endpoint, bool needToken = false, HttpStatusCode successStatusCode = HttpStatusCode.OK) where T : class
        {
            var param = new Dictionary<string, string>();
            if (this.Token != "")
            {
                param.Add("i", this.Token);
            }
            else if (needToken)
            {
                throw new Exception("This endpoint requires token");
            }
            var response = await this._httpClient.GetAsync($"http{(UseHttps ? 's' : string.Empty)}://{this.Host}/api/{endpoint}?{await new FormUrlEncodedContent(param).ReadAsStringAsync()}");
            return await ReturnResponse<T>(response, successStatusCode);
        }

        private static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using var ms = new MemoryStream();
            int read;
            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                ms.Write(buffer, 0, read);
            }
            return ms.ToArray();
        }

        public async Task<Response<T>> RequestFormData<T>(string endpoint, Dictionary<string, object?> ps, bool needToken = false, HttpStatusCode successStatusCode = HttpStatusCode.OK) where T : class
        {
            MultipartFormDataContent content = new MultipartFormDataContent();
            foreach (var (key, value) in ps)
            {
                if (value is Stream stream)
                {
                    if (stream is FileStream fs)
                    {
                        var dataContent = new ByteArrayContent(ReadFully(fs));
                        dataContent.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data")
                        {
                            Name = "file",
                            FileName = fs.Name
                        };
                        content.Add(dataContent);
                    } 
                    else
                    {
                        var dataContent = new ByteArrayContent(ReadFully(stream));
                        dataContent.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data")
                        {
                            Name = "file",
                            FileName = Tools.RandomString(8)
                        };
                        content.Add(dataContent);
                    }
                }
                else if (value != null)
                {
                    var stringContent = new StringContent($"{value}", new UTF8Encoding(false));
                    if (value is Enum @enum) stringContent = new StringContent($"{@enum.GetEnumMemberValue() ?? value}", new UTF8Encoding(false));
                    stringContent.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data")
                    {
                        Name = key
                    };
                    content.Add(stringContent);
                }
            }
            if (this.Token != "")
            {
                var i = new StringContent(this.Token, new UTF8Encoding(false));
                i.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data")
                {
                    Name = "i"
                };
                content.Add(i);
            }
            else if (needToken)
            {
                throw new Exception("This endpoint requires token");
            }
            var response = await this._httpClient.PostAsync($"http{(UseHttps ? 's' : string.Empty)}://{this.Host}/api/{endpoint}", content);
            return await ReturnResponse<T>(response, successStatusCode);
        }
    }
}
