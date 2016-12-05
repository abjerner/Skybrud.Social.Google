using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.YouTube.Objects.PlaylistItems {

    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/playlistItems#status</cref>
    /// </see>    
    public class YouTubePlaylistItemStatus : GoogleApiObject {

        #region Properties

        public YouTubePrivacyStatus PrivacyStatus { get; private set; }

        #endregion

        #region Constructor

        protected YouTubePlaylistItemStatus(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <code>YouTubePlaylistItemStatus</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static YouTubePlaylistItemStatus Parse(JObject obj) {
            
            if (obj == null) return null;

            // Parse the privacy status
            YouTubePrivacyStatus status;
            string strStatus = obj.GetString("privacyStatus");
            if (!Enum.TryParse(strStatus, true, out status)) {
                throw new Exception("Unknown privacy status \"" + strStatus + "\" - please create an issue so it can be fixed https://github.com/abjerner/Skybrud.Social/issues/new");
            }

            return new YouTubePlaylistItemStatus(obj) {
                PrivacyStatus = status
            };
        
        }

        #endregion

    }

}