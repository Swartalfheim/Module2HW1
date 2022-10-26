namespace HWen
{
    public class Result
    {
        public Result(bool status, string? message = null)
        {
            Status = status;
            Message = message;
        }

        public bool Status { get; set; }
        public string? Message { get; set; }
    }
}
