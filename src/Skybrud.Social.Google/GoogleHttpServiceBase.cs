namespace Skybrud.Social.Google {

    /// <summary>
    /// Class representing a base implementation for a Google API service.
    /// </summary>
    public class GoogleHttpServiceBase {

        /// <summary>
        /// Gets a reference to the parent service instance.
        /// </summary>
        public GoogleHttpService Service { get; }

        /// <summary>
        /// Initializes a new instance from the specified Google <paramref name="service"/>.
        /// </summary>
        /// <param name="service">The parent Google service.</param>
        protected GoogleHttpServiceBase(GoogleHttpService service) {
            Service = service;
        }

    }

}