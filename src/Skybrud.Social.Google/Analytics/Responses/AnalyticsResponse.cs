using System.Net;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Analytics.Exceptions;
using Skybrud.Social.Http;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.Analytics.Responses {
    
    /// <summary>
    /// Class representing a response from the Analytics API.
    /// </summary>
    public class AnalyticsResponse : SocialResponse {

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <code>response</code>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        protected AnalyticsResponse(SocialHttpResponse response) : base(response) { }

        #endregion

        #region Static methods

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

        /// <summary>
        /// Initializes a new instance based on the specified <code>response</code>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        protected AnalyticsResponse(SocialHttpResponse response) : base(response) { }

        #endregion

    }

}