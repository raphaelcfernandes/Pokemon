namespace Pokemon.ApiRequester
{
    public interface IHttpClientWrapper
    {
        Task<List<T>> GetResourceAsListAsync<T>(string uri) where T : class;

        Task<T> GetResourceAsync<T>(string uri, string id) where T : class;
    }
}
