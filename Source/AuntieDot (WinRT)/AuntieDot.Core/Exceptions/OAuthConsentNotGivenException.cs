namespace AuntieDot.Core.Exceptions
{
	public class OAuthConsentNotGivenException : System.Exception
	{
		public OAuthConsentNotGivenException() { }

		public OAuthConsentNotGivenException(string message)
			: base(message)
		{ }

		public OAuthConsentNotGivenException(string message, System.Exception innerException)
			: base(message, innerException)
		{ }
	}
}
