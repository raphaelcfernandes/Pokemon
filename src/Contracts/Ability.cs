using System.Text.Json.Serialization;

namespace Contracts;

public record Ability
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}
