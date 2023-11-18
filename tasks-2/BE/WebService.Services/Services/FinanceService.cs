using System.Text.Json;
using WebService.Api.Responses;
using WebService.Services.Interfaces;

namespace WebService.Services.Services;

public class FinanceService : IFinanceService
{
    private readonly HttpClient _client;

    public FinanceService(HttpClient client)
    {
        _client = client;
    }

    public async Task<BinListResponse> GetAsync()
    {

        var request = new HttpRequestMessage(HttpMethod.Get, "https://lookup.binlist.net/45717360");

        var response = await _client.SendAsync(request);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
    
        var result = JsonSerializer.Deserialize<BinListResponse>(content);

        return result;
    }
}