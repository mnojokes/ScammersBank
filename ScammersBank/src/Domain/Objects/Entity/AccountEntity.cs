namespace Domain.Objects.Entity;

// TODO: remove or move elsewhere
public enum AccountType
{
    Default = 0,
    Savings
}

public class AccountEntity
{
    public int Id { get; set; }
    public int Type { get; set; } = 0;
    public decimal Balance { get; set; } = 0m;
    public int HolderId { get; set; }
    public bool IsClosed { get; set; } = false;
}
