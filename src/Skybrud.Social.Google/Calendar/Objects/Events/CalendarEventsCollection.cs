using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions;

namespace Skybrud.Social.Google.Calendar.Objects.Events {
    
    /// <summary>
    /// Class representing a collection of events.
    /// </summary>
    public class CalendarEventsCollection : GoogleApiResource {

        #region Properties

        /// <summary>
        /// Gets the summary of the event.
        /// </summary>
        public string Summary { get; private set; }

        // updated
        // timezone
        // accessRole
        // defaultReminders
        // nextSyncToken
        
        /// <summary>
        /// Gets the items (events) of the collection.
        /// </summary>
        public CalendarEvent[] Items { get; private set; }

        #endregion

        #region Constructors

        private CalendarEventsCollection(JObject obj) : base(obj) {
            Summary = obj.GetString("summary");
            Items = obj.GetArray("items", CalendarEvent.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <code>CalendarEventsCollection</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to be parsed.</param>
        /// <returns>Returns an instance of <code>CalendarEventsCollection</code>.</returns>
        public static CalendarEventsCollection Parse(JObject obj) {
            return obj == null ? null : new CalendarEventsCollection(obj);
        }

        #endregion

    }

}