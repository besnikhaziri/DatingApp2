namespace API.Errors
{
    public class ApiException
    {
        public ApiException(int statueCode, string message = null, string details = null)
        {
            StatueCode = statueCode;
            Message = message;
            Details = details;
        }

        public int StatueCode { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
    }
}