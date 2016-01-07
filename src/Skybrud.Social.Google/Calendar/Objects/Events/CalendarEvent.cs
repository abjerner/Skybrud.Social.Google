using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Calendar.Objects.Common;
using Skybrud.Social.Google.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Calendar.Objects.Events {
    
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

            JValue created = obj.GetValue("created") as JValue;
            JValue updated = obj.GetValue("updated") as JValue;

            if (created != null && created.Type == JTokenType.Date) {
                Created = (DateTime)created.Value;
            }

            if (updated != null && updated.Type == JTokenType.Date) {
                Updated = (DateTime)updated.Value;
            }

            Summary = obj.GetString("summary");


            Start = obj.GetObject("start", x => CalendarDate.Parse("start", x));
            End = obj.GetObject("end", x => CalendarDate.Parse("end", x));

        }

        public static CalendarEvent Parse(JObject obj) {
            return obj == null ? null : new CalendarEvent(obj);
        }

    }

}