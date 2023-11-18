using System.Text.Json.Serialization;

namespace WebService.Api.Responses;

public class BankResponse
{
    [JsonPropertyName("name")] public string Name { get; set; }
    [JsonPropertyName("url")] public string Url { get; set; }
    [JsonPropertyName("phone")] public string Phone { get; set; }
    [JsonPropertyName("city")] public string City { get; set; }
}