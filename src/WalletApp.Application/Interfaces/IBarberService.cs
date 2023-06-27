using WalletApp.Application.Models.Requests;
using WalletApp.Application.Models.Response;
using WalletApp.Domain.Models;

namespace WalletApp.Application.Interfaces;

public interface IBarberService
{
    Task<AppResponse<IEnumerable<BarberVm>>> GetAllAsync();
    
    Task<AppResponse> CreateAsync(CreateBarberVm model);
}