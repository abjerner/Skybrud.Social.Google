using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Common.Models;

namespace Skybrud.Social.Google.Calendar.Models.Common {
    
    /// <summary>
    /// Class representing a date returned by the Google Calendae API.
    /// </summary>
    public class CalendarDate : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the date value parsed from either the <code>dateTime</code> property or the <code>date</code> property.
        /// </summary>
        public DateTime DateTime { get; private set; }
        
        /// <summary>
        /// Gets the time zone of the date.
        /// </summary>
        public string TimeZone { get; private set; }

        #endregion

        #region Constructors

        private CalendarDate(string propertyName, JObject obj) : base(obj) {

            if (obj.HasValue("dateTime")) {
                DateTime = obj.GetDateTime("dateTime");
            } else if (obj.GetValue("date") != null) {
                DateTime = obj.GetString("date", DateTime.Parse);
                if (propertyName == "end") {
                    DateTime = new DateTime(DateTime.Year, DateTime.Month, DateTime.Day, 23, 59, 59);
                }
            }

            TimeZone = obj.GetString("timeZone");

        }

        #endregion

        #region Static methods
        
        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <code>CalendarDate</code>.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        /// <param name="obj">The instance of <code>JObject</code> to be parsed.</param>
        /// <returns>Returns an instance of <code>CalendarDate</code>.</returns>
        public static CalendarDate Parse(string propertyName, JObject obj) {
            return obj == null ? null : new CalendarDate(propertyName, obj);
        }

        #endregion

    }

}