using WalletApp.Domain.Entities;

namespace WalletApp.Domain.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IRepository<Client> ClientRepository { get; }
    
    IRepository<Booking> BookingRepository { get; }
    
    IRepository<Rank> RankRepository { get; }

    IRepository<Service> ServiceRepository { get; }

    Task SaveAsync();
}