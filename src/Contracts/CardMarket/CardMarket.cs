using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Contracts;

public record CardMarket
{
    [JsonPropertyName("url")]
    public Uri Url { get; set; }

    [JsonPropertyName("updatedAt")]
    public string UpdatedAt { get; set; }

    [JsonPropertyName("prices")]
    public CardMarketPrices Prices { get; set; }
}
