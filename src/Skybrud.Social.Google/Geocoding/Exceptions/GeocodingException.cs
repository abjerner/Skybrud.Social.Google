using System;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Geocoding.Exceptions {

    /// <summary>
    /// Class representing an exception/error returned by the Geocoding API.
    /// </summary>
    public class GeocodingException : Exception {

        #region Properties

        /// <summary>
        /// Gets a reference to the underlying <see cref="SocialHttpResponse"/>.
        /// </summary>
        public SocialHttpResponse Response { get; private set; }

        /// <summary>
        /// Gets the message of the exception.
        /// </summary>
        public new string Message { get; private set; }

        /// <summary>
        /// Gets the status of the exception/response.
        /// </summary>
        public string Status { get; private set; }

        #endregion

        #region Constructors

        internal GeocodingException(SocialHttpResponse response, string message, string status) {
            Response = response;
            Message = message;
            Status = status;
        }

        #endregion

    }

}