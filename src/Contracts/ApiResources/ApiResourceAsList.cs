namespace Contracts
{
    public record ApiResourceAsList<T> where T : class
    {
        [JsonProperty("data")]
        public List<T> Results { get; set; }
    }
}
