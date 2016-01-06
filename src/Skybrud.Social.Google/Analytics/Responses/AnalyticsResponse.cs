using System.Net;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Analytics.Exceptions;
using Skybrud.Social.Http;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Analytics.Responses {
    
    /// <summary>
    /// Class representing a response from the Analytics API.
    /// </summary>
    public class AnalyticsResponse : SocialResponse {

        #region Constructors
        
        protected AnalyticsResponse(SocialHttpResponse response) : base(response) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Validates the specified <code>response</code>.
        /// </summary>
        /// <param name="response">The response to be validated.</param>
        /// <param name="obj">The object representing the response object.</param>
        public static void ValidateResponse(SocialHttpResponse response) {

            // Skip error checking if the server responds with an OK status code
            if (response.StatusCode == HttpStatusCode.OK) return;

            JObject obj = ParseJsonObject(response.Body);

            JObject error = obj.GetObject("error");

            int code = error.GetInt32("code");
            string message = error.GetString("message");

            // TODO: Parse "errors"

            throw new AnalyticsException(response, code, message);

        }

        #endregion
        
    }

    /// <summary>
    /// Class representing a response from the Analytics API.
    /// </summary>
    public class AnalyticsResponse<T> : AnalyticsResponse {

        #region Properties

        /// <summary>
        /// Gets the body of the response.
        /// </summary>
        public T Body { get; protected set; }

        #endregion

        #region Constructors

        protected AnalyticsResponse(SocialHttpResponse response) : base(response) { }

        #endregion

    }

}