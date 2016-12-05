using System.Net;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Exceptions;
using Skybrud.Social.Http;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.Common.Responses {

    /// <summary>
    /// Class representing a response from the one of the Google APIs.
    /// </summary>
    public class GoogleApiResponse : SocialResponse {

        #region Constructors

        protected GoogleApiResponse(SocialHttpResponse response) : base(response) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Validates the specified <code>response</code>.
        /// </summary>
        /// <param name="response">The response to be validated.</param>
        public static void ValidateResponse(SocialHttpResponse response) {

            // Skip error checking if the server responds with an OK status code
            if (response.StatusCode == HttpStatusCode.OK) return;

            JObject body = JObject.Parse(response.Body);
            JObject error = body.GetObject("error");
            throw new GoogleApiException(response, error.GetInt32("code"), error.GetString("message"));

        }

        #endregion

    }

    /// <summary>
    /// Class representing a response from the one of the Google APIs.
    /// </summary>
    public class GoogleApiResponse<T> : GoogleApiResponse {

        #region Properties

        /// <summary>
        /// Gets the body of the response.
        /// </summary>
        public T Body { get; protected set; }

        #endregion

        #region Constructors

        protected GoogleApiResponse(SocialHttpResponse response) : base(response) { }

        #endregion

    }

}