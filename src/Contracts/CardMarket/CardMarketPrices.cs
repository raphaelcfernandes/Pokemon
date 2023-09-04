﻿using System.Text.Json.Serialization;

namespace Contracts;

public class CardMarketPrices
{
    public decimal? AverageSellPrice { get; set; }

    public decimal? LowPrice { get; set; }

    public decimal? TrendPrice { get; set; }

    public decimal? ReverseHoloSell { get; set; }

    public decimal? ReverseHoloLow { get; set; }

    public decimal? ReverseHoloTrend { get; set; }

    public decimal? LowPriceExPlus { get; set; }

    [JsonPropertyName("avg1")]
    public decimal? AverageDay { get; set; }

    [JsonPropertyName("avg7")]
    public decimal? AverageWeek { get; set; }

    [JsonPropertyName("avg30")]
    public decimal? AverageMonth { get; set; }
   
    [JsonPropertyName("reverseHoloAvg1")]
    public decimal? AverageDayReverseHolo { get; set; }

    [JsonPropertyName("reverseHoloAvg7")]
    public decimal? AverageWeekReverseHolo { get; set; }

    [JsonPropertyName("reverseHoloAvg30")]
    public decimal? AverageMonthReverseHolo { get; set; }
}