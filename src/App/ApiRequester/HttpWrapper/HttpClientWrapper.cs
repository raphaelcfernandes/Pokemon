namespace Pokemon.ApiRequester
{
    public class HttpClientWrapper : IHttpClientWrapper
    {
        private readonly HttpClient httpClient;
        private readonly Uri baseUri = new Uri("https://api.pokemontcg.io/v2/");

        public HttpClientWrapper()
        {
            this.httpClient = new HttpClient() { BaseAddress = this.baseUri };
        }

        public async Task<List<T>> GetResourceAsListAsync<T>(string uri, string id) 
            where T : class
        {
            HttpResponseMessage responseMessage = await this.httpClient.GetAsync($"{uri}/{id}");
            return await this.GetResponseAsListAsync<T>(responseMessage);
        }

        public async Task<List<T>> GetResourceAsListAsync<T>(string uri) 
            where T : class
        {
            HttpResponseMessage responseMessage = await this.httpClient.GetAsync($"{uri}");
            return await this.GetResponseAsListAsync<T>(responseMessage);
        }

        public async Task<T> GetResourceAsync<T>(string uri, string id) where T : class
        {
            HttpResponseMessage responseMessage = await this.httpClient.GetAsync($"{uri}/{id}");
            var res = await responseMessage.Content.ReadAsStringAsync();

            ApiResource<T> resource = JsonConvert.DeserializeObject<ApiResource<T>>(res);

            return resource.Result;
        }

        private async Task<List<T>> GetResponseAsListAsync<T>(HttpResponseMessage responseMessage)
            where T : class
        {
            var res = await responseMessage.Content.ReadAsStringAsync();

            ApiResourceAsList<T>? response = JsonConvert.DeserializeObject<ApiResourceAsList<T>>(res, new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            return response.Results;
        }
    }
}
