using Microsoft.Extensions.DependencyInjection;
using WebService.Services.Interfaces;
using WebService.Services.Services;

namespace WebService.Services;

public static class ServiceCollectionExtensions
{
    public static void AddApiServices(this IServiceCollection services)
    {
        AddServices(services);
    }

    private static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IFinanceService, FinanceService>();
    }
}