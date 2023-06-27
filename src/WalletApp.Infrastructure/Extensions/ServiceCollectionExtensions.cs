using WalletApp.Domain.Interfaces;
using WalletApp.Domain.Settings;
using WalletApp.Infrastructure.DataAccess;
using WalletApp.Infrastructure.Repository;
using WalletApp.Infrastructure.Services;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WalletApp.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, Func<DatabaseSettings> connectionConfiguration)
    {
        var conf = connectionConfiguration();

        if (conf is null)
        {
            throw new NullReferenceException(nameof(conf));
        }
        
        var connectionString = $@"Server={conf.Server};Database={conf.Database};User Id={conf.UserId};Password={conf.Password};TrustServerCertificate=true;";
        services.AddDbContext<DatabaseContext>(options =>
        {
            options.UseNpgsql(connectionString);
        });

        return services;
    }
    
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        
        return services;
    }

    public static IServiceCollection AddFilters(this IServiceCollection services)
    {
        return services;
    }

    public static IServiceCollection AddFileStorage(this IServiceCollection services)
    {
        services.AddSingleton<GoogleCredential>(opt =>
        {
            var serviceKeyPath = Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS");
            var credentials = GoogleCredential.FromFile(serviceKeyPath);

            return credentials;
        });

        services.AddScoped<StorageClient>(provider =>
        {
            var credentials = provider.GetRequiredService<GoogleCredential>();

            return StorageClient.Create(credentials);
        });
        
        services.AddScoped<IStorageService, FileStorageService>();
        return services;
    }
}