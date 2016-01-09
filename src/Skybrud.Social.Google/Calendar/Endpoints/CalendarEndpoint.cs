using Skybrud.Social.Google.Calendar.Endpoints.Raw;
using Skybrud.Social.Google.Calendar.Options.Events;
using Skybrud.Social.Google.Calendar.Responses.Events;

namespace Skybrud.Social.Google.Calendar.Endpoints {
    
    public class CalendarEndpoint {

        #region Properties

        public GoogleService Service { get; private set; }

        public CalendarRawEndpoint Raw { get; private set; }

        public CalendarCalendarsEndpoint Calendars { get; private set; }

        public CalendarEventsEndpoint Events { get; private set; }

        #endregion

        #region Constructors

        public CalendarEndpoint(GoogleService service) {
            Service = service;
            Raw = new CalendarRawEndpoint(Service.Client);
            Calendars = new CalendarCalendarsEndpoint(this);
            Events = new CalendarEventsEndpoint(this);
        }

        #endregion

    }

}