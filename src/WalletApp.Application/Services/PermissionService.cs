using WalletApp.Application.Interfaces;
using Microsoft.AspNetCore.Http;

namespace WalletApp.Application.Services;

public class PermissionService : IPermissionService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public PermissionService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public bool CanCreateBarber => HasPermission("create:transaction");

    public bool CanGetClients => HasPermission("get:transaction");

    public bool CanGetBookings => HasPermission("get:booking");

    public bool CanUpdateBookingStatus => HasPermission("update:booking");
    
    private bool HasPermission(string permission)
    {
        var scopes = _httpContextAccessor.HttpContext!.User.Claims
            .Where(c => c.Type == "scopes")
            .SelectMany(c => c.Value.Split(','));

        return scopes.Contains(permission);
    }
}