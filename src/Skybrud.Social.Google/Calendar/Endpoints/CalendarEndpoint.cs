using Skybrud.Social.Google.Calendar.Endpoints.Raw;

namespace Skybrud.Social.Google.Calendar.Endpoints {
    
    /// <summary>
    /// Class representing the main endpoint of the Google Calendar API implementation.
    /// </summary>
    public class CalendarEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference the parent service of this endpoint.
        /// </summary>
        public GoogleService Service { get; private set; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public CalendarRawEndpoint Raw { get; private set; }

        /// <summary>
        /// Gets a reference to the calendars endpoint.
        /// </summary>
        public CalendarCalendarsEndpoint Calendars { get; private set; }

        /// <summary>
        /// Gets a reference to the events endpoint.
        /// </summary>
        public CalendarEventsEndpoint Events { get; private set; }

        #endregion

        #region Constructors

        internal CalendarEndpoint(GoogleService service) {
            Service = service;
            Raw = new CalendarRawEndpoint(Service.Client);
            Calendars = new CalendarCalendarsEndpoint(this);
            Events = new CalendarEventsEndpoint(this);
        }

        #endregion

    }

}