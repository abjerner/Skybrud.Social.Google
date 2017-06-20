using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Calendar.Models.Common;
using Skybrud.Social.Google.Common.Models;

namespace Skybrud.Social.Google.Calendar.Models.Events {

    /// <summary>
    /// Class representing an event in the Google Calendar API.
    /// </summary>
    public class CalendarEvent : GoogleApiResource {

        public string Id { get; private set; }
        public string Status { get; private set; }
        public string HtmlLink { get; private set; }
        public DateTime Created { get; private set; }
        public DateTime Updated { get; private set; }
        public string Summary { get; private set; }

        public CalendarDate Start { get; private set; }

        public CalendarDate End { get; private set; }

        protected CalendarEvent(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Status = obj.GetString("status");
            HtmlLink = obj.GetString("htmlLink");
            Created = obj.GetDateTime("created");
            Updated = obj.GetDateTime("updated");
            Summary = obj.GetString("summary");
            Start = obj.GetObject("start", x => CalendarDate.Parse("start", x));
            End = obj.GetObject("end", x => CalendarDate.Parse("end", x));
        }
        
        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <code>CalendarEvent</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to be parsed.</param>
        /// <returns>Returns an instance of <code>CalendarEvent</code>.</returns>
        public static CalendarEvent Parse(JObject obj) {
            return obj == null ? null : new CalendarEvent(obj);
        }

        #endregion

    }

}