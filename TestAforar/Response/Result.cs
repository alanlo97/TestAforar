namespace TestAforar.Response
{
    public class Result
    {
        public bool Success { get; protected set; }
        public string Message { get; protected set; }
        public int StatusCode { get; set; }

        protected Result(int statusCode, string message, bool success)
        {
            this.Success = success;
            this.StatusCode = statusCode;
            this.Message = message;
        }


        public static Result ResultState(int statusCode, string message, bool success)
        {
            return new Result(statusCode, message, success);
        }
    }
}
