namespace Skybrud.Social.Google.Common.Enums {

    /// <summary>
    /// Indicates whether your application needs to access a Google API when the user is not
    /// present at the browser. This parameter defaults to online. If your application needs to
    /// refresh access tokens when the user is not present at the browser, then use offline. This
    /// will result in your application obtaining a refresh token the first time your application
    /// exchanges an authorization code for a user.
    /// </summary>
    public enum GoogleAccessType {
    
        /// <summary>
        /// Indicates that your app should only be granted online access. This means that you will be granted an access
        /// token that will have a lifetime of an hour.
        /// </summary>
        Online,

        /// <summary>
        /// Indicates that your app should be granted offline access. Thus means that you will be granted an access
        /// token with a lifetime of an hour as well as a refresh token that can be used to obtain new access tokens
        /// for the authenticated user with the user having to do anything.
        /// </summary>
        Offline
    
    }

}