using HttpClientToCurl;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ALoxe.Infrastructure.Http
{
    public class HttpRequest
    {
        public static bool PingHost(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Timeout = 15000;
            request.Method = "GET"; // As per Lasse's comment
            try
            {
                //config certificate
                ServicePointManager.ServerCertificateValidationCallback = new
    RemoteCertificateValidationCallback
    (
      delegate { return true; }
    );
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    return response.StatusCode == HttpStatusCode.OK;
                }
            }
            catch (WebException)
            {
                return false;
            }
        }
        public static async Task<System.IO.Stream> UploadAsync(string url, Stream fileStream, string fileName = "file")
        {
            // Convert each of the three inputs into HttpContent objects

            // examples of converting both Stream and byte [] to HttpContent objects
            // representing input type file
            HttpContent fileStreamContent = new StreamContent(fileStream);

            // Submit the form using HttpClient and 
            // create form data as Multipart (enctype="multipart/form-data")

            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                //config certificate
                ServicePointManager.ServerCertificateValidationCallback = new
    RemoteCertificateValidationCallback
    (
      delegate { return true; }
    );
                // Add the HttpContent objects to the form data
                // <input type="file" name="file1" />
                formData.Add(fileStreamContent, "file1", fileName);

                // Invoke the request to the server

                // equivalent to pressing the submit button on
                // a form with attributes (action="{url}" method="post")
                var response = await client.PostAsync(url, formData);

                // ensure the request was a success
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ReasonPhrase);
                }
                return await response.Content.ReadAsStreamAsync();
            }
        }
        public static async Task<Stream> GetStream(string url, object pram, string username = "", string password = "", int timeout = 20)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Timeout = timeout * 1000;
            //config authenticate
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                string authInfo = username + ":" + password;
                authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
                request.Headers["Authorization"] = "Basic " + authInfo;
            }

            //config certificate
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
            try
            {
                var response = (HttpWebResponse)(await request.GetResponseAsync());

                return response.GetResponseStream();
            }
            catch
            {
                return null;
            }

        }

        public static Stream GetStreamWithoutAuthorize(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);

            var response = (HttpWebResponse)request.GetResponse();

            return response.GetResponseStream();
        }

        public static byte[] GetFile(string url, object pram, string username = "", string password = "", string contentType = "")
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            //config authenticate
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                string authInfo = username + ":" + password;
                authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
                request.Headers["Authorization"] = "Basic " + authInfo;
            }
            //config certificate
            ServicePointManager.ServerCertificateValidationCallback = new
