using Skybrud.Social.Google.Common.Scopes;

namespace Skybrud.Social.Google.YouTube.Scopes {
    
    /// <summary>
    /// Class representing a scope in the YouTube API.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/guides/auth/server-side-web-apps#Obtaining_Access_Tokens</cref>
    /// </see>
    public class YouTubeScope : GoogleScope {

        #region Constructor
        
        /// <summary>
        /// Initializes a new scope with the specified <paramref name="name"/>, <paramref name="title"/> and
        /// <paramref name="description"/>.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        /// <param name="title">The title of the scope.</param>
        /// <param name="description">The description of the scope.</param>
        public YouTubeScope(string name, string title, string description) : base(name, title, description) { }

        #endregion

    }

}