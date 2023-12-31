namespace Domain.Objects.Entity;

public class TransactionEntity
{
    public int Id { get; set; }
    public int AccountId { get; set; }
    public int? FromToAccountId { get; set; } = null;
    public int Type { get; set; }
    public decimal Amount { get; set; } = 0m;
    public decimal Fees { get; set; } = 0m;
    public bool IsDeleted { get; set; } = false;
}
