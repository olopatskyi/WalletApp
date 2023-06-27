using WalletApp.Infrastructure.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WalletApp.Infrastructure.Configurations;

public class IdentityRoleClaimsConfiguration : IEntityTypeConfiguration<IdentityRoleClaim<Guid>>
{
    public void Configure(EntityTypeBuilder<IdentityRoleClaim<Guid>> builder)
    {
        builder.HasData(IdentityRoleHelper.GetAdminPermissionsScope());
        builder.HasData(IdentityRoleHelper.GetBarberPermissionScope());
    }
}