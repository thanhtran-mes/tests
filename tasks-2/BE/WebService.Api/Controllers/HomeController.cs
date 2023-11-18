using Microsoft.AspNetCore.Mvc;
using WebService.Services.Interfaces;

namespace WebService.Api.Controllers;

[Route("[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    private readonly IFinanceService _financeService;

    public HomeController(IFinanceService financeService)
    {
        _financeService = financeService;
    }

    [HttpGet]
    public async Task<IActionResult> GetDataAsync()
    {
        var response = await _financeService.GetAsync();
        return Ok(response);
    }
}