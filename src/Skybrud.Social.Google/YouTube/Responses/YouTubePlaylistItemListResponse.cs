using Skybrud.Social.Google.YouTube.Objects.PlaylistItems;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.YouTube.Responses {

    public class YouTubePlaylistItemListResponse : YouTubeResponse<YouTubePlaylistItemList> {

        #region Constructors

        private YouTubePlaylistItemListResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, YouTubePlaylistItemList.Parse);

        }

        #endregion

        #region Static methods

        public static YouTubePlaylistItemListResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new YouTubePlaylistItemListResponse(response);
        }

        #endregion

    }

}