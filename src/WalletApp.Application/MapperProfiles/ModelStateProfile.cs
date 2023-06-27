using AutoMapper;
using WalletApp.Application.MapperProfiles.Convertors;
using WalletApp.Application.Shared;
using WalletApp.Domain.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WalletApp.Application.MapperProfiles;

public class ModelStateProfile : Profile
{
    public ModelStateProfile()
    {
        CreateMap<ModelStateDictionary, AppResponse>()
            .ConvertUsing<ModelStateConverter>();
    }
}