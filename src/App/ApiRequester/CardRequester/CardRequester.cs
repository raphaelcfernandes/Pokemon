﻿using System.Text;

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
            => await this.httpClient.GetResourceAsync<Card>(this.uri, id);

        public async Task<List<Card>> SearchCards(CardFilter filter)
        {
            StringBuilder builder = new(this.uri);
            builder.WithFilter(filter);
            Debug.WriteLine(builder.ToString());
            return await this.httpClient.GetResourceAsListAsync<Card>(builder.ToString());
        }
            
    }
}
