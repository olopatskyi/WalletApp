using AutoMapper;
using WalletApp.Application.Models.Response;
using WalletApp.Domain.Entities;

namespace WalletApp.Application.MapperProfiles;

public class ServiceMappingProfile : Profile
{
    public ServiceMappingProfile()
    {
        CreateMap<Service, ServiceVm>(MemberList.Destination);
    }
}