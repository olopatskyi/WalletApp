using System.Reflection;
using WalletApp.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WalletApp.Infrastructure.DataAccess;

public class DatabaseContext : IdentityDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    public DbSet<Barber> Barbers { get; set; }
    
    public DbSet<Booking> Bookings { get; set; }
    
    public DbSet<Client> Clients { get; set; }
    
    public DbSet<Rank> Ranks { get; set; }
    
    public DbSet<Service> Service { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(DatabaseContext))!);
        
        base.OnModelCreating(builder);
    }
}