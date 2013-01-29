using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AuntieDot.Core.Helpers
{
	public static class VariousFunctions
	{
		public static async Task<string> SendGetRequestAsync(string url, Dictionary<string, string> headers)
		{
			var noCache = string.Format(url.Contains("?") ? "&_={0}" : "?_={0}", Environment.TickCount);

			var request = (HttpWebRequest)WebRequest.Create(new Uri(url + noCache));

			request.Method = HttpMethod.Get;
			request.Accept = "application/json";

			foreach (var header in headers.Where(header => header.Key != "" && header.Value != ""))
                request.Headers[header.Key] = header.Value;

            var response = await request.GetResponseAsync();
            var stream = response.GetResponseStream();

		    return stream == null ? null : new StreamReader(stream).ReadToEnd();
		}
        public static string SendGetRequest(string url, Dictionary<string, string> headers)
        {
            var noCache = string.Format(url.Contains("?") ? "&_={0}" : "?_={0}", Environment.TickCount);

            var request = (HttpWebRequest)WebRequest.Create(new Uri(url + noCache));

            request.Method = HttpMethod.Get;
            request.Accept = "application/json";

            foreach (var header in headers.Where(header => header.Key != "" && header.Value != ""))
                request.Headers[header.Key] = header.Value;

            var response = AsyncHelpers.RunSync(request.GetResponseAsync);
            var stream = response.GetResponseStream();

            return stream == null ? null : new StreamReader(stream).ReadToEnd();
        }

        public static byte[] StringToAscii(string s)
        {
            var retval = new byte[s.Length];
            for (var ix = 0; ix < s.Length; ++ix)
            {
                var ch = s[ix];
                if (ch <= 0x7f) retval[ix] = (byte)ch;
                else retval[ix] = (byte)'?';
            }
            return retval;
        }
	}
}
