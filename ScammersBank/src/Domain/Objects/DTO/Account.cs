using Domain.Objects.Entity;

namespace Domain.Objects.DTO;

public class Account
{
    public int Id { get; set; } = default;
    public string Type { get; set; } = string.Empty;
    public decimal Balance { get; set; } = default;
    public int HolderId { get; set; } = default;
    public bool IsClosed { get; set; } = false;

    public Account() { }
    public Account(AccountEntity entity)
    {
        Id = entity.Id;
        Type = entity.Type.ToString();
        Balance = entity.Balance;
        HolderId = entity.HolderId;
        IsClosed = entity.IsClosed;
    }
}
