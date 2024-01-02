using Domain.Objects.CustomTypes;
using Domain.Objects.Entity;

namespace Domain.Objects.DTO;

public class Transaction
{
    public int Id { get; set; } = default;
    public int AccountId { get; set; } = default;
    public string Type { get; set; } = string.Empty;
    public decimal Amount { get; set; } = default;
    public decimal Fees { get; set; } = default;
    public string Notes { get; set; } = string.Empty;

    public Transaction() { }
    public Transaction(TransactionEntity entity)
    {
        Id = entity.Id;
        AccountId = entity.AccountId;
        Type = ((TransactionType)entity.Type).ToString();
        Amount = entity.Amount;
        Fees = entity.Fees;
        Notes = entity.Notes;
    }
}
