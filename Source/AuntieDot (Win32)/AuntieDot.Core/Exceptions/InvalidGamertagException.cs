namespace AuntieDot.Core.Exceptions
{
	public class InvalidGamertagException : System.Exception
	{
		public InvalidGamertagException() { }

		public InvalidGamertagException(string message)
			: base(message)
		{ }

		public InvalidGamertagException(string message, System.Exception innerException)
			: base(message, innerException)
		{ }
	}
}
