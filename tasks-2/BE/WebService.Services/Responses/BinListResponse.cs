using System.Text.Json.Serialization;

namespace WebService.Api.Responses;

public class BinListResponse
{
    [JsonPropertyName("number")] public NumberResponse Number { get; set; }
    [JsonPropertyName("scheme")] public string Scheme { get; set; }
    [JsonPropertyName("type")] public string Type { get; set; }
    [JsonPropertyName("brand")] public string Brand { get; set; }
    [JsonPropertyName("prepaid")] public bool Prepaid { get; set; }
    [JsonPropertyName("country")] public CountryResponse Country { get; set; }
    [JsonPropertyName("bank")] public BankResponse Bank { get; set; }
}