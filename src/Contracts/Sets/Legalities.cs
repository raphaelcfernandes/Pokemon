namespace Contracts;

public record Legalities
{
    [JsonProperty("standard")]
    public string Standard { get; set; }

    [JsonProperty("expanded")]
    public string Expanded { get; set; }

    [JsonProperty("unlimited")]
    public string Unlimited { get; set; }
}