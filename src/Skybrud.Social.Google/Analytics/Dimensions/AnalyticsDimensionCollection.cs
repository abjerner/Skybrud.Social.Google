using System;
using System.Collections.Generic;
using System.Linq;

namespace Skybrud.Social.Google.Analytics.Dimensions {
    
    /// <summary>
    /// Class representing a collection of dimensions.
    /// </summary>
    public class AnalyticsDimensionCollection {

        #region Private fields

        private readonly List<AnalyticsDimension> _list = new List<AnalyticsDimension>();

        #endregion

        #region Properties

        /// <summary>
        /// Gets the amount of dimensions currently in the collection.
        /// </summary>
        public int Count {
            get { return _list.Count; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes an empty collection.
        /// </summary>
        public AnalyticsDimensionCollection() { }

        /// <summary>
        /// Initializes a collection containing the specified dimensions.
        /// </summary>
        /// <param name="dimensions">The dimensions to add.</param>
        public AnalyticsDimensionCollection(params AnalyticsDimension[] dimensions) {
            _list.AddRange(dimensions);
        }

        /// <summary>
        /// Initializes a collection containing the specified dimensions.
        /// </summary>
        /// <param name="dimensions">The dimensions to add.</param>
        public AnalyticsDimensionCollection(IEnumerable<AnalyticsDimension> dimensions) {
            _list.AddRange(dimensions);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds the specified dimension to the collection.
        /// </summary>
        /// <param name="dimension">The dimension to add.</param>
        public void Add(AnalyticsDimension dimension) {
            _list.Add(dimension);
        }

        /// <summary>
        /// Adds the specified range of dimensions to the collection.
        /// </summary>
        /// <param name="dimensions">The dimensions to add.</param>
        public void AddRange(IEnumerable<AnalyticsDimension> dimensions) {
            _list.AddRange(dimensions);
        }

        /// <summary>
        /// Gets an array of the dimensions currently in the collection.
        /// </summary>
        public AnalyticsDimension[] ToArray() {
            return _list.ToArray();
        }

        /// <summary>
        /// Gets a string array of the dimensions currently in the collection.
        /// </summary>
        public string[] ToStringArray() {
            return (from dimension in _list select dimension.Name).ToArray();
        }

        /// <summary>
        /// Gets a string representation if the dimensions currently in the collection.
        /// </summary>
        public override string ToString() {
            return String.Join(",", from dimension in _list select dimension.Name);
        }

        #endregion

        #region Operator overloading

        /// <summary>
        /// Initializes a new collection from the specified <code>dimension</code>.
        /// </summary>
        /// <param name="dimension">The dimension to be added to the collection.</param>
        /// <returns>Returns an instance of <code>AnalyticsDimensionCollection</code>.</returns>
        public static implicit operator AnalyticsDimensionCollection(AnalyticsDimension dimension) {
            return new AnalyticsDimensionCollection(dimension);
        }

        /// <summary>
        /// Initializes a new collection based on the specified array of <code>dimensions</code>.
        /// </summary>
        /// <param name="dimensions">The array of dimensions to be added to the collection.</param>
        /// <returns>Returns an instance of <code>AnalyticsDimensionCollection</code>.</returns>
        public static implicit operator AnalyticsDimensionCollection(AnalyticsDimension[] dimensions) {
            return new AnalyticsDimensionCollection(dimensions);
        }

        /// <summary>
        /// Adds the specified <code>dimension</code> to <code>collection</code>.
        /// </summary>
        /// <param name="collection">The collection to which the dimension should be added.</param>
        /// <param name="dimension">The dimension to be added to the collection.</param>
        /// <returns>Returns an instance of <code>AnalyticsDimensionCollection</code>.</returns>
        public static AnalyticsDimensionCollection operator +(AnalyticsDimensionCollection collection, AnalyticsDimension dimension) {
            collection.Add(dimension);
            return collection;
        }

        /// <summary>
        /// Initializes a new collection based on the specified string array of <code>dimensions</code>.
        /// </summary>
        /// <param name="dimensions">A string array containing the names of the dimensions to be added.</param>
        /// <returns>Returns an instance of <code>AnalyticsDimensionCollection</code>.</returns>
        public static implicit operator AnalyticsDimensionCollection(string[] dimensions) {
            return new AnalyticsDimensionCollection(from AnalyticsDimension dimension in dimensions select dimension);
        }

        #endregion

    }

}