using AuntieDot.Core;
using AuntieDot.Core.Helpers;
using AuntieDot.Models._343;
using AuntieDot.X343Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AuntieDot
{
    public class AuntieDotManager
    {
        #region Private
        private readonly Settings _settings;
        #endregion

        #region Public
        public ServicesList ServicesList { get; private set; }
        #endregion

        /// <summary>
        /// Initalize a new Instance of AuntieDot. The most badass, cigar chompiest HaloWaypoint Stat Wrapper there is!
        /// </summary>
        /// <param name="spartanToken">The 343 Spartan Token, this can be obtained in AuntieDot.Authentication</param>
        /// <param name="gamertagFromAuth">The gamertag that was used in the original WLID OAuth process.</param>
        public AuntieDotManager(string spartanToken, string gamertagFromAuth)
        {
            _settings = new Settings
            {
                Language = "en-US",
                Game = "h4",
                SpartanToken = spartanToken,
                GamertagFromAuth = gamertagFromAuth
            };

            ServicesList = new ServicesList();
        }

        #region Services List
        public async Task GetServicesListAsync()
        {
            var jsonString = await CallX343ApiAsync(ServicesList.ServicesListUrl);
            var parsedJson = JsonConvert.DeserializeObject<X343DataModels.ServicesList>(jsonString);

            ServicesList = new ServicesList
            {
                ServiceList = parsedJson.ServiceList,
                Settings = parsedJson.Settings
            };
        }
        public void GetServicesList()
        {
            var jsonString = CallX343Api(ServicesList.ServicesListUrl);
            SetServicesList(jsonString);
        }
        public void GetServicesList(string jsonString)
        {
            var parsedJson = JsonConvert.DeserializeObject<X343DataModels.ServicesList>(jsonString);

            ServicesList = new ServicesList
            {
                ServiceList = parsedJson.ServiceList,
                Settings = parsedJson.Settings
            };
        }

        public async Task SetServicesListAsync(string jsonString)
        {
            var parsedJson = JsonConvert.DeserializeObject<X343DataModels.ServicesList>(jsonString);

            ServicesList = new ServicesList
            {
                ServiceList = parsedJson.ServiceList,
                Settings = parsedJson.Settings
            };
        }
        public void SetServicesList(string jsonString)
        {
            var parsedJson = JsonConvert.DeserializeObject<X343DataModels.ServicesList>(jsonString);

            ServicesList = new ServicesList
            {
                ServiceList = parsedJson.ServiceList,
                Settings = parsedJson.Settings
            };
        }
        #endregion

        #region API Callers
        public async Task<string> CallX343ApiAsync(string url, string gamertag = null, Dictionary<string, string> replacementVariables = null)
        {
            if (gamertag == null) gamertag = string.Empty;
            if (replacementVariables == null) replacementVariables = new Dictionary<string, string>();

            replacementVariables.Add("{language}", _settings.Language);
            replacementVariables.Add("{game}", _settings.Game);
            replacementVariables.Add("{gamertag}", string.IsNullOrWhiteSpace(gamertag) ?
                _settings.GamertagFromAuth : gamertag);

            return await SendGetRequestAsync(PopulateUrl(url, replacementVariables), _settings.SpartanToken, RequestAuthType.Spartan);
        }
        public string CallX343Api(string url, string gamertag = null, Dictionary<string, string> replacementVariables = null)
        {
            if (gamertag == null) gamertag = string.Empty;
            if (replacementVariables == null) replacementVariables = new Dictionary<string, string>();

            replacementVariables.Add("{language}", _settings.Language);
            replacementVariables.Add("{game}", _settings.Game);
            replacementVariables.Add("{gamertag}", string.IsNullOrWhiteSpace(gamertag) ?
                _settings.GamertagFromAuth : gamertag);

            return SendGetRequest(PopulateUrl(url, replacementVariables), _settings.SpartanToken, RequestAuthType.Spartan);
        }
        #endregion

        #region Helpers
        public string CreateUrlFromObject(Models._343.Common.ImageUrl imageUrl, string size)
        {
            var assetUrl = ServicesList.Settings[imageUrl.BaseUrl] + imageUrl.AssetUrl;
            assetUrl = assetUrl.Replace("{size}", size.ToLower());
            return assetUrl;
        }

        private static async Task<string> SendGetRequestAsync(string url, string spartanToken, RequestAuthType authType)
        {
            var noCache = string.Format(url.Contains("?") ? "&_={0}" : "?_={0}", Environment.TickCount);

            var request = (HttpWebRequest)WebRequest.Create(new Uri(url + noCache));

            request.Method = HttpMethod.Get;
            request.Accept = "application/json";

            switch (authType)
            {
                case RequestAuthType.Spartan:
                    request.Headers["X-343-Authorization-Spartan"] = spartanToken;
                    break;
            }

            var response = await request.GetResponseAsync();
            var stream = response.GetResponseStream();

            return stream == null ? null : new StreamReader(stream).ReadToEnd();
        }
        private static string SendGetRequest(string url, string spartanToken, RequestAuthType authType)
        {
            var noCache = string.Format(url.Contains("?") ? "&_={0}" : "?_={0}", Environment.TickCount);

            var request = (HttpWebRequest)WebRequest.Create(new Uri(url + noCache));

            request.Method = HttpMethod.Get;
            request.Accept = "application/json";

            switch (authType)
            {
                case RequestAuthType.Spartan:
                    request.Headers["X-343-Authorization-Spartan"] = spartanToken;
                    break;
            }

            var response = request.GetResponseAsync().Result;
            var stream = response.GetResponseStream();

            return stream == null ? null : new StreamReader(stream).ReadToEnd();
        }

        private static string PopulateUrl(string url, Dictionary<string, string> replacementVariables)
        {
            return replacementVariables.Aggregate(url, (current, key) => current.Replace(key.Key, key.Value));
        }
        #endregion

        #region Enums
        private enum RequestAuthType
        {
            Spartan
        }
        #endregion
    }
}