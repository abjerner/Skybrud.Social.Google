using System;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Common.Exceptions {
    
    public class GoogleApiException : Exception {

        #region Properties

        /// <summary>
        /// Gets a reference to the underlying <see cref="SocialHttpResponse"/>.
        /// </summary>
        public SocialHttpResponse Response { get; private set; }

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

        public GoogleApiException(SocialHttpResponse response, int code, string message) : base(code + ": " + message) {
            Response = response;
            Code = code;
            Message = message;
        }

        #endregion

    }

}
