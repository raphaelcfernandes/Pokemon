namespace Contracts;

public record SetImages
{
    [JsonProperty("symbol")]
    public Uri Symbol { get; set; }

    [JsonProperty("logo")]
    public Uri Logo { get; set; }
}