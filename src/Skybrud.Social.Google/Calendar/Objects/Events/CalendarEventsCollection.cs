using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Calendar.Objects.Events {
    
    public class CalendarEventsCollection : GoogleApiResource {

        public string Summary { get; private set; }
        // updated
        // timezone
        // accessRole
        // defaultReminders
        // nextSyncToken
        public CalendarEvent[] Items { get; private set; }

        private CalendarEventsCollection(JObject obj) : base(obj) {
            Summary = obj.GetString("summary");
            Items = obj.GetArray("items", CalendarEvent.Parse);
        }

        public static CalendarEventsCollection Parse(JObject obj) {
            return obj == null ? null : new CalendarEventsCollection(obj);
        }

    }

}