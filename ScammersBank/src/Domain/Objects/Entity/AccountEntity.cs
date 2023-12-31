namespace Domain.Objects.Entity;

public class AccountEntity
{
    public int Id { get; set; }
    public int Type { get; set; } = 0;
    public decimal Balance { get; set; } = 0m;
    public int HolderId { get; set; }
    public bool IsClosed { get; set; } = false;
}
