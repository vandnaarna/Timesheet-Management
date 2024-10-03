using System.Net;

namespace TimesheetMVC.Models
{
    public class APIResponse
    {
        public HttpStatusCode statusCode { get; set; }
        public bool IsSuccess { get; set; } = true;
        public List<string>? ErrorMesseges { get; set; }
        public object? Result { get; set; }
    }
}
