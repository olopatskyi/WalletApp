using WalletApp.Domain.Entities;
using WalletApp.Domain.Models;

namespace WalletApp.Application.Interfaces;

public interface IServiceEntityService
{
    Task<AppResponse<IEnumerable<Service>>> GetAllAsync();
    Task<AppResponse> CreateAsync();
}