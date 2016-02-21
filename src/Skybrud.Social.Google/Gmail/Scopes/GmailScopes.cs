namespace Skybrud.Social.Google.Gmail.Scopes {

    public class GmailScopes {

        #region Constants (Gmail-related scopes)

        /// <summary>
        /// Grants acces to view and manage emails of the aunthenticated user.
        /// </summary>
        public static readonly GmailScope Default = new GmailScope(
            "https://mail.google.com/",
            "Default",
            "Grants acces to view and manage emails of the aunthenticated user."
        );

        /// <summary>
        /// Grant access to manage drafts and send emails on behalf of the authenticated user.
        /// </summary>
        public static readonly GmailScope Compose = new GmailScope(
            "https://www.googleapis.com/auth/gmail.compose",
            "Compose",
            "Grant access to manage drafts and send emails on behalf of the authenticated user."
        );

        /// <summary>
        /// Grants access to insert emails into the mailbox of the authenticated user.
        /// </summary>
        public static readonly GmailScope Insert = new GmailScope(
            "https://www.googleapis.com/auth/gmail.insert",
            "Insert",
            "Grants access to insert emails into the mailbox of the authenticated user."
        );

        /// <summary>
        /// Grants access to manage manage labels for the mailbox of the authenticated user.
        /// </summary>
        public static readonly GmailScope Labels = new GmailScope(
            "https://www.googleapis.com/auth/gmail.labels",
            "Labels",
            "Grants access to manage manage labels for the mailbox of the authenticated user."
        );

        /// <summary>
        /// Grants access to view and modify emails of the authenticated user. The scope doesn't grant access to delete emails.
        /// </summary>
        public static readonly GmailScope Modify = new GmailScope(
            "https://www.googleapis.com/auth/gmail.modify",
            "Modify",
            "Grants access to view and modify emails of the authenticated user. The scope doesn't grant access to delete emails."
        );

        /// <summary>
        /// Grants access to emails and settings of the authenticated user.
        /// </summary>
        public static readonly GmailScope Readonly = new GmailScope(
            "https://www.googleapis.com/auth/gmail.readonly",
            "Readonly",
            "Grants access to emails and settings of the authenticated user."
        );

        /// <summary>
        /// Grants access to send emails on behalf of the authenticated user.
        /// </summary>
        public static readonly GmailScope Send = new GmailScope(
            "https://www.googleapis.com/auth/gmail.send",
            "Send",
            "Grants access to send emails on behalf of the authenticated user."
        );

        #endregion

    }

}