using System.Net;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Geocoding.Exceptions;
using Skybrud.Social.Google.Places.Exceptions;
using Skybrud.Social.Google.Places.Responses;
using Skybrud.Social.Http;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.Geocoding.Responses {

    /// <summary>
    /// Class representing a response from the Geocoding API.
    /// </summary>
    public class GeocodingResponse : SocialResponse {

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <code>response</code>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        protected GeocodingResponse(SocialHttpResponse response) : base(response) { }

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

            string message = obj.GetString("error_message");
            string status = obj.GetString("status");

            throw new GeocodingException(response, message, status);

        }

        #endregion

    }

    /// <summary>
    /// Class representing a response from the Geocoding API.
    /// </summary>
    public class GeocodingResponse<T> : GeocodingResponse {

        /// <summary>
        /// Gets the body of the response.
        /// </summary>
        public T Body { get; protected set; }

        /// <summary>
        /// Initializes a new instance based on the specified <code>response</code>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        protected GeocodingResponse(SocialHttpResponse response) : base(response) { }

    }

}