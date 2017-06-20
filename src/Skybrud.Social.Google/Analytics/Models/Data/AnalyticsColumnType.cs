namespace Skybrud.Social.Google.Analytics.Models.Data {
    
    /// <summary>
    /// Enum class representing the type of a column retrieved through the Data endpoint.
    /// </summary>
    public enum AnalyticsColumnType {

        /// <summary>
        /// Indicates that the column represents the values of a dimension.
        /// </summary>
        Dimension,

        /// <summary>
        /// Indicates that the column represents the values of a metric.
        /// </summary>
        Metric

    }

}