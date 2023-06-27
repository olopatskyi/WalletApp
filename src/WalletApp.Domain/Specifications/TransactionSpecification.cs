using WalletApp.Domain.Entities;

namespace WalletApp.Domain.Specifications;

public class TransactionSpecification : Specification<Transaction>
{
    private readonly string _name;
    
    public TransactionSpecification(string name)
    {
        _name = name;
    }
    public override bool IsSatisfiedBy(Transaction entity)
    {
        return entity.
    }
}