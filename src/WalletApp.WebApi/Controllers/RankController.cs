using System.Net;
using WalletApp.Application.Interfaces;
using WalletApp.Application.Models.Response;
using WalletApp.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WalletApp.WebApi.Controllers;

[ApiController]
[Route("api/v1/ranks")]
[Route("api/ranks")]
public class RankController : ControllerBase
{
    private readonly IRankService _rankService;

    public RankController(IRankService rankService)
    {
        _rankService = rankService;
    }

    [HttpGet]
    [ProducesResponseType(typeof(AppResponse<IEnumerable<RankVm>>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetAllAsync()
    {
        var result = await _rankService.GetAllSync();
        return Ok(result);
    }
}