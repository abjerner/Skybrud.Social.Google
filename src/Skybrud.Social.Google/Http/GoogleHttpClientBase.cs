using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Client;
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
        /// Virtual method that can be used for configuring a request.
        /// </summary>
        /// <param name="request">The instance of <see cref="IHttpRequest"/> representing the request.</param>
        protected override void PrepareHttpRequest(IHttpRequest request) {
            Client.PrepareHttpRequestInternal(request);
        }

    }

}