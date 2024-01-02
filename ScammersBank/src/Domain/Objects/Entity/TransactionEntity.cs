using Domain.Exceptions;
using Domain.Objects.CustomTypes;

namespace Domain.Objects.Entity;

public class TransactionEntity
{
    public int Id { get; set; } = default;
    public int AccountId { get; set; } = default;
    public int Type { get; set; } = default;
    public decimal Amount { get; set; } = default;
    public decimal Fees { get; set; } = default;
    public string Notes { get; set; } = string.Empty;
    public bool IsDeleted { get; set; } = false;

    public static TransactionType GetTypeFromString(string? type)
    {
        if (string.IsNullOrEmpty(type))
        {
            return TransactionType.Any;
        }

        return type.ToLower() switch
        {
            "credit" => TransactionType.Credit,
            "debit" => TransactionType.Debit,
            _ => throw new InvalidTransactionTypeException(type)
        };
    }
}
