using Skybrud.Social.Google.Calendar.Endpoints.Raw;

namespace Skybrud.Social.Google.Calendar.Endpoints {

    /// <summary>
    /// Class representing the calendars endpoint.
    /// </summary>
    public class CalendarCalendarsEndpoint {

        #region Properties

        /// <summary>
        /// Gets the parent endpoint of this endpoint.
        /// </summary>
        public CalendarEndpoint Calendar { get; private set; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public CalendarCalendarsRawEndpoint Raw {
            get { return Calendar.Service.Client.Calendar.Calendars; }
        }

        #endregion

        #region Constructors

        internal CalendarCalendarsEndpoint(CalendarEndpoint calendar) {
            Calendar = calendar;
        }

        #endregion

    }

}