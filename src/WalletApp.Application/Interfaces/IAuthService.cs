using WalletApp.Domain.Models;
using WalletApp.Application.Models.Requests;
using WalletApp.Application.Models.Response;
using DisciplineSwitcher.Application.Models.Requests;

namespace WalletApp.Application.Interfaces;

public interface IAuthService
{
    Task<AppResponse<SignInResponse>> SignInAsync(SignInVm model);
}