RemoteCertificateValidationCallback
(
  delegate { return true; }
);

            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                if (!string.IsNullOrEmpty(contentType) && !response.ContentType.ToLower().Contains(contentType.ToLower()))
                {
                    return null;
                }
                using (var memoryStream = new MemoryStream())
                {
                    response.GetResponseStream().CopyTo(memoryStream);
                    return memoryStream.ToArray();
                }
            }
            catch
            {
                return null;
            }

        }
    }
    public enum AUTHORIZE_TYPE
    {
        [Display(Name = "None")]
        None,
        [Display(Name = "Basic")]
        Basic,
        [Display(Name = "Digest")]
        Digest,//MD5,
        [Display(Name = "Bearer")]
        Bearer

    }
    public abstract class BaseAuthorize
    {
        public abstract AUTHORIZE_TYPE Key { get; }
        protected string Host { get; }
        protected string Username { get; }
        protected string Password { get; }
        protected Dictionary<string, string> Headers { get; set; }
        public abstract string ToData(HttpClient client, HttpMethod method, Uri uri);
        public BaseAuthorize(string username, string password, string host = "")
        {
            Username = username ?? throw new ArgumentNullException(nameof(username));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            Host = host;
        }
    }

    public class BasicAuthorize : BaseAuthorize
    {
        public BasicAuthorize(string username, string password) : base(username, password)
        {
        }

        public override AUTHORIZE_TYPE Key => AUTHORIZE_TYPE.Basic;

        public override string ToData(HttpClient client, HttpMethod method, Uri uri)
        {
            var authenticationString = $"{Username}:{Password}";
            var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(authenticationString));
            return base64EncodedAuthenticationString;
        }
    }

    public class DigestAuthorize : BaseAuthorize
    {
        private string _realm;
        private string _nonce;
        private string _qop;
        private string _cnonce;
        private string _opaque;
        private DateTime _cnonceDate;
        private int _nc = 0;

        public override AUTHORIZE_TYPE Key => AUTHORIZE_TYPE.Digest;

        public DigestAuthorize(string username, string password, string host = "") : base(username, password, host)
        {
        }


        private static string CalculateMd5Hash(
            string input)
        {
            var inputBytes = Encoding.ASCII.GetBytes(input);
            var hash = MD5.Create().ComputeHash(inputBytes);
            var sb = new StringBuilder();
            foreach (var b in hash)
                sb.Append(b.ToString("x2"));
            return sb.ToString();
        }

        private static string GrabHeaderVar(
            string varName,
            string header)
        {
            var regHeader = new Regex(string.Format(@"{0}=""([^""]*)""", varName));
            var matchHeader = regHeader.Match(header);
            if (matchHeader.Success)
                return matchHeader.Groups[1].Value;
            return "";
            //throw new ApplicationException(string.Format("Header {0} not found", varName));
        }

        // http://en.wikipedia.org/wiki/Digest_access_authentication
        private string GetDigestHeader(
            string dir, HttpMethod method)
        {
            _nc = _nc + 1;

            var ha1 = CalculateMd5Hash(string.Format("{0}:{1}:{2}", Username, _realm, Password));
            var ha2 = CalculateMd5Hash(string.Format("{0}:{1}", method.Method, dir));
            var digestResponse =
                CalculateMd5Hash(string.Format("{0}:{1}:{2:00000000}:{3}:{4}:{5}", ha1, _nonce, _nc, _cnonce, _qop, ha2));

            return string.Format("username=\"{0}\", realm=\"{1}\", nonce=\"{2}\", uri=\"{3}\", " +
            "algorithm=MD5, response=\"{4}\", qop=\"{5}\", nc=\"{6:00000000}\", cnonce=\"{7}\", opaque=\"{8}\"",
            Username, _realm, _nonce, dir, digestResponse, _qop, _nc, _cnonce, _opaque);
        }



        public override string ToData(HttpClient client, HttpMethod method, Uri uri)
        {
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
            var request = (HttpWebRequest)WebRequest.Create(uri);

            // If we've got a recent Auth header, re-use it!
            if (!string.IsNullOrEmpty(_cnonce) &&
                DateTime.Now.Subtract(_cnonceDate).TotalHours < 1.0)
            {
                request.Headers.Add("Authorization", GetDigestHeader(uri.PathAndQuery, method));
            }

            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                // Try to fix a 401 exception by adding a Authorization header
                if (ex.Response == null || ((HttpWebResponse)ex.Response).StatusCode != HttpStatusCode.Unauthorized)
                    throw;

                var wwwAuthenticateHeader = ex.Response.Headers["WWW-Authenticate"];
                _realm = GrabHeaderVar("realm", wwwAuthenticateHeader);
                _nonce = GrabHeaderVar("nonce", wwwAuthenticateHeader);
                _qop = GrabHeaderVar("qop", wwwAuthenticateHeader);
                _opaque = GrabHeaderVar("opaque", wwwAuthenticateHeader);
                _nc = 0;
                _cnonce = new Random().Next(123400, 9999999).ToString();
                _cnonceDate = DateTime.Now;

                return GetDigestHeader(uri.PathAndQuery, method);
            }
            return "";
        }


    }

    public class BearAuthorize : BaseAuthorize
    {
        public BearAuthorize(string username, string password) : base(username, password)
        {
        }

        public override AUTHORIZE_TYPE Key => AUTHORIZE_TYPE.Bearer;

        public override string ToData(HttpClient client, HttpMethod method, Uri uri)
        {
            return "";
        }
    }
    public class RequestConfig
    {
        public int Timeout { set; get; } = 20;
        public bool ByPassSSL { private set; get; } = true;
    }
    public enum CONTENT_TYPE
    {
        NONE,
        JSON,
        FORM_DATA
    }
    public interface IHttpRequest
    {
        Task<HttpResponseMessage> SendAsync(string url, HttpMethod method, object data = null, BaseAuthorize authorize = null, CONTENT_TYPE contentType = CONTENT_TYPE.JSON
            , Dictionary<string, string> headers = null, CancellationToken tk = default);
        Task<HttpResponseMessage> PostAsync(string url, string method, object data = null, BaseAuthorize authorize = null, CONTENT_TYPE contentType = CONTENT_TYPE.JSON
            , Dictionary<string, string> headers = null, CancellationToken tk = default);
    }
    public static class HttpRequestExtensions
    {
        public static StringContent AsJson(this object o) => new StringContent(JsonConvert.SerializeObject(o ?? new { }), Encoding.UTF8, "application/json");
        public static MultipartFormDataContent AsMultipart(this object o)
        {
            var formContent = new MultipartFormDataContent();
            o.GetType().GetProperties().ToList().ForEach(g =>
            {
                if (o.GetType() == typeof(byte[]) && g.CanRead && g.GetValue(o) != null)
                    formContent.Add(new StreamContent(new MemoryStream((byte[])g.GetValue(o))), g.Name);
                if (o.GetType() == typeof(Stream) && g.CanRead && g.GetValue(o) != null)
                    formContent.Add(new StreamContent((Stream)g.GetValue(o)), g.Name);
                else if (g.CanRead && g.GetValue(o) != null)
                    formContent.Add(new StringContent(g.GetValue(o).ToString()), g.Name);

            });
            return formContent;
        }

        public static MediaTypeHeaderValue GetContentType(this IHttpRequest r, CONTENT_TYPE contentType)
        {
            switch (contentType)
            {
                case CONTENT_TYPE.FORM_DATA:
                    return MediaTypeHeaderValue.Parse("multipart/form-data");
                default:
                    return MediaTypeHeaderValue.Parse("application/json");

            }
        }
    }
    public class HttpRequest_v2 : IHttpRequest, IDisposable
    {
        HttpClient client;
        HttpClientHandler handler;
        public HttpRequest_v2(RequestConfig config = default)
        {
            handler = new HttpClientHandler();
            ServicePointManager.DefaultConnectionLimit = 16;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            client = new HttpClient();
            if (config == null)
                config = new RequestConfig();

            if (config.ByPassSSL)
            {
                handler.ClientCertificateOptions = ClientCertificateOption.Manual;
                //handler.ServerCertificateCustomValidationCallback =
                //    (httpRequestMessage, cert, cetChain, policyErrors) =>
                //    {
                //        return true;
                //    };
                System.Net.ServicePointManager.Expect100Continue = false;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });

                client = new HttpClient(handler);
                client.Timeout = TimeSpan.FromSeconds(config.Timeout);
            }
        }

        public void Dispose()
        {
        }

        public async Task<HttpResponseMessage> SendAsync(string url, HttpMethod method, object data = null, BaseAuthorize authorize = null,
            CONTENT_TYPE contentType = CONTENT_TYPE.JSON, Dictionary<string, string> headers = null, CancellationToken tk = default)
        {

            return await PostAsync(url, method.Method, data, authorize, contentType, headers, tk);
        }

        public async Task<HttpResponseMessage> PostAsync(string url, string method, object data = null, BaseAuthorize authorize = null,
            CONTENT_TYPE contentType = CONTENT_TYPE.JSON, Dictionary<string, string> headers = null, CancellationToken tk = default)
        {
            try
            {
                Uri baseUri = new Uri(url);

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.ConnectionClose = true;
                if (client.BaseAddress == null)
                {
                    client.BaseAddress = baseUri;
                }
                HttpContent content = null;
                HttpResponseMessage message = null;
                using (var request = new HttpRequestMessage(new HttpMethod(method), url))
                {
                    if (authorize != null)
                        request.Headers.Add("Authorization", $"{authorize.Key} {authorize.ToData(client, new HttpMethod(method), baseUri)}");
                    if (headers != null)
                        foreach (var item in headers)
                        {
                            request.Headers.Add(item.Key, item.Value);
                        }
                    switch (contentType)
                    {
                        case CONTENT_TYPE.FORM_DATA:
                            content = data.AsMultipart();
                            content.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                            break;
                        case CONTENT_TYPE.JSON:
                            content = data.AsJson();
                            request.Headers.Add("Accept", "application/json");
                            content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                            break;
                        default:

                            break;
                    }
                    //var servicePoint = ServicePointManager.FindServicePoint(baseUri);
                    //servicePoint.Expect100Continue = false;
                    request.Content = content;
                    request.Method = new HttpMethod(method);
                    string curlScript = client.GenerateCurlInString(request);
                    Console.WriteLine(curlScript);
                    ////write log curl format file 
                    //string curlFileName = "--------" + url + "--------";
                    //curlFileName += Environment.NewLine;
                    //curlFileName += url;
                    //curlFileName += Environment.NewLine;
                    //curlFileName = "--------" + url + "--------";
                    ////log file path /app-data/curl.txt
                    //File.AppendAllText("/app-data/curl.txt", curlFileName);

                    message = await client.SendAsync(request, cancellationToken: tk);
                }
                return message;


            }
            catch (Exception e)
            {
                return await (Task<HttpResponseMessage>)Task.Run(() =>
                {
                    return new HttpResponseMessage
                    {
                        StatusCode = HttpStatusCode.InternalServerError,
                        Content = e.Message.AsJson()
                    };
                });
            }
        }
    }
}
