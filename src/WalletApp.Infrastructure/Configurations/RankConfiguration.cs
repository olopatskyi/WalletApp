using WalletApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WalletApp.Infrastructure.Configurations;

public class RankConfiguration : IEntityTypeConfiguration<Rank>
{
    public void Configure(EntityTypeBuilder<Rank> builder)
    {
        builder.ToTable("Ranks");

        builder.HasMany(x => x.Barbers)
            .WithOne(x => x.Rank)
            .HasForeignKey(x => x.RankId);

        builder.HasData(new[]
        {
            new Rank()
            {
                Id = Guid.Parse("17ff6de9-52d0-4eae-94a1-00e18a51939b"),
                Status = RankStatus.Silver,
                Coefficient = 1
            },
            new Rank()
            {
                Id = Guid.Parse("1c35ff11-df37-4d9c-9077-7ebf6a0d52fb"),
                Status = RankStatus.Gold,
                Coefficient = 1.2
            },
            new Rank()
            {
                Id = Guid.Parse("6eaf3ae3-6b4c-4829-9307-b8552f85d340"),
                Status = RankStatus.Platinum,
                Coefficient = 1.4
            }
        });
    }
}