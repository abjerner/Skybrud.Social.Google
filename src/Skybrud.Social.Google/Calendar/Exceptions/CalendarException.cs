using System;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Calendar.Exceptions {

    public class CalendarException : Exception {

        #region Properties

        /// <summary>
        /// Gets a reference to the underlying <code>SocialHttpResponse</code>.
        /// </summary>
        public SocialHttpResponse Response { get; private set; }

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