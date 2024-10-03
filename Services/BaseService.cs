using TimesheetMVC.Models;
using TimesheetMVC.Services.Iservices;


namespace TimesheetMVC.Services
{
    public class BaseService : IBaseService
    {
        public APIResponse response{ get; set;}
        public IHttpClientFactory httpClient1 { get; set;}
        public BaseService(IHttpClientFactory httpClient)
        {
            this.response = new(); 
            this.httpClient1 = httpClient;
        }
        public  Task<T>SendAsync<T>(ApiRequest apirequest)
        {
            try
            {
                var client = httpClient1.CreateClient("MagicApi");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept","application/json");
                message.RequestUri = new Uri(apirequest.url);
                if (apirequest.data != null)
                { 
                 message.Content = new StringContent
                        (JsonConvert.SerializeObject(apirequest.data),
                        Encoding.UTF8,"application/json");
                }
            }  
             switch(Exception ex)
            {

            }
        }
     }
}
