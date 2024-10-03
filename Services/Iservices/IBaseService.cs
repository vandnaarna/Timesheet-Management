using TimesheetMVC.Models;
using System.Net.Http;


namespace TimesheetMVC.Services.Iservices
{
    public interface IBaseService
    {
        APIResponse response { get;set;}
        Task<T>SendAsync<T>(ApiRequest apirequest);
    }
}
