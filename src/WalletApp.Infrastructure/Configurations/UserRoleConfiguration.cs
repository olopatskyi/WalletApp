using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WalletApp.Infrastructure.Configurations;

public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
    {
        builder.ToTable("UsersRoles");
        
        builder.HasData(new List<IdentityUserRole<Guid>>()
        {
            new()
            {
                RoleId = Guid.Parse("313f353f-2ac2-4e56-9904-8826767b9c6a"),
                UserId = Guid.Parse("672979c9-d851-4bb7-83b6-a75e906dbefa"),
            },
            new()
            {
                RoleId = Guid.Parse("7b47b6c2-dd7c-4054-93a3-13764fafb71a"),
                UserId = Guid.Parse("ce4bb7c0-6614-4fdd-b782-5e854ed803e7")
            },
            new()
            {
                RoleId = Guid.Parse("7b47b6c2-dd7c-4054-93a3-13764fafb71a"),
                UserId = Guid.Parse("66f07b70-0485-4740-98fb-7b68c9137db6")
            },
            new()
            {
                RoleId = Guid.Parse("7b47b6c2-dd7c-4054-93a3-13764fafb71a"),
                UserId = Guid.Parse("3615f116-6534-4566-a6ef-eace03040563")
            },
        });
    }
}