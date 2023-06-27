using WalletApp.Domain.Entities;

namespace WalletApp.Domain.Interfaces;

public interface ISpecification<TEntity>
{
    bool IsSatisfiedBy(TEntity entity);
}