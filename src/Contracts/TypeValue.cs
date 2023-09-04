using System.Text.Json.Serialization;

namespace Contracts;

public class TypeValue
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("value")]
    public string Value { get; set; }
}
