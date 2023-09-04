namespace Contracts;

using System.Text.Json.Serialization;

public record Card 
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("supertype")]
    public string Supertype { get; set; } = string.Empty;

    [JsonPropertyName("subtypes")]
    public IEnumerable<string> Subtyeps { get; set; }

    [JsonPropertyName("level")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Level { get; set; }

    [JsonPropertyName("hp")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int Hp { get; set; }

    [JsonPropertyName("types")]
    public List<string> Types { get; set; }

    [JsonPropertyName("evolvesFrom")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string EvolvesFrom { get; set; }

    [JsonPropertyName("evolvesTo")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string EvolvesTo { get; set; }

    [JsonPropertyName("rules")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<string> Rules { get; set; }

    [JsonPropertyName("ancientTrait")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public AncientTrait AncientTrait { get; set; }
}
