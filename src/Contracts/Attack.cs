using System.Text.Json.Serialization;

namespace Contracts;

public record Attack
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("damage")]
    public string Damage { get; set; }

    [JsonPropertyName("convertedEnergyCost")]
    public int ConvertedEnergyCost { get; set; }

    [JsonPropertyName("convertedEnergyCost")]
    public IEnumerable<string> Cost { get; set; }
}