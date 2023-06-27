using System.Linq.Expressions;
using WalletApp.Domain.Entities;
using WalletApp.Domain.Models;

namespace WalletApp.Domain.Interfaces;

public interface IRepository<TEntity> where TEntity : BaseEntity
{
    Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression, params string[] includes);

    Task<bool> IsExistsAsync(Expression<Func<TEntity, bool>> expression);

    Task CreateAsync(TEntity entity);
    
    void Delete(TEntity entity);
    
    void Update(TEntity entity);

    Task AddRangeAsync(IEnumerable<TEntity> entities);
    
    Task<IEnumerable<TEntity>> GetAsync();
}