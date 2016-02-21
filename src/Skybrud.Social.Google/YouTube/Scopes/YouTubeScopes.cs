namespace Skybrud.Social.Google.YouTube.Scopes {
    
    /// <summary>
    /// Static class containing references to known scopes of the YouTube API.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/guides/auth/server-side-web-apps#Obtaining_Access_Tokens</cref>
    /// </see>
    public static class YouTubeScopes {

        #region Readonly properties

        /// <summary>
        /// Manage your YouTube account.
        /// </summary>
        public static readonly YouTubeScope Manage = new YouTubeScope(
            "https://www.googleapis.com/auth/youtube",
            "Manage",
            "Manage your YouTube account."
        );

        /// <summary>
        /// View your YouTube account.
        /// </summary>
        public static readonly YouTubeScope Readonly = new YouTubeScope(
            "https://www.googleapis.com/auth/youtube.readonly",
            "Readonly",
            "View your YouTube account."
        );

        /// <summary>
        /// Upload YouTube videos and manage your YouTube videos.
        /// </summary>
        public static readonly YouTubeScope Upload = new YouTubeScope(
            "https://www.googleapis.com/auth/youtube.upload",
            "Upload",
            "Upload YouTube videos and manage your YouTube videos."
        );

        /// <summary>
        /// Retrieve the auditDetails part in a channel resource.
        /// </summary>
        public static readonly YouTubeScope PartnerChannelAudit = new YouTubeScope(
            "https://www.googleapis.com/auth/youtubepartner-channel-audit",
            "Audit partner channel",
            "Retrieve the auditDetails part in a channel resource."
        );

        #endregion

    }

}