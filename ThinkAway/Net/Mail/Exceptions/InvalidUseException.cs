﻿using ThinkAway.Net.Mail.POP3;

namespace ThinkAway.Net.Mail.Exceptions
{
	/// <summary>
	/// Thrown when the <see cref="PopClient"/> is being used in an invalid way.<br/>
	/// This could for example happen if a someone tries to fetch a message without authenticating.
	/// </summary>
    internal class InvalidUseException : PopClientException
	{

		///<summary>
		/// Creates a InvalidUseException with the given message
		///</summary>
		///<param name="message">The message to include in the exception</param>
		public InvalidUseException(string message)
			: base(message)
		{ }

        public InvalidUseException(string message, System.ArgumentException innerException)
            : base(message, innerException)
        {
        }
	}
}