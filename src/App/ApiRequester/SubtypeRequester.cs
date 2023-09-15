namespace Pokemon.ApiRequester
{
    public class SubtypeRequester : ISubtypeRequester
    {
        private readonly IHttpClientWrapper httpClient;
        private string uri = "supertypes";

        public SubtypeRequester(IHttpClientWrapper httpClient) 
        {
            this.httpClient = httpClient;
        }

        public async Task<List<string>> GetSubtypes() 
            => (await this.httpClient.GetResourceAsListAsync<string>(this.uri)).Results;
    }
}
