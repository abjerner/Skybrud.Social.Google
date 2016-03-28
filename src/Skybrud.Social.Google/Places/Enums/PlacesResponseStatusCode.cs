namespace Skybrud.Social.Google.Places.Enums {
    
    public enum PlacesResponseStatusCode {

        /// <summary>
        /// Indicates that no errors occurred; that the request was successful.
        /// </summary>
        Ok,

        ZeroResults,
        OverQueryLimit,
        RequestDenied,
        InvalidRequest,
        UnknownError,
        NotFound
    
    }

}