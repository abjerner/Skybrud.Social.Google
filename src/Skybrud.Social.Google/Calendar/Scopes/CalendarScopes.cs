namespace Skybrud.Social.Google.Calendar.Scopes {
    
    /// <summary>
    /// Static class containing references to known scopes of the Calendar API.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/google-apps/calendar/auth</cref>
    /// </see>
    public static class CalendarScopes {
        
        #region Constants (Analytics-related scopes)

        /// <summary>
        /// Grants read-only access to the Calendar API.
        /// </summary>
        public static readonly CalendarScope Readonly = new CalendarScope(
            "https://www.googleapis.com/auth/calendar.readonly",
            "Readonly",
            "Grants read-only access to the Analytics API."
        );

        /// <summary>
        /// Grants read and write access to the Calendar API.
        /// </summary>
        public static readonly CalendarScope Write = new CalendarScope(
            "https://www.googleapis.com/auth/calendar",
            "Write",
            "Grants read and write access to the Analytics API."
        );

        #endregion

    }

}