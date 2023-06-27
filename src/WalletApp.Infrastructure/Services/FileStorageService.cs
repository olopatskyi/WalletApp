using System.Text.Json;
using WalletApp.Domain.Interfaces;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;

namespace WalletApp.Infrastructure.Services;

public class FileStorageService : IStorageService
{
    private readonly IStorageSettings _storageSettings;
    private readonly GoogleCredential _credential;
    private readonly StorageClient _storageClient;

    public FileStorageService(IStorageSettings storageSettings, GoogleCredential credential, StorageClient client, StorageClient storageClient)
    {
        _storageSettings = storageSettings;
        _credential = credential;
        _storageClient = storageClient;
    }

    public async Task<string> UploadOneAsync(Stream imageStream, string fileName, string contentType)
    {
        await _storageClient.UploadObjectAsync(
            bucket: _storageSettings.BucketName,
            objectName: fileName,
            contentType: contentType,
            source: imageStream
        );
        
        var signer = UrlSigner.FromCredential(_credential);
        var url = await signer.SignAsync(_storageSettings.BucketName, fileName, TimeSpan.FromDays(7),
            HttpMethod.Get);
        
        return url;
    }
}
