using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Common.Models;

namespace Skybrud.Social.Google.Plus.Objects.People {
    
    /// <summary>
    /// Class representing a person in the Google+ API.
    /// </summary>
    public class PlusPerson : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the kind of the API object.
        /// </summary>
        public string Kind { get; private set; }

        /// <summary>
        /// Gets the ETag of the API object.
        /// </summary>
        public string ETag { get; private set; }

        /// <summary>
        /// Gets the gender of the person.
        /// </summary>
        public string Gender { get; private set; }

        /// <summary>
        /// Gets an array of email adresses of the users.
        /// </summary>
        public PlusPersonEmail[] Emails { get; private set; }

        /// <summary>
        /// Gets an array of links of the users.
        /// </summary>
        public PlusPersonLink[] Urls { get; private set; }

        /// <summary>
        /// Gets the type of the object.
        /// </summary>
        public string ObjectType { get; private set; }

        /// <summary>
        /// Gets the ID of the person.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the display name of the person.
        /// </summary>
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets information about the name of the user.
        /// </summary>
        public PlusPersonName Name { get; private set; }

        /// <summary>
        /// Gets the URL to the Google+ profile of the person.
        /// </summary>
        public string Url { get; private set; }

        /// <summary>
        /// Gets information about an image of the person.
        /// </summary>
        public PlusPersonImage Image { get; private set; }

        /// <summary>
        /// Gets whether the person is a Google+ user.
        /// </summary>
        public bool IsPlusUser { get; private set; }

        /// <summary>
        /// Gets the language (locale) of the person.
        /// </summary>
        public string Language { get; private set; }

        /// <summary>
        /// Gets the amount of people who have added the person to a circle. 
        /// </summary>
        public int CircledByCount { get; private set; }

        /// <summary>
        /// Gets whether the person has been verified.
        /// </summary>
        public bool IsVerified { get; private set; }

        #endregion

        #region Constructors

        private PlusPerson(JObject obj) : base(obj) {
            Kind = obj.GetString("kind");
            ETag = obj.GetString("etag");
            Gender = obj.GetString("gender");
            Emails = obj.GetArray("emails", PlusPersonEmail.Parse);
            Urls = obj.GetArray("urls", PlusPersonLink.Parse);
            ObjectType = obj.GetString("objectType");
            Id = obj.GetString("id");
            DisplayName = obj.GetString("displayName");
            Name = obj.GetObject("name", PlusPersonName.Parse);
            Url = obj.GetString("url");
            Image = obj.GetObject("image", PlusPersonImage.Parse);
            IsPlusUser = obj.GetBoolean("isPlusUser");
            Language = obj.GetString("language");
            CircledByCount = obj.GetInt32("circledByCount");
            IsVerified = obj.GetBoolean("verified");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <code>PlusPerson</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to be parsed.</param>
        public static PlusPerson Parse(JObject obj) {
            return obj == null ? null : new PlusPerson(obj);
        }

        #endregion

    }

}