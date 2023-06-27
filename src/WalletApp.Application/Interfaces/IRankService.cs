using WalletApp.Application.Models.Response;
using WalletApp.Domain.Models;

namespace WalletApp.Application.Interfaces;

public interface IRankService
{
    Task<AppResponse<IEnumerable<RankVm>>> GetAllSync();
}