using Skybrud.Social.Google.Calendar.Endpoints.Raw;
using Skybrud.Social.Google.Calendar.Options.Events;
using Skybrud.Social.Google.Calendar.Responses.Events;

namespace Skybrud.Social.Google.Calendar.Endpoints {

    /// <summary>
    /// Class representing the events endpoint.
    /// </summary>
    public class CalendarEventsEndpoint {

        #region Properties

        /// <summary>
        /// Gets the parent endpoint of this endpoint.
        /// </summary>
        public CalendarEndpoint Calendar { get; private set; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public CalendarEventsRawEndpoint Raw {
            get { return Calendar.Service.Client.Calendar.Events; }
        }

        #endregion

        #region Constructors

        internal CalendarEventsEndpoint(CalendarEndpoint calendar) {
            Calendar = calendar;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of events of the primary calendar of the authenticated user.
        /// </summary>
        /// <returns>Returns an instance of <code>CalendarGetEventsResponse</code> matching the response.</returns>
        public CalendarGetEventsResponse GetEvents() {
            return CalendarGetEventsResponse.ParseResponse(Raw.GetEvents());
        }

        /// <summary>
        /// Gets a list of events of the calendar with the specified <code>calendarId</code>.
        /// </summary>
        /// <param name="calendarId">The ID of the calendar.</param>
        /// <returns>Returns an instance of <code>CalendarGetEventsResponse</code> matching the response.</returns>
        public CalendarGetEventsResponse GetEvents(string calendarId) {
            return CalendarGetEventsResponse.ParseResponse(Raw.GetEvents(calendarId));
        }

        /// <summary>
        /// Gets a list of events of the calendar matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <code>CalendarGetEventsResponse</code> matching the response.</returns>
        public CalendarGetEventsResponse GetEvents(CalendarGetEventsOptions options) {
            return CalendarGetEventsResponse.ParseResponse(Raw.GetEvents(options));
        }

        #endregion

    }

}