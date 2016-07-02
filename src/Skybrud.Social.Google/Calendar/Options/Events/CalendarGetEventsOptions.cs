using System;
using Skybrud.Social.Google.Calendar.Constants;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Google.Calendar.Options.Events {

    public class CalendarGetEventsOptions : IHttpGetOptions {

        #region Properties

        public string CalendarId { get; set; }

        public DateTime? TimeMax { get; set; }

        public DateTime? TimeMin { get; set; }

        #endregion

        #region Constructors

        public CalendarGetEventsOptions() : this("primary") { }

        public CalendarGetEventsOptions(string calendarId) {
            CalendarId = calendarId;
        }

        #endregion

        public IHttpQueryString GetQueryString() {

            SocialHttpQueryString query = new SocialHttpQueryString();

            if (TimeMax != null) {
                query.Add("timeMax", TimeMax.Value.ToUniversalTime().ToString(CalendarConstants.DateFormat));
            }

            if (TimeMin != null) {
                query.Add("timeMin", TimeMin.Value.ToUniversalTime().ToString(CalendarConstants.DateFormat));
            }

            return query;

        }

    }

}