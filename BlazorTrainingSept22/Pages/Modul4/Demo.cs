namespace BlazorTrainingSept22.Pages.Modul4
{
    public class Demo
    {
        IHttpClientFactory _httpClient;
        public Demo(IHttpClientFactory __httpClientFactory)
        {
            _httpClient = __httpClientFactory;


        }
        public HttpClient Http()
        {
            return _httpClient.CreateClient();
        }
    }
}
