namespace WalletApp.Application.Interfaces;

public interface IPermissionService
{
    bool CanCreateBarber { get; }

    bool CanGetClients { get; }

    bool CanGetBookings { get; }
    
    bool CanUpdateBookingStatus { get; }
}