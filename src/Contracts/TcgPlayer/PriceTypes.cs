using System.Text.Json.Serialization;

namespace Contracts;

public record PriceTypes
{
    [JsonPropertyName("holofoil")]
    public Prices Holofoil { get; set; }

    [JsonPropertyName("reverseHolofoil")]
    public Prices ReverseHolofoil { get; set; }

    [JsonPropertyName("normal")]
    public Prices Normal { get; set; }

    [JsonPropertyName("1stEditionHolofoil")]
    public Prices The1StEditionHolofoil { get; set; }

    [JsonPropertyName("unlimitedHolofoil")]
    public Prices UnlimitedHolofoil { get; set; }

    [JsonPropertyName("1stEdition")]
    public Prices The1StEdition { get; set; }

    [JsonPropertyName("unlimited")]
    public Prices Unlimited { get; set; }
}
