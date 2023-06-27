using WalletApp.Domain.Interfaces;

namespace WalletApp.Domain.Settings;

public class GoogleStorageSettings : IStorageSettings
{
    public string BucketName { get; set; } = null!;

    public string ApiKey { get; set; } = null!;

    public string Email { get; set; } = null!;
    
    public string Password { get; set; } = null!;
}