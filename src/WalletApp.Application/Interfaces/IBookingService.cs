using WalletApp.Application.Models.Requests;
using WalletApp.Application.Models.Requests.Booking;
using WalletApp.Application.Models.Response;
using WalletApp.Domain.Models;

namespace WalletApp.Application.Interfaces;

public interface IBookingService
{
    Task<AppResponse<IEnumerable<BookingVm>>> GetAllAsync();

    Task<AppResponse<IEnumerable<BookingVm>>> GetBusyTimes(Guid barberId, BookingDateVm model);
     
    Task<AppResponse<IEnumerable<BookingVm>>> GetBookingsPerDate(BookingDateVm model);

    Task<AppResponse> CreateAsync(CreateBookingVm model);

    Task<AppResponse> UpdateStatusAsync(UpdateBookingStatusVm model);
}