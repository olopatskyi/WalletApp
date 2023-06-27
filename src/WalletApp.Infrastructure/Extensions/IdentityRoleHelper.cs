using Microsoft.AspNetCore.Identity;

namespace WalletApp.Infrastructure.Extensions;

public static class IdentityRoleHelper
{
    private static int _id = 1;
    
    private static Dictionary<string, string[]> AdminScopes = new()
    {
        { "barber", new[] { "get", "create", "delete", "update" } },
        { "client", new[] { "get", "create", "delete", "update" } },
        { "booking", new[] { "get", "create", "delete", "update" } }
    };

    private static Dictionary<string, string[]> BarberScopes = new()
    {
        { "booking", new[] { "get" } }
    };
    

    internal static IEnumerable<IdentityRoleClaim<Guid>> GetAdminPermissionsScope()
    {
        var roleClaims = new List<IdentityRoleClaim<Guid>>();

        foreach (var entityPermission in AdminScopes)
        {
            var entity = entityPermission.Key;
            var permissions = entityPermission.Value;

            foreach (var permission in permissions)
            {
                var claim = new IdentityRoleClaim<Guid>
                {
                    Id = _id,
                    RoleId = Guid.Parse("313f353f-2ac2-4e56-9904-8826767b9c6a"),
                    ClaimType = $"{permission}:{entity}",
                };

                roleClaims.Add(claim);
                _id++;
            }
        }

        return roleClaims;
    }

    internal static IEnumerable<IdentityRoleClaim<Guid>> GetBarberPermissionScope()
    {
        var roleClaims = new List<IdentityRoleClaim<Guid>>();

        foreach (var entityPermission in BarberScopes)
        {
            var entity = entityPermission.Key;
            var permissions = entityPermission.Value;

            foreach (var permission in permissions)
            {
                var claim = new IdentityRoleClaim<Guid>
                {
                    Id = _id,
                    RoleId = Guid.Parse("7b47b6c2-dd7c-4054-93a3-13764fafb71a"),
                    ClaimType = $"{permission}:{entity}",
                };

                roleClaims.Add(claim);
                _id++;
            }
        }

        return roleClaims;
    }
}