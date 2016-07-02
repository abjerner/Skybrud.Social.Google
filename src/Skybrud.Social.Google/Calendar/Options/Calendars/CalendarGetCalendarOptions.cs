﻿using Skybrud.Social.Google.Calendar.Fields;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Google.Calendar.Options.Calendars {
    
    /// <summary>
    /// Class representing the options of a call to get information about a single calendar.
    /// </summary>
    public class CalendarGetCalendarOptions : IHttpGetOptions {

        #region Properties

        public string CalendarId { get; set; }

        public CalendarFieldsCollection Fields { get; set; }

        #endregion

        #region Constructors

        public CalendarGetCalendarOptions() : this("primary") { }

        public CalendarGetCalendarOptions(string calendarId) {
            CalendarId = calendarId;
        }

        #endregion

        #region Member methods

        public IHttpQueryString GetQueryString() {

            SocialHttpQueryString query = new SocialHttpQueryString();

            if (Fields != null && Fields.Length > 0) {
                query.Add("fields", Fields);
            }

            return query;

        }
        
        #endregion

    }

}