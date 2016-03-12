using System;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.YouTube.Exceptions {

    /// <summary>
    /// Class representing an exception/error returned by the YouTube API.
    /// </summary>
    public class YouTubeException : Exception {

        #region Properties

        /// <summary>
        /// Gets a reference to the underlying <see cref="SocialHttpResponse"/>.
        /// </summary>
        public SocialHttpResponse Response { get; private set; }

        /// <summary>
        /// Gets the error code.
        /// </summary>
        public int Code { get; private set; }

        #endregion

        #region Constructors

        internal YouTubeException(SocialHttpResponse response, int code, string message) : base(message) {
            Response = response;
            Code = code;
        }

        #endregion

    }

}