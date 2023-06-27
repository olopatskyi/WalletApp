namespace WalletApp.Application.EventHandlers.Booking;

public class BookingEventHandler : BaseEventHandler<BookingEventArgs>
{
    private readonly BookingObserver _observer;

    public BookingEventHandler(BookingObserver observer)
    {
        _observer = observer;
        InitializeEvents();
    }

    private void InitializeEvents()
    {
        OnCreate += _observer.CreateClient;
    }
}