namespace WalletApp.Domain.Entities;

public enum Type
{
    Payment,
    Credit
}

public enum Status
{
    Pending,
    Done
}

public class Transaction : BaseEntity
{
    public Type Type { get; set; }

    public decimal Amount { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime Date { get; set; }

    public Guid SenderId { get; set; }

    public Guid ReceiverId { get; set; }
    
    
    //Navigation props
    public AppUser? Sender { get; set; }

    public AppUser? Receiver { get; set; }
}