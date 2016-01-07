using Skybrud.Social.Google.Calendar.Objects.Events;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Calendar.Responses.Events {
    
    public class CalendarGetEventsResponse : CalendarResponse<CalendarEventsCollection> {

        #region Constructors

        protected CalendarGetEventsResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, CalendarEventsCollection.Parse);
        
        }

        #endregion

        #region Static methods

        public static CalendarGetEventsResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new CalendarGetEventsResponse(response);
        }

        #endregion

    }

}