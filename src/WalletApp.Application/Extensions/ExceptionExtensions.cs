using WalletApp.Domain.Interfaces;
using WalletApp.Domain.Models;

namespace WalletApp.Application.Extensions;

public static class ExceptionExtensions
{
    public static AppResponse CreateWithOneMessage(this AppResponse response, IAppException exception)
    {
        return new AppResponse()
        {
            StatusCode = exception.StatusCode,
            Errors = exception.Errors.Select(x => new AppError(null, x))
        };
    }
}