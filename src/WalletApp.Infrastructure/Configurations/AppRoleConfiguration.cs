using WalletApp.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WalletApp.Infrastructure.Configurations;

public class AppRoleConfiguration : IEntityTypeConfiguration<IdentityRole<Guid>>
{
    public void Configure(EntityTypeBuilder<IdentityRole<Guid>> builder)
    {
        builder.ToTable("Roles");

        builder.HasData(new List<IdentityRole<Guid>>()
        {
            new()
            {
                Id = Guid.Parse("313f353f-2ac2-4e56-9904-8826767b9c6a"),
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            },
            new()
            {
                Id = Guid.Parse("7b47b6c2-dd7c-4054-93a3-13764fafb71a"),
                Name = "Barber",
                NormalizedName = "BARBER",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            }
        });
    }
}