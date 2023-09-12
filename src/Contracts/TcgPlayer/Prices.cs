namespace Contracts;

public record Prices
{
    [JsonProperty("low")]
    public double? Low { get; set; }

    [JsonProperty("mid")]
    public double? Mid { get; set; }

    [JsonProperty("high")]
    public double? High { get; set; }

    [JsonProperty("market")]
    public double? Market { get; set; }

    [JsonProperty("directLow")]
    public double? DirectLow { get; set; }
}
