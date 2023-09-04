using System.Text.Json.Serialization;

namespace Contracts;

public record CardImage
{
    [JsonPropertyName("small")]
    public Uri Small { get; set; }

    [JsonPropertyName("large")]
    public Uri Large { get; set; }
}