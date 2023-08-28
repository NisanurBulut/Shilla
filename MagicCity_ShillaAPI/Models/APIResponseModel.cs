using System.Net;

namespace MagicCity_ShillaAPI.Models
{
    public class APIResponseModel
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public List<string> ErrorMessages { get; set; }
        public object Result { get; set; }

        public void setBadRequest()
        {
            StatusCode = HttpStatusCode.BadRequest;
            IsSuccess = false;
        }
        public void setBadRequestWithErrorMessage(string errorMessage = "")
        {
            this.setBadRequest();
            
            this.ErrorMessages=new List<string>() { errorMessage };
        }
    }
}
