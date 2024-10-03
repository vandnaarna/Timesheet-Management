using static ClassLibraryUtility.Class1;

namespace TimesheetMVC.Models
{
    public class ApiRequest
    {
        public Apitype apitype { get; set; } = Apitype.GET;
        public string? url { get; set; }
        public object?  data{ get; set; }

    }
}
