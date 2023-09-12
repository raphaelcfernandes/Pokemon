namespace Contracts;

public record AncientTrait
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("text")]
    public string Text { get; set; }
}