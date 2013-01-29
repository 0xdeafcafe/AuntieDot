using System;

namespace AuntieDot.UI.Web.Connector
{
	public static class DataModels
	{
		public class CachedService
		{
			public DateTime Expires { get; set; }
			public string JsonCache { get; set; }
		}
		public class CachedPlayer
		{
			public DateTime Expires { get; set; }
			public string JsonCache { get; set; }
			public string PlayerName { get; set; }
		}
	}
}