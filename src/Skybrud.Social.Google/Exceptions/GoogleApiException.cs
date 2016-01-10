using System;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Exceptions {
    
    public class GoogleApiException : Exception {

        #region Properties

        public SocialHttpResponse Response { get; private set; }

        public int Code { get; private set; }

        public new string Message { get; private set; }

        #endregion

        #region Constructors

        public GoogleApiException(SocialHttpResponse response, int code, string message) : base(code + ": " + message) {
            Response = response;
            Code = code;
            Message = message;
        }

        #endregion

    }

}
