using System.Text.Json.Serialization;

namespace WebService.Api.Responses;

public class CountryResponse
{
    [JsonPropertyName("numeric")] public string Numeric { get; set; }
    [JsonPropertyName("alpha2")] public string Alpha2 { get; set; }
    [JsonPropertyName("name")] public string Name { get; set; }
    [JsonPropertyName("emoji")] public string Emoji { get; set; }
    [JsonPropertyName("currency")] public string Currency { get; set; }
    [JsonPropertyName("latitude")] public int Latitude { get; set; }
    [JsonPropertyName("longitude")] public int Longitude { get; set; }
}