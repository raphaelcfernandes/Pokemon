namespace Contracts
{
    public record ApiResource<T> where T : class
    {
        [JsonProperty("data")]
        public T Result { get; set; }
    }
}
