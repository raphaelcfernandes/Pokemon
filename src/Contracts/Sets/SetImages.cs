namespace Contracts;

public record SetImages
{
    [JsonProperty("symbol")]
    public string Symbol { get; set; }

    [JsonProperty("logo")]
    public string Logo { get; set; }
}