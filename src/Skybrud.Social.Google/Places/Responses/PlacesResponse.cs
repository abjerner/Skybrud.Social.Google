using System.Net;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Places.Exceptions;
using Skybrud.Social.Http;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Places.Responses {

    /// <summary>
    /// Class representing a response from the Google Places API.
    /// </summary>
    public class PlacesResponse : SocialResponse {

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <code>response</code>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        protected PlacesResponse(SocialHttpResponse response) : base(response) { }

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

            throw new PlacesException(response, code, message);

        }

        #endregion

    }

    /// <summary>
    /// Class representing a response from the Google Places API.
    /// </summary>
    public class PlacesResponse<T> : PlacesResponse {

        /// <summary>
        /// Gets the body of the response.
        /// </summary>
        public T Body { get; protected set; }

        /// <summary>
        /// Initializes a new instance based on the specified <code>response</code>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        protected PlacesResponse(SocialHttpResponse response) : base(response) { }

    }

}