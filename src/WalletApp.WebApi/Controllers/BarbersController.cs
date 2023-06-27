using System.Net;
using WalletApp.Application.Interfaces;
using WalletApp.Application.Models.Requests;
using WalletApp.Application.Models.Response;
using WalletApp.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WalletApp.WebApi.Controllers;

[ApiController]
[Route("api/v1/barbers")]
[Route("api/barbers")]
public class BarbersController : ControllerBase
{
    private readonly IBarberService _barberService;
    private readonly IPermissionService _permissionService;
    public BarbersController(IBarberService barberService, IPermissionService permissionService)
    {
        _barberService = barberService;
        _permissionService = permissionService;
    }

    [Authorize]
    [HttpPost]
    [ProducesResponseType(typeof(AppResponse), (int)HttpStatusCode.Created)]
    public async Task<IActionResult> CreateAsync([FromForm] CreateBarberVm model)
    {
        if (!_permissionService.CanCreateBarber)
        {
            return Forbid();
        }
        var result = await _barberService.CreateAsync(model);
        return Created("api/v1/barbers", result);
    }

    [HttpGet]
    [ProducesResponseType(typeof(AppResponse<IEnumerable<BarberVm>>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetAllAsync()
    {
        var result = await _barberService.GetAllAsync();
        return Ok(result);
    }
}