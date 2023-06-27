using WalletApp.Domain.Interfaces;
using WalletApp.Domain.Models;

namespace WalletApp.Domain.Exceptions;

public class UnauthorizedException : Exception, IAppException
{
    public UnauthorizedException(IEnumerable<string> errors)
    {
        Errors = errors;
    }

    public int StatusCode => 401;
    
    public IEnumerable<string> Errors { get; private set; }
}