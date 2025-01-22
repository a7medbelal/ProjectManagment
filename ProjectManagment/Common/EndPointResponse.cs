using ProjectManagment.Common.Data;

namespace ProjectManagment.Common
{
   
        public record EndPointResponse<T>(T Data, bool IsSuccess, string message , ErrorCode ErrorCode)
        {
            public static EndPointResponse<T> Success(T data, string message = "")
            {
                return new EndPointResponse<T>(data, true, message, ErrorCode.None);
            }

            public static EndPointResponse<T> Failure(ErrorCode errorCode)
            {
                return new EndPointResponse<T>(default, false, " ", errorCode);
            }

            public static EndPointResponse<T> Failure(ErrorCode errorCode, string message)
            {
                return new EndPointResponse<T>(default, false, message, errorCode);
            }
        }
    
}
