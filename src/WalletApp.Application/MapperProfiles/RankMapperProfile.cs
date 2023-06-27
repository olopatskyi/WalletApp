using AutoMapper;
using WalletApp.Application.Models.Response;
using WalletApp.Domain.Entities;

namespace WalletApp.Application.MapperProfiles;

public class RankMapperProfile : Profile
{
    public RankMapperProfile()
    {
        CreateMap<Rank, RankVm>(MemberList.None)
            .AfterMap((src, dest) =>
            {
                dest.Id = src.Id.ToString();
                dest.Status = src.Status.ToString();
            });
    }
}