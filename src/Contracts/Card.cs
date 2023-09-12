namespace Contracts;

using System.Collections.Generic;

public record Card 
{
    [JsonProperty("id")]
    public string Id { get; set; } = string.Empty;

    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("supertype")]
    public string Supertype { get; set; } = string.Empty;

    [JsonProperty("subtypes")]
    public List<string> Subtypes { get; set; }

    [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
    public string Level { get; set; }

    [JsonProperty("hp", NullValueHandling = NullValueHandling.Ignore)]
    public string? Hp { get; set; }

    [JsonProperty("types")]
    public List<string> Types { get; set; }

    [JsonProperty("evolvesFrom", NullValueHandling = NullValueHandling.Ignore)]
    public string? EvolvesFrom { get; set; }

    [JsonProperty("evolvesTo", NullValueHandling = NullValueHandling.Ignore)]
    public List<string>? EvolvesTo { get; set; }

    [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
    public List<string>? Rules { get; set; }

    [JsonProperty("ancientTrait", NullValueHandling = NullValueHandling.Ignore)]
    public AncientTrait? AncientTrait { get; set; }

    [JsonProperty("abilities", NullValueHandling = NullValueHandling.Ignore)]
    public List<Ability>? Abilities { get; set; }

    [JsonProperty("attacks", NullValueHandling = NullValueHandling.Ignore)]
    public List<Attack>? Attacks { get; set; }

    [JsonProperty("weaknesses", NullValueHandling = NullValueHandling.Ignore)]
    public List<TypeValue>? Weaknesses { get; set; }

    [JsonProperty("resistances", NullValueHandling = NullValueHandling.Ignore)]
    public List<TypeValue>? Resistances { get; set; }

    [JsonProperty("retreatCost", NullValueHandling = NullValueHandling.Ignore)]
    public List<string>? RetreatCost { get; set; }

    [JsonProperty("convertedRetreatCost", NullValueHandling = NullValueHandling.Ignore)]
    public int? ConvertedRetreatCost { get; set; }

    [JsonProperty("set")]
    public Set Set { get; set; }

    [JsonProperty("number")]
    public string Number { get; set; }

    [JsonProperty("artist")]
    public string Artist { get; set; }

    [JsonProperty("rarity", NullValueHandling = NullValueHandling.Ignore)]
    public string? Rarity { get; set; }

    [JsonProperty("flavorText", NullValueHandling = NullValueHandling.Ignore)]
    public string? FlavorText { get; set; }

    [JsonProperty("nationalPokedexNumbers")]
    public List<int> NationalPokedexNumbers { get; set; }
    
    [JsonProperty("legalities")]
    public Legalities Legalities { get; set; }

    [JsonProperty("regulationMark", NullValueHandling = NullValueHandling.Ignore)]
    public string? RegulationMark { get; set; }

    [JsonProperty("images")]
    public CardImage Images { get; set; }

    [JsonProperty("tcgplayer")]
    public TcgPlayer Tcgplayer { get; set; }

    [JsonProperty("cardmarket")]
    public CardMarket Cardmarket { get; set; }
}
