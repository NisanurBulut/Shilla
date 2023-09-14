
using static MagicShilla_Utility.SD;

namespace MagicShilla_Utility.VM
{
    public class APIRequestModel
    {
        public ApiType apiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string Token { get; set; }
    }
}
