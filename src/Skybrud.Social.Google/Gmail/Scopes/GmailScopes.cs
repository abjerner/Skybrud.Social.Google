namespace Skybrud.Social.Google.Gmail.Scopes {

    public class GmailScopes {

        #region Constants (Gmail-related scopes)

        /// <summary>
        /// Grants access to view and manage your mail.
        /// </summary>
        public static readonly GmailScope Default = new GmailScope("https://mail.google.com/", "View and manage your mail");

        public static readonly GmailScope Compose = new GmailScope("https://www.googleapis.com/auth/gmail.compose", "Manage drafts and send emails");

        public static readonly GmailScope Insert = new GmailScope("https://www.googleapis.com/auth/gmail.insert", "Insert mail into your mailbox");

        public static readonly GmailScope Labels = new GmailScope("https://www.googleapis.com/auth/gmail.labels", "Manage mailbox labels");

        public static readonly GmailScope Modify = new GmailScope("https://www.googleapis.com/auth/gmail.modify", "View and modify but not delete your email");

        public static readonly GmailScope Readonly = new GmailScope("https://www.googleapis.com/auth/gmail.readonly", "View your emails messages and settings");

        public static readonly GmailScope Send = new GmailScope("https://www.googleapis.com/auth/gmail.send", "Send email on your behalf");

        #endregion

    }

}