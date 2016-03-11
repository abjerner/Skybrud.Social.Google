using System;
using Skybrud.Social.Google.Common.OAuth;
using Skybrud.Social.Google.YouTube.Options;
using Skybrud.Social.Google.YouTube.Options.Videos;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.YouTube.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw videos endpoint.
    /// </summary>
    public class YouTubeVideosRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public GoogleOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal YouTubeVideosRawEndpoint(GoogleOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of videos based on the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetVideos(YouTubeGetVideoListOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return Client.DoHttpGetRequest("https://www.googleapis.com/youtube/v3/videos", options);
        }

        #endregion

    }

}