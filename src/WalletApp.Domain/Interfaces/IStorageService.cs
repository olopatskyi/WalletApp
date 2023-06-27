namespace WalletApp.Domain.Interfaces;

public interface IStorageService
{
    Task<string> UploadOneAsync(Stream imageStream, string fileName, string contentType);
}