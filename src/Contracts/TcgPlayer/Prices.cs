using System.Text.Json.Serialization;

namespace Contracts;

public record Prices
{
    [JsonPropertyName("low")]
    public double Low { get; set; }

    [JsonPropertyName("mid")]
    public double Mid { get; set; }

    [JsonPropertyName("high")]
    public double High { get; set; }

    [JsonPropertyName("market")]
    public double Market { get; set; }

    [JsonPropertyName("directLow")]
    public double DirectLow { get; set; }
}
