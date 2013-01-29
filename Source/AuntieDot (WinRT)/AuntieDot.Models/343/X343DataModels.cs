using System.Collections.Generic;

namespace AuntieDot.Models._343
{
	public class X343DataModels
	{
		// X343 Serices List
		public class ServicesList
		{
			public int ResponseCode { get; set; }
			public int TokenResponseCode { get; set; }
			public string Identifier { get; set; }
			public int State { get; set; }
			public string ClientStatusMessage { get; set; }
			public string DeprecationTime { get; set; }

			public Dictionary<string, string> ServiceList { get; set; }
			public Dictionary<string, string> Settings { get; set; }

			public string UserInformation { get; set; }
			public string SpartanToken { get; set; }
		}
	}
}
