using WalletApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WalletApp.Infrastructure.Configurations;

public class ServiceConfiguration : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> builder)
    {
        builder.ToTable("Services");

        builder.HasData(new[]
        {
            new Service()
            {
                Id = Guid.NewGuid(),
                Title = "Чоловіча стрижка",
                Price = 200,
                LogoUrl = "http://localhost:3000/assets/icons/struzhka_icon.png"
            },
            new Service()
            {
                Id = Guid.NewGuid(),
                Title = "Стрижка машинкою",
                Price = 150,
                LogoUrl = "http://localhost:3000/assets/icons/machine_icon.png"
            },
            new Service()
            {
                Id = Guid.NewGuid(),
                Title = "Гоління",
                Price = 150,
                LogoUrl = "http://localhost:3000/assets/icons/golinya_icon.png"
            },
            new Service()
            {
                Id = Guid.NewGuid(),
                Title = "Професійна укладка",
                Price = 100,
                LogoUrl = "http://localhost:3000/assets/icons/ukladka_icon.png"
            }
        });
    }
}