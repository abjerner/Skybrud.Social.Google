using System;

namespace Skybrud.Social.Google.Options.Authentication {

    /// <summary>
    /// Enum flag describing how the user should be prompted when authorizing with the Google API.
    /// </summary>
    [Flags]
    public enum GooglePromptOption {

        /// <summary>
        /// Do not display any authentication or consent screens. Must not be specified with other values.
        /// </summary>
        None = 0,

        /// <summary>
        /// Prompt the user for consent.
        /// </summary>
        Consent = 1,

        /// <summary>
        /// Prompt the user to select an account.
        /// </summary>
        SelectAccount = 2

    }

}