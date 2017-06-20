using Skybrud.Social.Google.YouTube.Models.PlaylistItems;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.YouTube.Responses.PlaylistItems {

    /// <summary>
    /// Class representing the response for getting a list of playlist items.
    /// </summary>
    public class YouTubeGetPlaylistItemListResponse : YouTubeResponse<YouTubePlaylistItemList> {

        #region Constructors

        private YouTubeGetPlaylistItemListResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, YouTubePlaylistItemList.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="YouTubeGetPlaylistItemListResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        public static YouTubeGetPlaylistItemListResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new YouTubeGetPlaylistItemListResponse(response);
        }

        #endregion

    }

}