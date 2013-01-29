using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace AuntieDot.Core.Helpers
{
	public static class HttpExtensions
	{
        public static Task<Stream> GetRequestStreamAsync(this HttpWebRequest request)
		{
			var taskComplete = new TaskCompletionSource<Stream>();

			request.BeginGetRequestStream(ar =>
			{
				var requestStream = request.EndGetRequestStream(ar);
				taskComplete.TrySetResult(requestStream);
			}, request);
			
			return taskComplete.Task;
		}

        public static Task<HttpWebResponse> GetResponseAsync(this HttpWebRequest request)
        {
            var taskComplete = new TaskCompletionSource<HttpWebResponse>();
            request.BeginGetResponse(asyncResponse =>
            {
                try
                {
                    var responseRequest = (HttpWebRequest)asyncResponse.AsyncState;
                    var someResponse = (HttpWebResponse)responseRequest.EndGetResponse(asyncResponse);
                    taskComplete.TrySetResult(someResponse);
                }
                catch (WebException webExc)
                {
                    var failedResponse = (HttpWebResponse)webExc.Response;
                    taskComplete.TrySetResult(failedResponse);
                }
            }, request);
            return taskComplete.Task;
        }
	}

	public static class HttpMethod
	{
		public const string Head = "HEAD";
		public const string Post = "POST";
		public const string Put = "PUT";
		public const string Get = "GET";
		public const string Delete = "DELETE";
		public const string Trace = "TRACE";
		public const string Options = "OPTIONS";
		public const string Connect = "CONNECT";
		public const string Patch = "PATCH";
	}
}
