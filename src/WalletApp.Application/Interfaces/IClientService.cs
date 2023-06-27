using WalletApp.Application.Models.Requests;
using WalletApp.Domain.Entities;
using WalletApp.Domain.Models;

namespace WalletApp.Application.Interfaces;

public interface IClientService
{
    Task<AppResponse> CreateAsync(CreateClientVm model);
    
    Task<AppResponse<IEnumerable<Client>>> GetAllAsync();
}