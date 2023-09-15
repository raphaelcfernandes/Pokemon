namespace Pokemon.ApiRequester
{
    public interface IHttpClientWrapper
    {
        Task<ApiResourceAsList<T>> GetResourceAsListAsync<T>(string uri) where T : class;

        Task<ApiResource<T>> GetResourceAsync<T>(string uri, string id) where T : class;
    }
}
