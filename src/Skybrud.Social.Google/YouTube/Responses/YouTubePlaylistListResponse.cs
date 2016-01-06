using Skybrud.Social.Google.YouTube.Objects.Playlists;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.YouTube.Responses {

    public class YouTubePlaylistListResponse : YouTubeResponse<YouTubePlaylistList> {

        #region Constructors

        private YouTubePlaylistListResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, YouTubePlaylistList.Parse);

        }

        #endregion

        #region Static methods

        public static YouTubePlaylistListResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new YouTubePlaylistListResponse(response);
        }

        #endregion

    }

}