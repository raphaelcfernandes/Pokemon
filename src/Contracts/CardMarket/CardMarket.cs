﻿namespace Contracts;

public record CardMarket
{
    [JsonProperty("url")]
    public Uri Url { get; set; }

    [JsonProperty("updatedAt")]
    public string UpdatedAt { get; set; }

    [JsonProperty("prices")]
    public CardMarketPrices Prices { get; set; }
}
