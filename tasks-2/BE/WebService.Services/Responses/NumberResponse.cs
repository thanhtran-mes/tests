using System.Text.Json.Serialization;

namespace WebService.Api.Responses;

public class NumberResponse
{
    [JsonPropertyName("length")] public int Length { get; set; }
    [JsonPropertyName("luhn")] public bool Luhn { get; set; }
}