namespace AuntieDot.Core.Exceptions
{
	public class OAuthWaypointRedirectError : System.Exception
	{
		public OAuthWaypointRedirectError() { }

		public OAuthWaypointRedirectError(string message)
			: base(message)
		{ }

        public OAuthWaypointRedirectError(string message, System.Exception innerException)
			: base(message, innerException)
		{ }
	}
}
