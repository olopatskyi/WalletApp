using AutoMapper;
using WalletApp.Application.Models.Requests;
using WalletApp.Application.Models.Response;
using WalletApp.Domain.Entities;

namespace WalletApp.Application.MapperProfiles;

public class ClientMapperProfile : Profile
{
    public ClientMapperProfile()
    {
        CreateMap<CreateClientVm, Client>();

        CreateMap<Client, ClientVm>();
    }   
}