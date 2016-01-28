using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.YouTube.Objects.Playlists {

    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/playlists#status</cref>
    /// </see>
    public class YouTubePlaylistStatus : GoogleApiObject {

        #region Properties

        public YouTubePrivacyStatus PrivacyStatus { get; private set; }

        #endregion

        #region Constructor

        protected YouTubePlaylistStatus(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <code>YouTubePlaylistStatus</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static YouTubePlaylistStatus Parse(JObject obj) {
            
            if (obj == null) return null;

            // Parse the privacy status
            YouTubePrivacyStatus status;
            string strStatus = obj.GetString("privacyStatus");
            if (!Enum.TryParse(strStatus, true, out status)) {
                throw new Exception("Unknown privacy status \"" + strStatus + "\" - please create an issue so it can be fixed https://github.com/abjerner/Skybrud.Social/issues/new");
            }
            
            return new YouTubePlaylistStatus(obj) {
                PrivacyStatus = status
            };
        
        }

        #endregion

    }

}