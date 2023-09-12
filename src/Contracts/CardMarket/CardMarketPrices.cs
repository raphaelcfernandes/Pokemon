namespace Contracts;

public record CardMarketPrices
{
    public decimal? AverageSellPrice { get; set; }

    public decimal? LowPrice { get; set; }

    public decimal? TrendPrice { get; set; }

    public decimal? ReverseHoloSell { get; set; }

    public decimal? ReverseHoloLow { get; set; }

    public decimal? ReverseHoloTrend { get; set; }

    public decimal? LowPriceExPlus { get; set; }

    [JsonProperty("avg1")]
    public decimal? AverageDay { get; set; }

    [JsonProperty("avg7")]
    public decimal? AverageWeek { get; set; }

    [JsonProperty("avg30")]
    public decimal? AverageMonth { get; set; }
   
    [JsonProperty("reverseHoloAvg1")]
    public decimal? AverageDayReverseHolo { get; set; }

    [JsonProperty("reverseHoloAvg7")]
    public decimal? AverageWeekReverseHolo { get; set; }

    [JsonProperty("reverseHoloAvg30")]
    public decimal? AverageMonthReverseHolo { get; set; }
}