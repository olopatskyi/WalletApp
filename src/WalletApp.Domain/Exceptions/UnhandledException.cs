using WalletApp.Domain.Interfaces;

namespace WalletApp.Domain.Exceptions;

public class UnhandledException : Exception, IAppException
{
    public UnhandledException(IEnumerable<string> errors)
    {
        Errors = errors;
    }

    public int StatusCode => 500;
    
    public IEnumerable<string> Errors { get; }
}