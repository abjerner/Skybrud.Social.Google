using Skybrud.Essentials.Http;
using Skybrud.Social.Google.Models;

namespace Skybrud.Social.Google.Responses {

    /// <summary>
    /// Class representing the response for getting information about the authenticated user.
    /// </summary>
    public class GoogleUserInfoResponse : GoogleResponse<GoogleUserInfo> {

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        public GoogleUserInfoResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, GoogleUserInfo.Parse)!;
        }

    }

}