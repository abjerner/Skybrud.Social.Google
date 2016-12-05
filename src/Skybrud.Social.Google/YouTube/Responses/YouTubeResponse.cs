using System.Net;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.YouTube.Exceptions;
using Skybrud.Social.Http;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.YouTube.Responses {

    /// <summary>
    /// Class representing a response from the YouTube API.
    /// </summary>
    public class YouTubeResponse : SocialResponse {

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <code>response</code>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        protected YouTubeResponse(SocialHttpResponse response) : base(response) { }

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

            throw new YouTubeException(response, code, message);

        }

        #endregion

    }

    /// <summary>
    /// Class representing a response from the YouTube API.
    /// </summary>
    public class YouTubeResponse<T> : YouTubeResponse {

        /// <summary>
        /// Gets the body of the response.
        /// </summary>
        public T Body { get; protected set; }

        /// <summary>
        /// Initializes a new instance based on the specified <code>response</code>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        protected YouTubeResponse(SocialHttpResponse response) : base(response) { }

    }

}