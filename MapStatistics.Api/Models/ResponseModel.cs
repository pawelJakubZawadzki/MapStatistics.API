using Newtonsoft.Json;

namespace MapStatistics.Api.Models
{
    public class ResponseModel<T>
    {
        [JsonProperty("result")]
        public T Result { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
        
        public ResponseModel(T data)
        {
            Result = data;
            IsSuccess = true;
        }

        public ResponseModel(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }
    }
}
