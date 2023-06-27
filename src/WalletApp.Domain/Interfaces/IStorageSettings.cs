namespace WalletApp.Domain.Interfaces;

public interface IStorageSettings
{
    string BucketName { get; }
    
    string ApiKey { get; }
    
    string Email { get; set; }
    
    string Password { get; set; }
}