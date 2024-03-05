using System;

#pragma warning disable 1591

namespace Skybrud.Social.Google.Exceptions;

public class GoogleOAuthException : GoogleException {

    #region Properties

    public string Error { get; }

    /// <summary>
    /// A more user-friendly description of the error. The description may not be specified for all errors.
    /// </summary>
    public string? Description { get; }

    #endregion

    #region Constructors

    public GoogleOAuthException(string error, string? description) : base(description ?? error) {
        Error = error;
        Description = description;
    }

    #endregion

}