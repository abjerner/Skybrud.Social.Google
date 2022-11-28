using Skybrud.Social.Google.Attributes;

namespace Skybrud.Social.Google.Scopes {

    /// <summary>
    /// Static class containing references to global scopes of the Google APIs.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/+/web/api/rest/oauth</cref>
    /// </see>
    [GoogleScopes("Basic", -1)]
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
        public static readonly GoogleScope OpenId = new(
            "openid",
            "OpenID",
            "This scope informs the authorization server that the client is making an OpenID Connect request, and requests access to the authenticated user's ID."
        );

        /// <summary>
        /// This scope grants access to the email of the authenticated user. The scope will also grant access to the
        /// domain, if the user belongs to a Google Apps domain.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/+/web/api/rest/oauth#email</cref>
        /// </see>
        public static readonly GoogleScope Email = new(
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
        public static readonly GoogleScope Profile = new(
            "profile",
            "Profile",
            "This scope grants access to basic profile information of the authenticated user."
        );

        /// <summary>
        /// Gets an array of all basic scopes.
        /// </summary>
        public static readonly GoogleScope[] All = { OpenId, Email, Profile };

        #endregion

    }

}