﻿namespace Contracts;

public record Ability
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("text")]
    public string Text { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }
}
