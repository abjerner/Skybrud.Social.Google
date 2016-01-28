using Skybrud.Social.Google.Common.OAuth;

namespace Skybrud.Social.Google.Calendar.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw endpoint of the Google Calendar API implementation.
    /// </summary>
    public class CalendarRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent OAuth client.
        /// </summary>
        public GoogleOAuthClient Client { get; private set; }

        /// <summary>
        /// Gets a reference to the raw calendars endpoint.
        /// </summary>
        public CalendarCalendarsRawEndpoint Calendars { get; private set; }

        /// <summary>
        /// Gets a reference to the raw events endpoint.
        /// </summary>
        public CalendarEventsRawEndpoint Events { get; private set; }

        #endregion

        #region Constructors

        internal CalendarRawEndpoint(GoogleOAuthClient client) {
            Client = client;
            Calendars = new CalendarCalendarsRawEndpoint(client);
            Events = new CalendarEventsRawEndpoint(client);
        }

        #endregion

    }

}