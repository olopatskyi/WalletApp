using AutoMapper;
using WalletApp.Application.Interfaces;
using WalletApp.Application.Models.Requests;

namespace WalletApp.Application.EventHandlers.Booking;

public class BookingObserver
{
    private readonly IClientService _clientService;
    private readonly IMapper _mapper;

    public BookingObserver(IClientService clientService, IMapper mapper)
    {
        _clientService = clientService;
        _mapper = mapper;
    }

    public async void CreateClient(object sender, BookingEventArgs e)
    {
        await _clientService.CreateAsync(_mapper.Map<CreateClientVm>(e.Client));
    }
}