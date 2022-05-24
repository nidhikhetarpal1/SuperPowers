namespace Heroes.Services
{
    public class BaseService : IBaseService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public BaseService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        async Task<int> IBaseService.SendRequestAsync(HttpMethod httpMethod,string url)
        {
            HttpClient client = _httpClientFactory.CreateClient();
            int ret = 0;
            if (client != null)
            {
                HttpResponseMessage response = await  client.SendAsync(new HttpRequestMessage(httpMethod, url));
                string result = response.Content.ReadAsStringAsync().Result;
                if(!string.IsNullOrEmpty(result))
                   ret = Convert.ToInt32(result);
            }
           return ret;            
               
        }
    }
}
