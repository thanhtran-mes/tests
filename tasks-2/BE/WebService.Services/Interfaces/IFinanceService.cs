using WebService.Api.Responses;

namespace WebService.Services.Interfaces;

public interface IFinanceService
{
    Task<BinListResponse> GetAsync();
}