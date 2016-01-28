using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Analytics.Objects.Profiles {
    
    /// <summary>
    /// Class representing a web profile in a Google Analytics context.
    /// </summary>
    public class AnalyticsProfile : GoogleApiObject {

        #region Properties
        
        public string Id { get; private set; }
        public string AccountId { get; private set; }
        public string WebPropertyId { get; private set; }
        public string InternalWebPropertyId { get; private set; }
        public string Name { get; private set; }
        public string Currency { get; private set; }
        public string Timezone { get; private set; }
        public string WebsiteUrl { get; private set; }
        public string Type { get; private set; }
        public DateTime Created { get; private set; }
        public DateTime Updated { get; private set; }

        #endregion

        #region Constructors

        private AnalyticsProfile(JObject obj) : base(obj) { }

        #endregion

        #region Static methods
        
        /// <summary>
        /// Gets a profile from the specified <var>JObject</var>.
        /// </summary>
        /// <param name="obj">The instance of <var>JObject</var> to parse.</param>
        public static AnalyticsProfile Parse(JObject obj) {

            // If the specified JsonObject is NULL, we just return NULL
            if (obj == null) return null;
        
            // Parse the Jbject
            return new AnalyticsProfile(obj) {
                Id = obj.GetString("id"),
                AccountId = obj.GetString("accountId"),
                WebPropertyId = obj.GetString("webPropertyId"),
                InternalWebPropertyId = obj.GetString("internalWebPropertyId"),
                Name = obj.GetString("name"),
                Currency = obj.GetString("currency"),
                Timezone = obj.GetString("timezone"),
                WebsiteUrl = obj.GetString("websiteUrl"),
                Type = obj.GetString("type"),
                Created = obj.GetDateTime("created"),
                Updated = obj.GetDateTime("updated")
            };
        
        }

        #endregion

    }

}