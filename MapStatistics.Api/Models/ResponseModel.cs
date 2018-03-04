namespace MapStatistics.Api.Models
{
    public class ResponseModel<T>
    {
        public T Result { get; set; }
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
