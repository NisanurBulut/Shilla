
using static MagicShilla_Utility.SD;

namespace MagicShilla_Utility.VM
{
    public class APIRequest
    {
        public ApiType apiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
    }
}
