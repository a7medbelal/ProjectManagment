using ProjectManagment.Common.Data;

namespace ProjectManagment.Common
{
    public record RequestResult<T>(T Data, bool IsSuccess, string message, ErrorCode ErrorCode)
    {
        public static RequestResult<T> Success(T data, string message = "")
        {
            return new RequestResult<T>(data, true, message, ErrorCode.None);
        }

        public static RequestResult<T> Failure(ErrorCode errorCode)
        {
            return new RequestResult<T>(default, false," ", errorCode);
        }

    }
}
