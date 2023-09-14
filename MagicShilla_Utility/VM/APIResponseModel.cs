using System.Net;

namespace MagicShilla_Utility.VM
{
    public class APIResponseModel
    {
        public APIResponseModel()
        {
            IsSuccess = false;
            ErrorMessages = new List<string>();
        }
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

            this.ErrorMessages = new List<string>() { errorMessage };
        }
        public void setOk(object resultItem)
        {
            this.StatusCode=HttpStatusCode.OK;
            this.Result = resultItem;
            this.IsSuccess = true;
        }
    }
}
