using WalletApp.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WalletApp.Infrastructure.Configurations;

public class BarberConfiguration : IEntityTypeConfiguration<Barber>
{
    public void Configure(EntityTypeBuilder<Barber> builder)
    {
        builder.ToTable("Barbers");

        builder.HasOne(x => x.Rank)
            .WithMany(x => x.Barbers)
            .HasForeignKey(x => x.RankId);


        var passwordHasher = new PasswordHasher<Barber>();
        builder.HasData(new Barber
        {
            Id = Guid.Parse("ce4bb7c0-6614-4fdd-b782-5e854ed803e7"),
            UserName = "Максим",
            PhotoUrl = "http://localhost:3000/assets/img/first_barber.jpg",
            Description = "Працюю барбером вже 3 роки",
            RankId = Guid.Parse("17ff6de9-52d0-4eae-94a1-00e18a51939b"),
            NormalizedUserName = "MAKSYM",
            Email = "maksym@gmail.com",
            NormalizedEmail = "MAKSYM@GMAIL.COM",
            EmailConfirmed = true,
            PhoneNumber = "1234567890",
            PhoneNumberConfirmed = true,
            PasswordHash = passwordHasher.HashPassword(null, "password"),
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            SecurityStamp = Guid.NewGuid().ToString(),
            TwoFactorEnabled = false,
            LockoutEnabled = true,
            AccessFailedCount = 0
        }, new Barber
        {
            Id = Guid.Parse("66f07b70-0485-4740-98fb-7b68c9137db6"),
            UserName = "Денис",
            PhotoUrl = "http://localhost:3000/assets/img/second_barber.jpg",
            Description = "Зі мною можна поговорити",
            RankId = Guid.Parse("1c35ff11-df37-4d9c-9077-7ebf6a0d52fb"),
            NormalizedUserName = "DENYS",
            Email = "denys@gmail.com",
            NormalizedEmail = "DENYS@GMAIL.COM",
            EmailConfirmed = true,
            PhoneNumber = "1234567890",
            PhoneNumberConfirmed = true,
            PasswordHash = passwordHasher.HashPassword(null, "password"),
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            SecurityStamp = Guid.NewGuid().ToString(),
            TwoFactorEnabled = false,
            LockoutEnabled = true,
            AccessFailedCount = 0
        }, new Barber
        {
            Id = Guid.Parse("3615f116-6534-4566-a6ef-eace03040563"),
            UserName = "Артур",
            PhotoUrl = "http://localhost:3000/assets/img/third_barber.jpg",
            Description = "Доповню ваш образ гарною зачіскою",
            RankId = Guid.Parse("6eaf3ae3-6b4c-4829-9307-b8552f85d340"),
            NormalizedUserName = "Artur",
            Email = "artur@gmail.com",
            NormalizedEmail = "ARTUR@GMAIL.COM",
            EmailConfirmed = true,
            PhoneNumber = "1234567890",
            PhoneNumberConfirmed = true,
            PasswordHash = passwordHasher.HashPassword(null, "password"),
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            SecurityStamp = Guid.NewGuid().ToString(),
            TwoFactorEnabled = false,
            LockoutEnabled = true,
            AccessFailedCount = 0
        });
    }
}