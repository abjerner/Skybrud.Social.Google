using System.Net;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Exceptions;

namespace Skybrud.Social.Google.Responses {

    /// <summary>
    /// Class representing a response from the one of the Google APIs.
    /// </summary>
    public class GoogleResponse : HttpResponseBase {

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        public GoogleResponse(IHttpResponse response) : base(response) {

            // Skip error checking if the server responds with an OK status code
            if (response.StatusCode == HttpStatusCode.OK) return;

            JObject body = JObject.Parse(response.Body);
            JObject error = body.GetObject("error")!;
            throw new GoogleHttpException(response, error.GetInt32("code"), error.GetString("message")!);

        }

    }

    /// <summary>
    /// Class representing a response from the one of the Google APIs.
    /// </summary>
    public class GoogleResponse<T> : GoogleResponse {

        #region Properties

        /// <summary>
        /// Gets the body of the response.
        /// </summary>
        public T Body { get; protected set; } = default!;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        public GoogleResponse(IHttpResponse response) : base(response) { }

        #endregion

    }

}