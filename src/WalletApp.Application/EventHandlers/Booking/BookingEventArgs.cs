using WalletApp.Application.Models.Requests;

namespace WalletApp.Application.EventHandlers.Booking;

public class BookingEventArgs : EventArgs
{
    public DateTime Time { get; set; }

    public Guid BarberId { get; set; }

    public Guid ServiceId { get; set; }

    public CreateClientVm Client { get; set; } = null!;
}