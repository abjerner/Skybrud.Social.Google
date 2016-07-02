using System.Net;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Calendar.Exceptions;
using Skybrud.Social.Http;
using Skybrud.Social.Json.Extensions;

namespace Skybrud.Social.Google.Calendar.Responses {

    /// <summary>
    /// Class representing a response from the Calendar API.
    /// </summary>
    public class CalendarResponse : SocialResponse {

        #region Constructors

        protected CalendarResponse(SocialHttpResponse response) : base(response) { }

        #endregion

        #region Static methodssponse = response;

        /// <summary>
        /// Validates the specified <code>response</code>.
        /// </summary>
        /// <param name="response">The response to be validated.</param>
        public static void ValidateResponse(SocialHttpResponse response) {

            // Skip error checking if the server responds with an OK status code
            if (response.StatusCode == HttpStatusCode.OK) return;

            JObject obj = ParseJsonObject(response.Body);

            JObject error = obj.GetObject("error");

            int code = error.GetInt32("code");
            string message = error.GetString("message");

            // TODO: Parse "errors"

            throw new CalendarException(response, code, message);

        }

        #endregion

    }

    /// <summary>
    /// Class representing a response from the Calendar API.
    /// </summary>
    public class CalendarResponse<T> : CalendarResponse {

        /// <summary>
        /// Gets the body of the response.
        /// </summary>
        public T Body { get; protected set; }

        protected CalendarResponse(SocialHttpResponse response) : base(response) { }

    }

}