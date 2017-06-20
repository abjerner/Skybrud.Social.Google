using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Common.Models;
using Skybrud.Social.Google.Places.Enums;

namespace Skybrud.Social.Google.Places.Models {
    
    public class PlacesDetailsResult : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets an array of separate address components used to compose a given address. For example, the address
        /// <code>111 8th Avenue, New York, NY</code> contains separate address components for <code>111</code> (the
        /// street number, <code>8th Avenue</code> (the route), <code>New York</code> (the city) and <code>NY</code>
        /// (the US state).
        /// </summary>
        public PlacesAddressComponent[] AddressComponents { get; private set; }

        /// <summary>
        /// Gets a representation of the place's address in the <strong>adr microformat</strong>.
        /// </summary>
        public string AdrAddress { get; private set; }

        /// <summary>
        /// Gets a a string containing the human-readable address of this place. Often this address is equivalent to
        /// the "postal address," which sometimes differs from country to country. This address is generally composed
        /// of one or more <see cref="AddressComponents"/> fields.
        /// </summary>
        public string FormattedAddress { get; private set; }

        /// <summary>
        /// Gets the formatted phone number of the place. Use <see cref="HasPhoneNumber"/> to check whether a phone
        /// number has been specified for the place.
        /// </summary>
        public string FormattedPhoneNumber { get; private set; }

        /// <summary>
        /// Gets whether a phone number was specified for the place. If <code>false</code>,
        /// <see cref="FormattedPhoneNumber"/> will be empty.
        /// </summary>
        public bool HasPhoneNumber {
            get { return !String.IsNullOrWhiteSpace(FormattedAddress); }
        }

        public PlacesGeometry Geometry { get; private set; }

        /// <summary>
        /// Gets the URL of a suggested icon which may be displayed to the user when indicating this result on a map.
        /// </summary>
        public string Icon { get; private set; }

        /// <summary>
        /// Decprecated in favor of <see cref="PlaceId"/>.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the place's phone number in international format. International format includes the country code, and
        /// is prefixed with the plus (+) sign. For example, the <see cref="InternationalPhoneNumber"/> for Google's
        /// Sydney, Australia office is <code>+61 2 9374 4000</code>.
        /// </summary>
        public string InternationalPhoneNumber { get; private set; }

        /// <summary>
        /// Gets the human-readable name for the returned result. For <code>establishment</code> results, this is
        /// usually the canonicalized business name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets information about the opening hours of the place. Use the <see cref="HasOpeningHours"/> property to
        /// see whether opening hours has been specified for the place.
        /// </summary>
        public PlacesOpeningHours OpeningHours { get; private set; }

        /// <summary>
        /// Gets whether opening hours has been specified for the place.
        /// </summary>
        public bool HasOpeningHours {
            get { return OpeningHours != null; }
        }

        /// <summary>
        /// Gets whether the place has permanently shut down.
        /// </summary>
        public bool HasPermanentlyClosed { get; private set; }

        // TODO: Add support for the "photos" property

        /// <summary>
        /// Gets a textual identifier that uniquely identifies a place.
        /// </summary>
        public string PlaceId { get; private set; }

        /// <summary>
        /// Gets the price level of the place, on a scale of <code>0</code> to <code>4</code>. The exact amount
        /// indicated by a specific value will vary from region to region.
        /// </summary>
        public PlacesPriceLevel PriceLevel { get; private set; }

        /// <summary>
        /// Indicates whether a price level (see <see cref="PriceLevel"/>) was specified for the place.
        /// </summary>
        public bool HasPriceLevel {
            get { return PriceLevel != PlacesPriceLevel.Unspecified; }
        }
        
        /// <summary>
        /// Gets the the place's rating, from <code>1.0</code> to <code>5.0</code>, based on aggregated user reviews.
        /// </summary>
        public float Rating { get; private set; }

        /// <summary>
        /// Decprecated in favor of <see cref="PlaceId"/>.
        /// </summary>
        public string Reference { get; private set; }

        // TODO: Add support for the "reviews" property

        public string Scope { get; private set; }

        /// <summary>
        /// Gets an array of feature types describing the given result.
        /// </summary>
        public string[] Types { get; private set; }

        /// <summary>
        /// Gets the URL of the official Google page for this place. This will be the Google-owned page that contains
        /// the best available information about the place. Applications must link to or embed this page on any screen
        /// that shows detailed results about the place to the user.
        /// </summary>
        public string Url { get; private set; }

        /// <summary>
        /// Gets the place's current timezone offset from UTC.
        /// </summary>
        public TimeSpan UtcOffset { get; private set; }

        /// <summary>
        /// Gets a simplified address for the place, including the street name, street number, and locality, but not
        /// the province/state, postal code, or country. For example, Google's Sydney, Australia office has a
        /// <see cref="Vicinity"/> value of <code>48 Pirrama Road, Pyrmont</code>.
        /// </summary>
        public string Vicinity { get; private set; }

        /// <summary>
        /// Gets the authoritative website for this place, such as a business' homepage.
        /// </summary>
        public string Website { get; private set; }

        /// <summary>
        /// Gets whether a website was specified for the place (whether the <see cref="Website"/> property has a value). 
        /// </summary>
        public bool HasWebsite {
            get { return !String.IsNullOrWhiteSpace(Website); }
        }

        #endregion

        #region Constructors

        private PlacesDetailsResult(JObject obj) : base(obj) {
            AddressComponents = obj.GetArray("address_components", PlacesAddressComponent.Parse);
            AdrAddress = obj.GetString("adr_address");
            FormattedAddress = obj.GetString("formatted_address");
            FormattedPhoneNumber = obj.GetString("formatted_phone_number");
            Geometry = obj.GetObject("geometry", PlacesGeometry.Parse);
            Icon = obj.GetString("icon");
            Id = obj.GetString("id");
            InternationalPhoneNumber = obj.GetString("international_phone_number");
            Name = obj.GetString("name");
            OpeningHours = obj.GetObject("opening_hours", PlacesOpeningHours.Parse);
            HasPermanentlyClosed = obj.GetBoolean("permanently_closed");
            PlaceId = obj.GetString("place_id");
            PriceLevel = obj.HasValue("price_level") ? obj.GetEnum<PlacesPriceLevel>("price_level") : PlacesPriceLevel.Unspecified;
            Rating = obj.GetFloat("rating");
            Reference = obj.GetString("reference");
            Scope = obj.GetString("scope");
            Types = obj.GetStringArray("types");
            Url = obj.GetString("url");
            UtcOffset = obj.GetDouble("utc_offset", TimeSpan.FromMinutes);
            Vicinity = obj.GetString("vicinity");
            Website = obj.GetString("website");
        }

        #endregion
        
        #region Static methods
        
        /// <summary>
        /// Gets a user from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns an instance of <see cref="PlacesDetailsResult"/> representing the place.</returns>
        public static PlacesDetailsResult Parse(JObject obj) {
            return obj == null ? null : new PlacesDetailsResult(obj);
        }

        #endregion

    }

}