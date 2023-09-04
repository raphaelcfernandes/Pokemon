using System.Text.Json.Serialization;

namespace Contracts;

public record Legalities
{
    [JsonPropertyName("standard")]
    public string Standard { get; set; }

    [JsonPropertyName("expanded")]
    public string Expanded { get; set; }

    [JsonPropertyName("unlimited")]
    public string Unlimited { get; set; }
}