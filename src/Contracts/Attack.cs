namespace Contracts;

public record Attack
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("text")]
    public string Text { get; set; }

    [JsonProperty("damage")]
    public string Damage { get; set; }

    [JsonProperty("convertedEnergyCost")]
    public int ConvertedEnergyCost { get; set; }

    [JsonProperty("cost")]
    public List<string> Cost { get; set; }
}