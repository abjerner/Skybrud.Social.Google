using System;
using Skybrud.Social.Google.Analytics.Interfaces;

namespace Skybrud.Social.Google.Analytics.Dimensions {

    // TODO: Implement logic for comparing to instances of "AnalyticsDimension"

    /// <summary>
    /// Class representing a dimension in the Google Analytics API.
    /// </summary>
    public class AnalyticsDimension : IAnalyticsField {

        #region Properties

        /// <summary>
        /// Gets the name of the dimension.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the name of the group of the dimension.
        /// </summary>
        public string GroupName { get; private set; }

        /// <summary>
        /// Gets whether the dimension is obsolete/deprecated.
        /// </summary>
        public bool IsObsolete { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new dimension from the specified <code>name</code>.
        /// </summary>
        /// <param name="name">The name of tge dimension.</param>
        public AnalyticsDimension(string name) {
            Name = name;
        }

        /// <summary>
        /// Initializes a new dimension from the specified <code>name</code> and <code>groupName</code>.
        /// </summary>
        /// <param name="name">The name of the dimension.</param>
        /// <param name="groupName">The name of group of the dimension.</param>
        public AnalyticsDimension(string name, string groupName) {
            Name = name;
            GroupName = groupName;
        }

        /// <summary>
        /// Initializes a new dimension from the specified <code>name</code> and <code>groupName</code>.
        /// </summary>
        /// <param name="name">The name of the dimension.</param>
        /// <param name="groupName">The name of group of the dimension.</param>
        /// <param name="obsolete">Indicates whether the dimension is obsolete.</param>
        public AnalyticsDimension(string name, string groupName, bool obsolete) {
            Name = name;
            GroupName = groupName;
            IsObsolete = obsolete;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets the name of the dimension (eg. <code>ga:country</code>).
        /// </summary>
        public override string ToString() {
            return Name;
        }

        #endregion

        #region Operator overloading

        /// <summary>
        /// Initializes a new dimension from the specified <code>name</code>.
        /// </summary>
        /// <param name="name">The name of the dimension.</param>
        /// <returns>Returns an instance of <code>AnalyticsDimension</code> representing the dimension.</returns>
        public static implicit operator AnalyticsDimension(string name) {
            if (String.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("name");
            return new AnalyticsDimension(name);
        }

        /// <summary>
        /// Gets a new collection containg the <code>left</code> and <code>right</code> dimensions.
        /// </summary>
        /// <param name="left">The dimension to the left of the operator.</param>
        /// <param name="right">The dimension to the right of the operator.</param>
        /// <returns>Returns an instance of <code>AnalyticsDimensionCollection</code>.</returns>
        public static AnalyticsDimensionCollection operator +(AnalyticsDimension left, AnalyticsDimension right) {
            return new AnalyticsDimensionCollection(left, right);
        }

        #endregion

    }

}