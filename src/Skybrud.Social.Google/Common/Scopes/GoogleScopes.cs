namespace Skybrud.Social.Google.Common.Scopes {
    
    /// <summary>
    /// Static class containing references to global scopes of the Google APIs.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/+/web/api/rest/oauth</cref>
    /// </see>
    public static class GoogleScopes {

        #region Constants (global Google scopes)

        /// <summary>
        /// This scope informs the authorization server that the client is making an OpenID Connect request, and
        /// requests access to the authenticated user's ID. You must include this scope with the other OpenID Connect
        /// scopes.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/+/web/api/rest/oauth#openid</cref>
        /// </see>
        public static readonly GoogleScope OpenId = new GoogleScope(
            "openid",
            "OpenII",
            "This scope informs the authorization server that the client is making an OpenID Connect request, and requests access to the authenticated user's ID."
        );

        /// <summary>
        /// This scope grants access to the email of the authenticated user. The scope will also grant access to the
        /// domain, if the user belongs to a Google Apps domain.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/+/web/api/rest/oauth#email</cref>
        /// </see>
        public static readonly GoogleScope Email = new GoogleScope(
            "email",
            "Email",
            "This scope grants access to the email of the authenticated user. The scope will also grant access to the domain, if the user belongs to a Google Apps domain."
         );

        /// <summary>
        /// This scope grants access to basic profile information of the authenticated user.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/+/web/api/rest/oauth#profile</cref>
        /// </see>
        public static readonly GoogleScope Profile = new GoogleScope(
            "profile",
            "Profile",
            "This scope grants access to basic profile information of the authenticated user."
        );

        #endregion

    }

}