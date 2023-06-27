using WalletApp.Application.Interfaces;
using DisciplineSwitcher.Application.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WalletApp.WebApi.Controllers;

[ApiController]
[Route("api/v1/auth")]
public class AuthController : ControllerBase
{
    private readonly IPermissionService _permissionService;
    private readonly IAuthService _authService;

    public AuthController(IPermissionService permissionService, IAuthService authService)
    {
        _permissionService = permissionService;
        _authService = authService;
    }

    [HttpPost("sign-in")]
    public async Task<IActionResult> SignInAsync([FromBody] SignInVm model)
    {
        var result = await _authService.SignInAsync(model);
        return Ok(result);
    }
}