namespace Contracts;

public record PriceTypes
{
    [JsonProperty("holofoil")]
    public Prices Holofoil { get; set; }

    [JsonProperty("reverseHolofoil")]
    public Prices ReverseHolofoil { get; set; }

    [JsonProperty("normal")]
    public Prices Normal { get; set; }

    [JsonProperty("1stEditionHolofoil")]
    public Prices The1StEditionHolofoil { get; set; }

    [JsonProperty("unlimitedHolofoil")]
    public Prices UnlimitedHolofoil { get; set; }

    [JsonProperty("1stEdition")]
    public Prices The1StEdition { get; set; }

    [JsonProperty("unlimited")]
    public Prices Unlimited { get; set; }
}
