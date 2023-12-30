namespace Domain.Objects.Entity;

// TODO: remove or move elsewhere
public enum TransactionType
{
    Credit = 0,
    Debit
}

public class TransactionEntity
{
    public int Id { get; set; }
    public int? OriginAccountId { get; set; } = null;
    public int? DestinationAccountId { get; set; } = null;
    public decimal Amount { get; set; } = 0m;
    public decimal Fees { get; set; } = 0m;
    public int Type { get; set; }
    public bool IsDeleted { get; set; } = false;
}
