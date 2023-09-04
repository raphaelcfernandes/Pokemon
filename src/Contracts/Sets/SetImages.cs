using System.Text.Json.Serialization;

namespace Contracts;

public record SetImages
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }

    [JsonPropertyName("logo")]
    public string Logo { get; set; }
}