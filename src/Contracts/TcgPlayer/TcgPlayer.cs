using System.Text.Json.Serialization;

namespace Contracts;

public record TcgPlayer
{
    [JsonPropertyName("url")]
    public Uri Url { get; set; }

    [JsonPropertyName("updatedAt")]
    public string UpdatedAt { get; set; }

    [JsonPropertyName("prices")]
    public PriceTypes Prices { get; set; }
}
