namespace Skybrud.Social.Google.Analytics.Models.Data {
    
    /// <summary>
    /// Enum class representing the data type of a column retrieved through the Data endpoint.
    /// </summary>
    public enum AnalyticsDataType {

        /// <summary>
        /// Indicates that the value is a string.
        /// </summary>
        String,

        /// <summary>
        /// Indicates that the value is an integer.
        /// </summary>
        Integer,

        /// <summary>
        /// Indicates that the value is a floating point number.
        /// </summary>
        Float,

        /// <summary>
        /// Indicates that the value represents a currency.
        /// </summary>
        Currency,

        /// <summary>
        /// Indicates that the value is specified in percent.
        /// </summary>
        Percent,

        /// <summary>
        /// Indicates that the value represents a time.
        /// </summary>
        Time

    }

}