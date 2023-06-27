using AutoMapper;
using WalletApp.Application.Models.Requests;
using WalletApp.Application.Models.Response;
using WalletApp.Domain.Entities;

namespace WalletApp.Application.MapperProfiles;

public class BarberMappingProfile : Profile
{
    public BarberMappingProfile()
    {
        CreateMap<CreateBarberVm, Barber>(MemberList.Destination);

        CreateMap<Barber, BarberVm>(MemberList.None)
            .AfterMap((src, dest) =>
            {
                if (src.Rank != null)
                {
                    dest.Rank.Id = null;
                    dest.FirstName = src.UserName!;
                    dest.Rank.Status = src.Rank.Status.ToString();
                    dest.Rank.Coefficient = src.Rank.Coefficient;
                }
            });
    }
}