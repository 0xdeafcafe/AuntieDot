using System;
using System.Configuration;
using System.Web;

namespace AuntieDot.UI.Web
{
	public class Global : HttpApplication
	{
		void Application_Start(object sender, EventArgs e)
		{
			// Code that runs on application startup
#if DEBUG
			ConfigurationManager.AppSettings["DatabaseType"] = "Sandbox";
#else
            ConfigurationManager.AppSettings["DatabaseType"] = "Production";
#endif
		}

		void Application_End(object sender, EventArgs e)
		{
			//  Code that runs on application shutdown

		}

		void Application_Error(object sender, EventArgs e)
		{
			// Code that runs when an unhandled error occurs

		}
	}
}
