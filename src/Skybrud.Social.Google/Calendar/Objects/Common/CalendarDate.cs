using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Calendar.Objects.Common {
    
    public class CalendarDate : GoogleApiObject {

        public DateTime DateTime { get; private set; }
        
        public string TimeZone { get; private set; }

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

        public static CalendarDate Parse(string propertyName, JObject obj) {
            return obj == null ? null : new CalendarDate(propertyName, obj);
        }

    }

}