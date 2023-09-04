using System.Text.Json.Serialization;

namespace Contracts;

public record Set
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("series")]
    public string Series { get; set; }

    [JsonPropertyName("printedTotal")]
    public long PrintedTotal { get; set; }

    [JsonPropertyName("total")]
    public long Total { get; set; }

    [JsonPropertyName("legalities")]
    public Legalities Legalities { get; set; }

    [JsonPropertyName("ptcgoCode")]
    public string PtcgoCode { get; set; }

    [JsonPropertyName("releaseDate")]
    public string ReleaseDate { get; set; }

    [JsonPropertyName("updatedAt")]
    public string UpdatedAt { get; set; }

    [JsonPropertyName("images")]
    public SetImages Images { get; set; }
}
