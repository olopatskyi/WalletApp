using WalletApp.Domain.Interfaces;

namespace WalletApp.Domain.Exceptions;

public class ValidationException : Exception, IAppException
{
    public ValidationException(IEnumerable<string> errors)
    {
        Errors = errors;
    }

    public int StatusCode => 400;
    
    public IEnumerable<string> Errors { get; private set; }
}