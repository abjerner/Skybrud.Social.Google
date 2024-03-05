using System;

namespace Skybrud.Social.Google.Exceptions;

/// <summary>
/// Class representing an exception related to the implementation for the Google API.
/// </summary>
public class GoogleException : Exception {

    /// <summary>
    /// Initializes a new exception based on the specified <paramref name="message"/>.
    /// </summary>
    /// <param name="message">The message of the exception.</param>
    public GoogleException(string message) : base(message) { }

    /// <summary>
    /// Initializes a new exception based on the specified <paramref name="message"/> and <paramref name="innerException"/>.
    /// </summary>
    /// <param name="message">The message of the exception.</param>
    /// <param name="innerException">The inner exception.</param>
    public GoogleException(string message, Exception? innerException) : base(message, innerException) { }

}