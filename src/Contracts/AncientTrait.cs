using System.Text.Json.Serialization;

namespace Contracts;

public record AncientTrait
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }
}