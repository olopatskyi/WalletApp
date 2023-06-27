namespace WalletApp.Domain.Entities;

public class Card : BaseEntity
{
    private const decimal MaxCardLimit = 1500M;
    
    public Guid UserId { get; set; }

    public AppUser? User { get; set; }
    
    public ICollection<Transaction>? Transactions { get; set; }
}