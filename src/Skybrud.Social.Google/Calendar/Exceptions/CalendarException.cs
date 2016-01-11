using System;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Calendar.Exceptions {

    /// <summary>
    /// Class representing an error returned by the Google Calendar API.
    /// </summary>
    public class CalendarException : Exception {

        #region Properties

        /// <summary>
        /// Gets a reference to the underlying <code>SocialHttpResponse</code>.
        /// </summary>
        public SocialHttpResponse Response { get; private set; }

        /// <summary>
        /// Gets the error code.
        /// </summary>
        public int Code { get; private set; }

        #endregion

        #region Constructors

        internal CalendarException(SocialHttpResponse response, int code, string message) : base(message) {
            Response = response;
            Code = code;
        }

        #endregion

    }

}