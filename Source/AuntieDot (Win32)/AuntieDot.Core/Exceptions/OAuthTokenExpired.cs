namespace AuntieDot.Core.Exceptions
{
	public class OAuthTokenExpired : System.Exception
	{
		public OAuthTokenExpired() { }

		public OAuthTokenExpired(string message)
			: base(message)
		{ }

		public OAuthTokenExpired(string message, System.Exception innerException)
			: base(message, innerException)
		{ }
	}
}
