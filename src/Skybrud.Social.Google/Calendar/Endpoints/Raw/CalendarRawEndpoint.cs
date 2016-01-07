using System;
using Skybrud.Social.Exceptions;
using Skybrud.Social.Google.Calendar.Options.Events;
using Skybrud.Social.Google.OAuth;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Calendar.Endpoints.Raw {

    public class CalendarRawEndpoint {

        #region Properties

        public GoogleOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal CalendarRawEndpoint(GoogleOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        public SocialHttpResponse GetEvents() {
            return GetEvents(new CalendarGetEventsOptions());
        }

        public SocialHttpResponse GetEvents(string calendarId) {
            return GetEvents(new CalendarGetEventsOptions(calendarId));
        }

        public SocialHttpResponse GetEvents(CalendarGetEventsOptions options) {

            // Some validation
            if (options == null) throw new ArgumentNullException("options", "wtf?");
            if (String.IsNullOrWhiteSpace(options.CalendarId)) throw new PropertyNotSetException("options.CalendarId");

            // Make the call to the API
            return Client.DoAuthenticatedGetRequest("https://www.googleapis.com/calendar/v3/calendars/" + options.CalendarId + "/events", options);
        
        }

        #endregion

    }

}