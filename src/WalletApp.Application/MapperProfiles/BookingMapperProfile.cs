using AutoMapper;
using WalletApp.Application.EventHandlers.Booking;
using WalletApp.Application.Models.Requests.Booking;
using WalletApp.Application.Models.Response;
using WalletApp.Domain.Entities;

namespace WalletApp.Application.MapperProfiles;

public class BookingMapperProfile : Profile
{
    public BookingMapperProfile()
    {
        CreateMap<CreateBookingVm, Booking>(MemberList.None);
        
        CreateMap<CreateBookingVm, BookingEventArgs>();

        CreateMap<Booking, BookingVm>(MemberList.Destination);
    }
}