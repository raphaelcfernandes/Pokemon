namespace Contracts;

public record Set
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("series")]
    public string Series { get; set; }

    [JsonProperty("printedTotal")]
    public long PrintedTotal { get; set; }

    [JsonProperty("total")]
    public long Total { get; set; }

    [JsonProperty("legalities")]
    public Legalities Legalities { get; set; }

    [JsonProperty("ptcgoCode")]
    public string PtcgoCode { get; set; }

    [JsonProperty("releaseDate")]
    public string ReleaseDate { get; set; }

    [JsonProperty("updatedAt")]
    public string UpdatedAt { get; set; }

    [JsonProperty("images")]
    public SetImages Images { get; set; }
}
