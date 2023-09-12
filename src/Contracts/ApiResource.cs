namespace Contracts
{
    public record ApiResource<T> where T : class
    {
        [JsonProperty("data")]
        public List<T> Results { get; set; }
    }
}
