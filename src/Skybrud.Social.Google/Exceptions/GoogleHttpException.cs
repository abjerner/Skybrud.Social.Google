using System;
using System.Net;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Exceptions;

namespace Skybrud.Social.Google.Exceptions {
    
    /// <summary>
    /// Class representing an error returned by the Google API.
    /// </summary>
    public class GoogleHttpException : Exception, IHttpException {

        #region Properties

        /// <summary>
        /// Gets a reference to the underlying <see cref="IHttpResponse"/>.
        /// </summary>
        public IHttpResponse Response { get; }

        /// <summary>
        /// Gets the status code returned by the server.
        /// </summary>
        public HttpStatusCode StatusCode => Response.StatusCode;

        /// <summary>
        /// Gets the error code.
        /// </summary>
        public int Code { get; }

        /// <summary>
        /// Gets the message of the exception.
        /// </summary>
        public new string Message { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new innstance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="code">The error code parsed from the response body.</param>
        /// <param name="message">The error message parsed from the response body.</param>
        public GoogleHttpException(IHttpResponse response, int code, string message) : base(code + ": " + message) {
            Response = response;
            Code = code;
            Message = message;
        }

        #endregion

    }

}
