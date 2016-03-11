using Skybrud.Social.Google.YouTube.Endpoints.Raw;
using Skybrud.Social.Google.YouTube.Options;
using Skybrud.Social.Google.YouTube.Options.Videos;
using Skybrud.Social.Google.YouTube.Responses.Videos;

namespace Skybrud.Social.Google.YouTube.Endpoints {

    /// <summary>
    /// Class representing the videos endpoint.
    /// </summary>
    public class YouTubeVideosEndpoint {

        #region Properties

        /// <summary>
        /// Gets the parent endpoint of this endpoint.
        /// </summary>
        public YouTubeEndpoint YouTube { get; private set; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public YouTubeVideosRawEndpoint Raw {
            get { return YouTube.Service.Client.YouTube.Videos; }
        }

        #endregion

        #region Constructors

        internal YouTubeVideosEndpoint(YouTubeEndpoint youTube) {
            YouTube = youTube;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of videos based on the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="YouTubeGetVideoListResponse"/> representing the response.</returns>
        public YouTubeGetVideoListResponse GetVideos(YouTubeGetVideoListOptions options) {
            return YouTubeGetVideoListResponse.ParseResponse(Raw.GetVideos(options));
        }

        #endregion

    }

}