using System;
using System.Collections.Generic;
using Skybrud.Social.Google.Analytics.Interfaces;

namespace Skybrud.Social.Google.Analytics.Dimensions {

    /// <summary>
    /// Class representing a dimension in the Google Analytics API.
    /// </summary>
    public class AnalyticsDimension : IAnalyticsField {

        #region Private fields

        private static readonly Dictionary<string, AnalyticsDimension> Dimensions = new Dictionary<string, AnalyticsDimension>();

        #endregion

        #region Properties

        /// <summary>
        /// Gets a dictionary containing all dimensions. 
        /// </summary>
        public static Dictionary<string, AnalyticsDimension> All {
            get {
                AnalyticsDimensions.GetAll();
                AnalyticsRealtimeDimensions.GetAll();
                return Dimensions;
            }
        }

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

        #region Static methods

        /// <summary>
        /// Registers a new dimension with the specified <code>name</code> and returns the created dimension. If a
        /// dimension with the specified name already exists, the existing dimension will be returned instead.
        /// </summary>
        /// <param name="name">The name of the dimension.</param>
        public static AnalyticsDimension Register(string name) {
            return Register(name, null, false);
        }

        /// <summary>
        /// Registers a new dimension with the specified <code>name</code> and returns the created dimension. If a
        /// dimension with the specified name already exists, the existing dimension will be returned instead.
        /// </summary>
        /// <param name="name">The name of the dimension.</param>
        /// <param name="groupName">The group name of the dimension.</param>
        public static AnalyticsDimension Register(string name, string groupName) {
            return Register(name, groupName, false);
        }

        /// <summary>
        /// Registers a new dimension with the specified <code>name</code> and returns the created dimension. If a
        /// dimension with the specified name already exists, the existing dimension will be returned instead.
        /// </summary>
        /// <param name="name">The name of the dimension.</param>
        /// <param name="groupName">The group name of the dimension.</param>
        /// <param name="obsolete">Whether the dimension is obsolete.</param>
        public static AnalyticsDimension Register(string name, string groupName, bool obsolete) {
            AnalyticsDimension dimension;
            if (All.TryGetValue(name, out dimension)) return dimension;
            dimension = new AnalyticsDimension(name, groupName, obsolete);
            All.Add(dimension.Name, dimension);
            return dimension;
        }

        /// <summary>
        /// Gets a reference to the dimension with the specified <code>name</code>, or <code>null</code> if not found.
        /// </summary>
        /// <param name="name">The name of the dimension.</param>
        /// <returns>Returns an instance of <code>AnalyticsDimension</code> if the dimension is found, otherwise <code>null</code>.</returns>
        public static AnalyticsDimension Get(string name) {
            AnalyticsDimension dimension;
            return All.TryGetValue(name, out dimension) ? dimension : null;
        }

        /// <summary>
        /// Attempts to find dimension with the specified <code>name</code>.
        /// </summary>
        /// <param name="name">The name of the dimension.</param>
        /// <param name="dimension">The dimension.</param>
        /// <returns>Returns <code>true</code> if the dimension was found, otherwise <code>false</code>.</returns>
        public static bool TryGet(string name, out AnalyticsDimension dimension) {
            return All.TryGetValue(name, out dimension);
        }

        /// <summary>
        /// Gets whether a dimension with the specified <code>name</code> already exists.
        /// </summary>
        /// <param name="name">The name of the dimension.</param>
        /// <returns>Returns <code>true</code> if the dimension exists, otherwise <code>false</code>.</returns>
        public static bool Exists(string name) {
            return All.ContainsKey(name);
        }

        #endregion

        #region Operator overloading

        /// <summary>
        /// Initializes a new dimension from the specified <code>name</code>.
        /// </summary>
        /// <param name="name">The name of the dimension.</param>
        /// <returns>Returns an instance of <see cref="AnalyticsDimension"/> representing the dimension.</returns>
        public static implicit operator AnalyticsDimension(string name) {
            if (String.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("name");
            return Register(name);
        }

        /// <summary>
        /// Gets a new collection containg the <code>left</code> and <code>right</code> dimensions.
        /// </summary>
        /// <param name="left">The dimension to the left of the operator.</param>
        /// <param name="right">The dimension to the right of the operator.</param>
        /// <returns>Returns an instance of <see cref="AnalyticsDimension"/>.</returns>
        public static AnalyticsDimensionCollection operator +(AnalyticsDimension left, AnalyticsDimension right) {
            return new AnalyticsDimensionCollection(left, right);
        }

        #endregion

    }

}