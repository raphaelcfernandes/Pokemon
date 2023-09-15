namespace Pokemon.ApiRequester
{
    public class CardRequester : ICardRequester
    {
        private readonly IHttpClientWrapper httpClient;
        private readonly string uri = "cards";

        public CardRequester(IHttpClientWrapper httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Card> GetCardByIdAsync(string id)
            => (await this.httpClient.GetResourceAsync<Card>(this.uri, id)).Result;

        public async Task<List<Card>> SearchCards(CardFilter filter)
        {
            StringBuilder builder = new(this.uri);
            builder.WithFilter(filter);
            return (await this.httpClient.GetResourceAsListAsync<Card>(builder.ToString())).Results;
        }

        public async Task<ApiResourceAsList<Card>> SearchCardsAsApiResourceList(CardFilter filter)
        {
            StringBuilder builder = new(this.uri);
            builder.WithFilter(filter);
            return await this.httpClient.GetResourceAsListAsync<Card>(builder.ToString());
        }
    }
}
