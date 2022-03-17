using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Client;
using Skybrud.Essentials.Http.Options;
using Skybrud.Social.Google.OAuth;

namespace Skybrud.Social.Google.Http {

    /// <summary>
    /// Class serving as a base class for the implementation for the various Google APIs.
    /// </summary>
    public class GoogleHttpClientBase : HttpClient {

        /// <summary>
        /// Gets a reference to the parent Google client.
        /// </summary>
        public GoogleOAuthClient Client { get; }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="client"/>.
        /// </summary>
        /// <param name="client">The parent Google client.</param>
        protected GoogleHttpClientBase(GoogleOAuthClient client) {
            Client = client;
        }

        /// <summary>
        /// Returns the response of the request identified by the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instanceo of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public override IHttpResponse GetResponse(IHttpRequestOptions options) {
            return Client.GetResponse(options);
        }

    }

}