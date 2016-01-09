namespace Skybrud.Social.Google.Calendar.Fields {
    
    /// <summary>
    /// Class representing a field in the Google Calendar API.
    /// </summary>
    public class CalendarField {

        #region Properties

        /// <summary>
        /// Gets the name of the field.
        /// </summary>
        public string Name { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new field with the specified <code>name</code>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        public CalendarField(string name) {
            Name = name;
        }

        #endregion

        #region Operators
       
        /// <summary>
        /// Initializes a new field based on the specified <code>name</code>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        public static implicit operator CalendarField(string name) {
            return new CalendarField(name);
        }

        /// <summary>
        /// Adding two instances of <code>CalendarField</code> will result in a
        /// <code>CalendarFieldsCollection</code> containing both fields.
        /// </summary>
        /// <param name="left">The left field.</param>
        /// <param name="right">The right field.</param>
        public static CalendarFieldsCollection operator +(CalendarField left, CalendarField right) {
            return new CalendarFieldsCollection(left, right);
        }

        #endregion

    }

}