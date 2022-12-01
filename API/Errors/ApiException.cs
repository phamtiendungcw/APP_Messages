namespace API.Errors
{
    public class ApiException
    {
        public ApiException(int statusCode, string message = null, string details = null)
        {
            StatusCode = statusCode;
            Message = message;
            Details = details;
        }

        public string Details { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }
    }
}