using WalletApp.Application.EventHandlers.Booking;
using WalletApp.Application.Interfaces;
using WalletApp.Application.Services;
using WalletApp.Application.Shared;
using WalletApp.Domain.Entities;
using WalletApp.Infrastructure.DataAccess;
using WalletApp.Infrastructure.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace WalletApp.Application.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddIdentity(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddIdentityCore<IdentityUser<Guid>>(x =>
            {
                x.User.AllowedUserNameCharacters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"
                                                         + "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"
                                                         + x.User.AllowedUserNameCharacters;
            })
            .AddRoles<IdentityRole<Guid>>()
            .AddRoleManager<RoleManager<IdentityRole<Guid>>>()
            .AddSignInManager<SignInManager<IdentityUser<Guid>>>()
            .AddEntityFrameworkStores<DatabaseContext>()
            .AddDefaultTokenProviders();
        
        serviceCollection.AddIdentityCore<Barber>()
            .AddRoles<IdentityRole<Guid>>()
            .AddUserManager<UserManager<Barber>>()
            .AddRoleManager<RoleManager<IdentityRole<Guid>>>()
            .AddSignInManager<SignInManager<Barber>>()
            .AddEntityFrameworkStores<DatabaseContext>()
            .AddDefaultTokenProviders();
        
        return serviceCollection;
    }

    public static IServiceCollection AddMapper(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddAutoMapper(typeof(JwtSettings));

        return serviceCollection;
    }
    
    public static IServiceCollection AddServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IBarberService, BarberService>();
        serviceCollection.AddScoped<IRankService, RankService>();
        serviceCollection.AddScoped<AppRoleManager>();
        serviceCollection.AddScoped<IClientService, ClientService>();
        serviceCollection.AddScoped<IServiceEntityService, ServiceEntityService>();
        serviceCollection.AddScoped<IBookingService, BookingService>();
        serviceCollection.AddTransient<IPermissionService, PermissionService>();
        serviceCollection.AddTransient<IAuthService, AuthService>();
        
        return serviceCollection;
    }

    public static IServiceCollection AddObservers(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<BookingObserver>();
        serviceCollection.AddScoped<BookingEventHandler>();

        return serviceCollection;
    }
}