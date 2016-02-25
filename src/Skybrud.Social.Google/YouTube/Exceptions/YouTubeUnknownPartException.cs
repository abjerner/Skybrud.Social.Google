﻿using System;
using Skybrud.Social.Google.YouTube.Options.Common;

namespace Skybrud.Social.Google.YouTube.Exceptions {
    
    /// <summary>
    /// Exception class throw when a given string can't be parsed into an instance of <see cref="YouTubePart"/>.
    /// </summary>
    public class YouTubeUnknownPartException : Exception {
        
        #region Properties

        /// <summary>
        /// Gets the name of the part.
        /// </summary>
        public string PartName { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new exception for the part with the specified <code>partName</code>.
        /// </summary>
        /// <param name="partName">The name of the part.</param>
        public YouTubeUnknownPartException(string partName) : this(partName, "Property cannot be empty.") { }

        /// <summary>
        /// Initializes a new exception for the part with the specified <code>partName</code>.
        /// </summary>
        /// <param name="partName">The name of the part.</param>
        /// <param name="message">The message of the exception.</param>
        public YouTubeUnknownPartException(string partName, string message) : base(message) {
            PartName = partName;
        }

        #endregion

        #region Member methods

        public override string Message {
            get {
                String s = base.Message;
                if (!String.IsNullOrEmpty(PartName)) {
                    return s + Environment.NewLine + "Property name: " + PartName;
                }
                return s;
            }
        }

        #endregion

    }

}