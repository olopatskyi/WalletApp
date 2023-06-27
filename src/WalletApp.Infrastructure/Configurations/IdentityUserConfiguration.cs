using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WalletApp.Infrastructure.Configurations;

public class IdentityUserConfiguration : IEntityTypeConfiguration<IdentityUser<Guid>>
{
    public void Configure(EntityTypeBuilder<IdentityUser<Guid>> builder)
    {
        PasswordHasher<IdentityUser<Guid>> hasher = new PasswordHasher<IdentityUser<Guid>>();
        
        builder.HasData(new[]
        {
            new IdentityUser<Guid>()
            {
                Id = Guid.Parse("672979c9-d851-4bb7-83b6-a75e906dbefa"),
                UserName = "Admin",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                PasswordHash = hasher.HashPassword(null, "Admin_1")
            }
        });
    }
}