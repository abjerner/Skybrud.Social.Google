using System.Collections.Generic;
using System.Linq;
using Skybrud.Essentials.Strings;
using Skybrud.Social.Google.Scopes;

namespace Skybrud.Social.Google {

    /// <summary>
    /// Utility class with various helper methods used throughout this package.
    /// </summary>
    public class GoogleUtils {

#if I_CAN_HAS_APP_DOMAIN

        /// <summary>
        /// Returns an array of scopes parsed from the specified <paramref name="value"/>.
        /// </summary>
        /// <param name="value">A string with the scopes to be parsed.</param>
        /// <returns>An array of <see cref="GoogleScope"/>.</returns>
        public static GoogleScope[] ParseScopes(string value) {

            List<GoogleScope> list = new List<GoogleScope>();

            foreach (string alias in StringUtils.ParseStringArray(value)) {
                if (TryParseScope(alias, out GoogleScope scope)) {
                    list.Add(scope);
                }
            }

            return list.ToArray();

        }

        /// <summary>
        /// Attempts to parse the specified <paramref name="value"/> into an instance of <see cref="GoogleScope"/>.
        /// </summary>
        /// <param name="value">The alias of a known scope.</param>
        /// <param name="scope">The scope if a match was found.</param>
        /// <returns><c>true</c> if a matching scope was found; otherwise <c>false</c>.</returns>
        public static bool TryParseScope(string value, out GoogleScope scope) {

            scope = null;

            if (string.IsNullOrWhiteSpace(value)) return false;

            value = value.Trim();

            switch (value) {

                case "https://www.googleapis.com/auth/userinfo.profile":
                    scope = GoogleScopes.Profile;
                    return true;

                case "https://www.googleapis.com/auth/userinfo.email":
                    scope = GoogleScopes.Email;
                    return true;

                default:
                    scope = GoogleScopeGroup.GetAll().SelectMany(x => x.Scopes).FirstOrDefault(x => x.Alias == value);
                    return scope != null;

            }

        }

#endif

    }

}