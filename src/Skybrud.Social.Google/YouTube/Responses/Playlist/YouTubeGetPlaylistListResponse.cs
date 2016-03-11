using Skybrud.Social.Google.YouTube.Objects.Playlists;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.YouTube.Responses.Playlist {

    /// <summary>
    /// Class representing the response for getting a list of playlists.
    /// </summary>
    public class YouTubeGetPlaylistListResponse : YouTubeResponse<YouTubePlaylistList> {

        #region Constructors

        private YouTubeGetPlaylistListResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, YouTubePlaylistList.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="YouTubeGetPlaylistListResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        public static YouTubeGetPlaylistListResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new YouTubeGetPlaylistListResponse(response);
        }

        #endregion

    }

}