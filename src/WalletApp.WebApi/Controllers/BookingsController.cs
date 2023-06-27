using WalletApp.Application.Interfaces;
using WalletApp.Application.Models.Requests;
using WalletApp.Application.Models.Requests.Booking;
using Microsoft.AspNetCore.Mvc;

namespace WalletApp.WebApi.Controllers;

[ApiController]
[Route("api/v1/bookings")]
[Route("api/bookings")]
public class BookingsController : ControllerBase
{
    private readonly IBookingService _bookingService;
    private readonly IPermissionService _permissionService;
    public BookingsController(IBookingService bookingService, IPermissionService permissionService)
    {
        _bookingService = bookingService;
        _permissionService = permissionService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        if (!_permissionService.CanGetBookings)
        {
            return Forbid();
        }
        
        var result = await _bookingService.GetAllAsync();
        return Ok(result);
    }

    [HttpGet("busy/{barberId}")]
    public async Task<IActionResult> GetBusyTimes(Guid barberId, [FromQuery] BookingDateVm model)
    {
        var result = await _bookingService.GetBusyTimes(barberId, model);
        return Ok(result);
    }
    
    [HttpGet("date")]
    public async Task<IActionResult> GetBookingsPerDate([FromQuery] BookingDateVm model)
    {
        var result = await _bookingService.GetBookingsPerDate(model);
        return Ok(result);
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateBookingVm model)
    {
        var result = await _bookingService.CreateAsync(model);
        return Created("", result);
    }

    [HttpPatch("update")]
    public async Task<IActionResult> UpdateStatusAsync([FromBody] UpdateBookingStatusVm model)
    {
        await _bookingService.UpdateStatusAsync(model);
        return NoContent();
    }
}