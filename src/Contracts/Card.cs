namespace Contracts;

using System.Collections.Generic;
using System.Text.Json.Serialization;
using Contracts.Sets;

public record Card 
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("supertype")]
    public string Supertype { get; set; } = string.Empty;

    [JsonPropertyName("subtypes")]
    public IEnumerable<string> Subtyeps { get; set; }

    [JsonPropertyName("level")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Level { get; set; }

    [JsonPropertyName("hp")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int Hp { get; set; }

    [JsonPropertyName("types")]
    public List<string> Types { get; set; }

    [JsonPropertyName("evolvesFrom")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string EvolvesFrom { get; set; }

    [JsonPropertyName("evolvesTo")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string EvolvesTo { get; set; }

    [JsonPropertyName("rules")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<string> Rules { get; set; }

    [JsonPropertyName("ancientTrait")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public AncientTrait AncientTrait { get; set; }

    [JsonPropertyName("abilities")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IEnumerable<Ability> Abilities { get; set; }

    [JsonPropertyName("attacks")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IEnumerable<Attack> Attacks { get; set; }

    [JsonPropertyName("weaknesses")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IEnumerable<TypeValue> Weaknesses { get; set; }

    [JsonPropertyName("resistances")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IEnumerable<TypeValue> Resistances { get; set; }

    [JsonPropertyName("retreatCost")]
    public IEnumerable<string>? RetreatCost { get; set; }

    [JsonPropertyName("convertedRetreatCost")]
    public int ConvertedRetreatCost { get; set; }

    [JsonPropertyName("set")]
    public Set Set { get; set; }

    [JsonPropertyName("number")]
    public string Number { get; set; }

    [JsonPropertyName("artist")]
    public string Artist { get; set; }

    [JsonPropertyName("rarity")]
    public string Rarity { get; set; }

    [JsonPropertyName("flavorText")]
    public string FlavorText { get; set; }

    [JsonPropertyName("nationalPokedexNumbers")]
    public List<int> NationalPokedexNumbers { get; set; }
    
    [JsonPropertyName("legalities")]
    public Legalities legalities { get; set; }

    [JsonPropertyName("regulationMark")]
    public string RegulationMark { get; set; }

    [JsonPropertyName("images")]
    public CardImage Images { get; set; }

    [JsonPropertyName("tcgplayer")]
    public TcgPlayer Tcgplayer { get; set; }

    [JsonPropertyName("cardmarket")]
    public CardMarket Cardmarket { get; set; }
}
