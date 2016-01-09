using Skybrud.Social.Google.OAuth;

namespace Skybrud.Social.Google.Calendar.Endpoints.Raw {

    public class CalendarRawEndpoint {

        #region Properties

        public GoogleOAuthClient Client { get; private set; }

        public CalendarCalendarsRawEndpoint Calendars { get; private set; }

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