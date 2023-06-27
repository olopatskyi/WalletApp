using WalletApp.Domain.Entities;
using WalletApp.Domain.Interfaces;
using WalletApp.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace WalletApp.Infrastructure.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly IRepository<Client> _clientRepository;
    private readonly IRepository<Booking> _bookingRepository;
    private readonly IRepository<Rank> _rankRepository;
    private readonly IRepository<Service> _serviceRepository;

    private readonly DatabaseContext _databaseContext;

    public UnitOfWork(DatabaseContext databaseContext, IRepository<Client> clientRepository,
        IRepository<Booking> bookingRepository, IRepository<Rank> rankRepository, IRepository<Service> serviceRepository)
    {
        _databaseContext = databaseContext;
        _clientRepository = clientRepository;
        _bookingRepository = bookingRepository;
        _rankRepository = rankRepository;
        _serviceRepository = serviceRepository;
    }

    public IRepository<Client> ClientRepository => _clientRepository ?? new Repository<Client>(_databaseContext);

    public IRepository<Booking> BookingRepository => _bookingRepository ?? new Repository<Booking>(_databaseContext);

    public IRepository<Rank> RankRepository => _rankRepository ?? new Repository<Rank>(_databaseContext);
    
    public IRepository<Service> ServiceRepository => _serviceRepository ?? new Repository<Service>(_databaseContext);

    public async Task SaveAsync()
    {
        await _databaseContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            _databaseContext.Dispose();
        }
    }
}