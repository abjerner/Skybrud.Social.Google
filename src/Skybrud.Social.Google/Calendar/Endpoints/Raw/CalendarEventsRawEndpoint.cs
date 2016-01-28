using System;
using Skybrud.Social.Exceptions;
using Skybrud.Social.Google.Calendar.Options.Events;
using Skybrud.Social.Google.Common.OAuth;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Calendar.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw events endpoint.
    /// </summary>
    public class CalendarEventsRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Google OAuth client.
        /// </summary>
        public GoogleOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal CalendarEventsRawEndpoint(GoogleOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of events of the primary calendar of the authenticated user.
        /// </summary>
        /// <returns>Returns an instance of <code>SocialHttpResponse</code> matching the raw response.</returns>
        public SocialHttpResponse GetEvents() {
            return GetEvents(new CalendarGetEventsOptions());
        }

        /// <summary>
        /// Gets a list of events of the calendar with the specified <code>calendarId</code>.
        /// </summary>
        /// <param name="calendarId">The ID of the calendar.</param>
        /// <returns>Returns an instance of <code>SocialHttpResponse</code> matching the raw response.</returns>
        public SocialHttpResponse GetEvents(string calendarId) {
            return GetEvents(new CalendarGetEventsOptions(calendarId));
        }

        /// <summary>
        /// Gets a list of events of the calendar matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <code>SocialHttpResponse</code> matching the raw response.</returns>
        public SocialHttpResponse GetEvents(CalendarGetEventsOptions options) {

            // Some validation
            if (options == null) throw new ArgumentNullException("options", "wtf?");
            if (String.IsNullOrWhiteSpace(options.CalendarId)) throw new PropertyNotSetException("options.CalendarId");

            // Make the call to the API
            return Client.DoHttpGetRequest("https://www.googleapis.com/calendar/v3/calendars/" + options.CalendarId + "/events", options);

        }

        #endregion

    }

}