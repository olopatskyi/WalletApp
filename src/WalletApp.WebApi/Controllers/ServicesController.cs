using WalletApp.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WalletApp.WebApi.Controllers;

[ApiController]
[Route("api/v1/services")]
public class ServicesController : ControllerBase
{
    private readonly IServiceEntityService _service;

    public ServicesController(IServiceEntityService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var result = await _service.GetAllAsync();
        return Ok(result);
    }
}