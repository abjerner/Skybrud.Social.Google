namespace Skybrud.Social.Google.Plus.Scopes {
    
    /// <summary>
    /// Static class with properties representing the scopes of the Google+ API.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/+/web/api/rest/oauth</cref>
    /// </see>
    public static class PlusScopes {
        
        /// <summary>
        /// This is the recommended login scope providing access to social features. This scope implicitly includes the
        /// <code>profile</code> scope.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/+/web/api/rest/oauth#plus.login</cref>
        /// </see>
        public static PlusScope Login = new PlusScope(
            "https://www.googleapis.com/auth/plus.login",
            "Login",
            "Grants access to basic profile information about the authenticated user."
        );

        /// <summary>
        /// Grants read access to the email addresses of the authenticated user.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/+/web/api/rest/oauth#plus.profile.emails.read</cref>
        /// </see>
        public static PlusScope EmailsRead = new PlusScope(
            "https://www.googleapis.com/auth/plus.profile.emails.read",
            "Read emails",
            "Grants read access to the email addresses of the authenticated user."
        );


        /// <summary>
        /// Grants access to profile information about the authenticated user.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/+/web/api/rest/oauth#plus.me</cref>
        /// </see>
        public static PlusScope Me = new PlusScope(
            "https://www.googleapis.com/auth/plus.me",
            "Profile information",
            "Grants access to profile information about the authenticated user."
        );

    }

}