using Skybrud.Essentials.Http;
using Skybrud.Social.Google.Models.Authentication;

namespace Skybrud.Social.Google.Responses.Authentication;

/// <summary>
/// Class representing a response with information about an access token (<see cref="GoogleToken"/>).
/// </summary>
public class GoogleTokenResponse : GoogleResponse<GoogleToken> {

    /// <summary>
    /// Initializes a new instance based on the specified <paramref name="response"/>.
    /// </summary>
    /// <param name="response">The underlying raw response the instance should be based on.</param>
    public GoogleTokenResponse(IHttpResponse response) : base(response) {
        Body = ParseJsonObject(response.Body, GoogleToken.Parse)!;
    }

}