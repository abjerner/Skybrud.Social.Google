using System;
using Skybrud.Social.Exceptions;
using Skybrud.Social.Google.Calendar.Options.Calendars;
using Skybrud.Social.Google.OAuth;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Calendar.Endpoints.Raw {
    
    public class CalendarCalendarsRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Google OAuth client.
        /// </summary>
        public GoogleOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal CalendarCalendarsRawEndpoint(GoogleOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets information about the calendar with the specified <code>calendarId</code>.
        /// </summary>
        /// <param name="calendarId">The ID of the calendar.</param>
        /// <returns>Returns an instance of <code>SocialHttpResponse</code> matching the raw response.</returns>
        public SocialHttpResponse GetCalendar(string calendarId) {
            return GetCalendar(new CalendarGetCalendarOptions(calendarId));
        }

        /// <summary>
        /// Gets information about the calendar matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <code>SocialHttpResponse</code> matching the raw response.</returns>
        public SocialHttpResponse GetCalendar(CalendarGetCalendarOptions options) {

            // A bit of validation
            if (options == null) throw new ArgumentNullException("options");
            if (String.IsNullOrWhiteSpace(options.CalendarId)) throw new PropertyNotSetException("options.CalendarId");

            // Make the call to the API
            return Client.DoAuthenticatedGetRequest("https://www.googleapis.com/calendar/v3/calendars/" + options.CalendarId, options);
        
        }

        #endregion

    }

}