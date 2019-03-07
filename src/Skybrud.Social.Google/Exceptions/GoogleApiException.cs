using System;
using Skybrud.Essentials.Http;

namespace Skybrud.Social.Google.Exceptions {
    
    public class GoogleApiException : Exception {

        #region Properties

        /// <summary>
        /// Gets a reference to the underlying <see cref="IHttpResponse"/>.
        /// </summary>
        public IHttpResponse Response { get; private set; }

        /// <summary>
        /// Gets the error code.
        /// </summary>
        public int Code { get; private set; }

        /// <summary>
        /// Gets the message of the exception.
        /// </summary>
        public new string Message { get; private set; }

        #endregion

        #region Constructors

        public GoogleApiException(IHttpResponse response, int code, string message) : base(code + ": " + message) {
            Response = response;
            Code = code;
            Message = message;
        }

        #endregion

    }

}
