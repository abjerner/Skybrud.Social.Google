using System;
using Skybrud.Social.Google.Calendar.Endpoints.Raw;
using Skybrud.Social.Google.Calendar.Options.Events;
using Skybrud.Social.Google.Calendar.Responses.Events;

namespace Skybrud.Social.Google.Calendar.Endpoints {
    
    public class CalendarEndpoint {

        #region Properties

        public GoogleService Service { get; private set; }

        public CalendarRawEndpoint Raw { get; private set; }

        #endregion

        #region Constructors

        public CalendarEndpoint(GoogleService service) {
            Service = service;
            Raw = new CalendarRawEndpoint(Service.Client);
        }

        #endregion

        #region Constructors

        public CalendarGetEventsResponse GetEvents() {
            return CalendarGetEventsResponse.ParseResponse(Raw.GetEvents());
        }

        public CalendarGetEventsResponse GetEvents(string calendarId) {
            return CalendarGetEventsResponse.ParseResponse(Raw.GetEvents(calendarId));
        }

        public CalendarGetEventsResponse GetEvents(CalendarGetEventsOptions options) {
            return CalendarGetEventsResponse.ParseResponse(Raw.GetEvents(options));
        }

        #endregion

    }

}