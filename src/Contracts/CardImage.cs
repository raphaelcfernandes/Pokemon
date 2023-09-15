namespace Contracts;

public record CardImage
{
    [JsonProperty("small")]
    public Uri Small { get; set; }

    [JsonProperty("large")]
    public Uri Large { get; set; }
}