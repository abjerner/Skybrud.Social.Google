namespace Skybrud.Social.Google.OAuth.Enums {

    /// <summary>
    /// Indicates whether the user should be re-prompted for consent. The default is <code>Auto</code>, so a given user
    /// should only see the consent page for a given set of scopes the first time through the sequence. If the value is
    /// <code>force</code>, then the user sees a consent page even if they previously gave consent to your application
    /// for a given set of scopes.
    /// </summary>
    public enum GoogleApprovalPrompt {
    
        /// <summary>
        /// Indicates that the authenticating user only should see the consent page if one or more scopes haven't
        /// already been granted.
        /// </summary>
        Auto,

        /// <summary>
        /// Indicates that the authenticatig user always should see the content page.
        /// </summary>
        Force
    
    }

}