using WalletApp.Domain.Entities;

namespace WalletApp.Domain.Specifications;

public abstract class Specification<TEntity> where TEntity : BaseEntity
{
    public abstract bool IsSatisfiedBy(TEntity entity);

    public static Specification<TEntity> operator &(Specification<TEntity> left, Specification<TEntity> right)
    {
        return new AndSpecification<TEntity>(left, right);
    }

    public static Specification<TEntity> operator |(Specification<TEntity> left, Specification<TEntity> right)
    {
        return new OrSpecification<TEntity>(left, right);
    }

    public static Specification<TEntity> operator !(Specification<TEntity> specification)
    {
        return new NotSpecification<TEntity>(specification);
    }
}

public class AndSpecification<TEntity> : Specification<TEntity> where TEntity : BaseEntity
{
    private readonly Specification<TEntity> _left;
    private readonly Specification<TEntity> _right;

    public AndSpecification(Specification<TEntity> left, Specification<TEntity> right)
    {
        _left = left;
        _right = right;
    }

    public override bool IsSatisfiedBy(TEntity entity)
    {
        return _left.IsSatisfiedBy(entity) && _right.IsSatisfiedBy(entity);
    }
}

public class OrSpecification<TEntity> : Specification<TEntity> where TEntity : BaseEntity
{
    private readonly Specification<TEntity> _left;
    private readonly Specification<TEntity> _right;

    public OrSpecification(Specification<TEntity> left, Specification<TEntity> right)
    {
        _left = left;
        _right = right;
    }

    public override bool IsSatisfiedBy(TEntity entity)
    {
        return _left.IsSatisfiedBy(entity) || _right.IsSatisfiedBy(entity);
    }
}

public class NotSpecification<TEntity> : Specification<TEntity> where TEntity : BaseEntity
{
    private readonly Specification<TEntity> _specification;

    public NotSpecification(Specification<TEntity> specification)
    {
        _specification = specification;
    }

    public override bool IsSatisfiedBy(TEntity entity)
    {
        return !_specification.IsSatisfiedBy(entity);
    }
}