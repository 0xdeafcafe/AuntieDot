using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AuntieDot.Core.Exceptions;
using AuntieDot.Core.Helpers;

namespace AuntieDot.Authentication
{
    /// <summary>
    /// Helper class for requesting authorization codes compatible with X-343-Authorization-WLID
    /// </summary>
    public static class WLIDAuthentication
    {
        /// <summary>
        /// Authenticates with Windows Live ID & retrieves the "access code" 
        /// </summary>
        /// <param name="email">The email address of the user</param>
        /// <param name="password">The password of the user</param>
        /// <returns>The access token</returns>
        public static async Task<Token> RequestToken(string email, string password)
        {
            // Originals:
            // var\s+ServerData\s*=\s*[^<]+(<input(\s+[a-zA-Z0-9]+\s*=\s*("[^"]*"|[^ ]+))*\s*/?\s*>)
            // var\s+ServerData\s*=\s*[^<]+F\s*:\s*['"]([a-zA-Z0-9]*)['"]
            // var\s+user\s*=\s*\{\s*access_token\s*:\s*'([a-zA-Z0-9=/+]+)'\s*,\s*AuthenticationToken\s*:\s*'([a-zA-Z0-9=/+.]+)'\s*,\s*expires_in\s*:\s*([0-9]+)\s*\}
            const string cRegexLoginPPFT = "var\\s+ServerData\\s*=\\s*[^<]+(<input(\\s+[a-zA-Z0-9]+\\s*=\\s*(\"[^\"]*\"|[^ ]+))*\\s*/?\\s*>)";
            const string cRegexLoginPPSX = "var\\s+ServerData\\s*=\\s*[^<]+F\\s*:\\s*['\"]([a-zA-Z0-9]*)['\"]";
            const string cRegexLoginPPFTValue = "value=\"([^\"]+)\"";
            const string cRegexHaloTokens = "var\\s+user\\s*=\\s*\\{\\s*access_token\\s*:\\s*'([a-zA-Z0-9=/+]+)'\\s*,\\s*AuthenticationToken\\s*:\\s*'([a-zA-Z0-9=/+.]+)'\\s*,\\s*expires_in\\s*:\\s*([0-9]+)\\s*\\}";
            const string cUserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.11 (KHTML, like Gecko) Chrome/23.0.1271.97 Safari/537.11";
            const string cUrlHalo = "https://app.halowaypoint.com/en-us/";
            const string cUrlLogin = "https://login.live.com/oauth20_authorize.srf?client_id=000000004C0BD2F1&scope=xbox.basic%20xbox.offline_access&response_type=code&redirect_uri=https://app.halowaypoint.com/oauth/callback&state=MAdodHRwczovL2FwcC5oYWxvd2F5cG9pbnQuY29tL2VuLXVzLw&display=touch";
            const string cUrlLoginPost = "https://login.live.com/ppsecure/post.srf?client_id=000000004C0BD2F1&scope=xbox.basic%20xbox.offline_access&response_type=code&redirect_uri=https://app.halowaypoint.com/oauth/callback&state=MAdodHRwczovL2FwcC5oYWxvd2F5cG9pbnQuY29tL2VuLXVzLw&display=touch&bk=";

            var cookieContainer = new CookieContainer();
            string loginPPFT;
            string loginPPSX;

            #region Get secure form tag

            {
                var request = (HttpWebRequest)WebRequest.Create(cUrlLogin);
                request.Headers[HttpRequestHeader.UserAgent] = cUserAgent;
                request.Headers[HttpRequestHeader.Referer] = cUrlHalo;

                request.CookieContainer = cookieContainer;  

                var response = (HttpWebResponse) await request.GetResponseAsync();
                cookieContainer.Add(new Uri(cUrlLogin), response.Cookies);

                var responseStream = response.GetResponseStream();
                string html;

                if (responseStream == null)
                    return null;

                using (var reader = new StreamReader(responseStream))
                    html = await reader.ReadToEndAsync();

                var matchPPFT = Regex.Match(html, cRegexLoginPPFT, RegexOptions.IgnoreCase);
                var matchPPSX = Regex.Match(html, cRegexLoginPPSX, RegexOptions.IgnoreCase);

                if (!matchPPFT.Success || !matchPPSX.Success)
                    return null;

                loginPPFT = Regex.Match(matchPPFT.Groups[1].Value, cRegexLoginPPFTValue, RegexOptions.IgnoreCase).Groups[1].Value;
                loginPPSX = matchPPSX.Groups[1].Value;
            }

            #endregion

            #region POST form

            {
                var postData = VariousFunctions.StringToAscii(string.Format(
                    @"PPFT={0}&login={1}&passwd={2}&LoginOptions={3}&NewUser={4}&PPSX={5}&type={6}&i3={7}&m1={8}&m2={9}&m3={10}&i12={11}&i17={12}&i18={13}",
                    Uri.EscapeDataString(loginPPFT),
                    Uri.EscapeDataString(email),
                    Uri.EscapeDataString(password),
                    Uri.EscapeDataString("3"),
                    Uri.EscapeDataString("1"),
                    Uri.EscapeDataString(loginPPSX),
                    Uri.EscapeDataString("11"),
                    Uri.EscapeDataString(new Random().Next(15000, 50000).ToString()),
                    Uri.EscapeDataString("1920"),
                    Uri.EscapeDataString("1080"),
                    Uri.EscapeDataString("0"),
                    Uri.EscapeDataString("1"),
                    Uri.EscapeDataString("0"),
                    Uri.EscapeDataString("__MobileLogin|1,")));

                var request = (HttpWebRequest)WebRequest.CreateHttp(cUrlLoginPost);
                request.Method = HttpMethod.Post;
                request.ContentType = "application/x-www-form-urlencoded";
                request.Headers[HttpRequestHeader.UserAgent] = cUserAgent;
                request.Headers[HttpRequestHeader.Referer] = cUrlLogin;
                request.Headers[HttpRequestHeader.ContentLength] = postData.Length.ToString();
                request.CookieContainer = cookieContainer;

                var requestStream = await request.GetRequestStreamAsync();
                await requestStream.WriteAsync(postData, 0, postData.Length);

                var response = (HttpWebResponse) await request.GetResponseAsync();
                cookieContainer.Add(new Uri(cUrlHalo), response.Cookies);

                var responseStream = response.GetResponseStream();

                if (responseStream == null)
                    return null;

                var html = new StreamReader(responseStream).ReadToEnd();

                if (response.ResponseUri.Host.ToLower() != "app.halowaypoint.com" && html.Contains("Consent/Update"))
                    throw new OAuthConsentNotGivenException();

                if ((html.Contains("text_errorMessage") || html.Contains("text_errorMessage_errorCode")) && html.Contains("respawnBtn"))
                    throw new OAuthWaypointRedirectError();


// ReSharper disable JoinDeclarationAndInitializer
                string accessToken, authenticationToken;
                int expiresIn;
// ReSharper restore JoinDeclarationAndInitializer

                #region HtmlAgility
                //var htmlDoc = new HtmlDocument();
                //htmlDoc.LoadHtml(html);
                //foreach (var editedScript in htmlDoc.DocumentNode.SelectNodes("//script").Where(script => script.InnerText.Contains("access_token") && script.InnerText.Contains("AuthenticationToken") && script.InnerText.Contains("expires_in")).Select(script => script.InnerText.Replace(" ", "").Replace("varuser=", "").TrimEnd(';')))
                //{
                //    var tokenData = await JsonConvert.DeserializeObject<Dictionary<string, string>>(editedScript);
                //    accessToken = tokenData["access_token"];
                //    authenticationToken = tokenData["AuthenticationToken"];
                //    expiresIn = int.Parse(tokenData["expires_in"]);
                //    break;
                //}
                #endregion

                #region Regex
                var match = Regex.Match(html, cRegexHaloTokens);

                if (!match.Success)
                    return null;

                accessToken = match.Groups[1].Value;
                authenticationToken = match.Groups[2].Value;
                expiresIn = int.Parse(match.Groups[3].Value);
                #endregion

                return
                    new Token
                    {
                        AccessToken = accessToken,
                        AuthenticationToken = authenticationToken,
                        Expires = DateTime.Now.AddSeconds(expiresIn)
                    };
            }

            #endregion
        }

        /// <summary>
        /// Windows Live authentication token
        /// </summary>
        public class Token
        {
            /// <summary>
            /// Access token used for converting to other token types - e.g. SpartanAuthentication.Token
            /// </summary>
            public string AccessToken { get; set; }

            /// <summary>
            /// Authentication token used to authenticate requests made on behalf of the relevant user
            /// </summary>
            public string AuthenticationToken { get; set; }

            /// <summary>
            /// When the token will expire
            /// </summary>
            public DateTime Expires { get; set; }
        }
    }
}