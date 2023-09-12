namespace Contracts;

public record TcgPlayer
{
    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("updatedAt")]
    public string UpdatedAt { get; set; }

    [JsonProperty("prices")]
    public PriceTypes Prices { get; set; }
}
