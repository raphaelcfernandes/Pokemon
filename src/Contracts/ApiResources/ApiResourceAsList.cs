namespace Contracts
{
    public record ApiResourceAsList<T> where T : class
    {
        [JsonProperty("data")]
        public List<T> Results { get; set; }

        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int Page { get; set; }

        [JsonProperty("pageSize", NullValueHandling = NullValueHandling.Ignore)]
        public int PageSize { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int Count { get; set; }

        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalCount { get; set; }
    }
}
