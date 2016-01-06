using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Analytics.Objects.WebProperties {

    public class AnalyticsWebProperty : GoogleApiObject {
        
        public string Id { get; private set; }
        public string AccountId { get; private set; }
        public string InternalWebPropertyId { get; private set; }
        public string Name { get; private set; }
        public string WebsiteUrl { get; private set; }
        public string Level { get; private set; }
        public DateTime Created { get; private set; }
        public DateTime Updated { get; private set; }

        private AnalyticsWebProperty(JObject obj) : base(obj) { }

        public static AnalyticsWebProperty Parse(JObject obj) {
            return new AnalyticsWebProperty(obj) {
                Id = obj.GetString("id"),
                AccountId = obj.GetString("accountId"),
                InternalWebPropertyId = obj.GetString("internalWebPropertyId"),
                Name = obj.GetString("name"),
                WebsiteUrl = obj.GetString("websiteUrl"),
                Level = obj.GetString("level"),
                Created = obj.GetDateTime("created"),
                Updated = obj.GetDateTime("updated")
            };
        }

    }

}