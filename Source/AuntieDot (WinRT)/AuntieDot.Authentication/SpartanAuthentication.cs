using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using AuntieDot.Core.Helpers;

namespace AuntieDot.Authentication
{
    /// <summary>
    /// Helper class for requesting authorization codes compatible with X-343-Authorization-Spartan
    /// </summary>
    public static class SpartanAuthentication
    {
        /// <summary>
        /// This requests a SpartanToken from 343's Halo Waypoint API.
        /// </summary>
        /// <param name="accessToken">The Access Token that was returned by Windows Live's OAuth.</param>
        /// <returns>The Spartan Token for the specified Access Token. Enter this into the constructor of AuntieDot</returns>
        public static async Task<Token> RequestToken(string accessToken)
        {
            var request = (HttpWebRequest)WebRequest.Create(new Uri("https://settings.svc.halowaypoint.com/RegisterClientService.svc/spartantoken/wlid"));
            request.Method = HttpMethod.Get;
            request.Headers["X-343-Authorization-WLID"] = "v1=" + accessToken;
            request.Accept = "application/json";

            var response = await request.GetResponseAsync();
            var stream = response.GetResponseStream();

            if (stream == null)
                return null;

            var json = new StreamReader(stream).ReadToEnd();
            var token = JsonConvert.DeserializeObject<Token>(json);

            switch (token.ResponseCode)
            {
                case 1:
                    return token;

            }

            throw new Exception("Retrieval of token failed - error code " + token.ResponseCode);
        }

        /// <summary>
        /// Spartan authentication token
        /// </summary>
        public class Token
        {
            /// <summary>
            /// Indicates the result of the request
            /// </summary>
            /// <remarks>Internal to assembly only - will only be returned if code is 1 anyway</remarks>
            public int ResponseCode { get; set; }

            /// <summary>
            /// Actual token - compatible with X-343-Authorization-Spartan
            /// </summary>
            public string SpartanToken { get; set; }

            /// <summary>
            /// Identifies the user token is for
            /// </summary>
            public UserInformation UserInformation { get; set; }
        }

        /// <summary>
        /// Information about the user identified by the Spartan auth
        /// </summary>
        public class UserInformation
        {
            /// <summary>
            /// XBL gamertag of user
            /// </summary>
            public string Gamertag { get; set; }

            /// <summary>
            /// Used to track API usage
            /// </summary>
            /// <remarks>Unused</remarks>
            public string AnalyticsToken { get; set; }
        }
    }
}
