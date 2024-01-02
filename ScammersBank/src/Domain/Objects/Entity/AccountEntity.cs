using Domain.Exceptions;
using Domain.Objects.CustomTypes;
using Domain.Objects.DTO;

namespace Domain.Objects.Entity;

public class AccountEntity
{
    public int Id { get; set; } = default;
    public int Type { get; set; } = default;
    public decimal Balance { get; set; } = default;
    public int HolderId { get; set; } = default;
    public bool IsClosed { get; set; } = false;
    public AccountEntity() { }
    public AccountEntity(CreateAccount account)
    {
        Type = (int)GetTypeFromString(account.Type);
        HolderId = account.HolderId;
    }

    public AccountEntity(UpdateAccount account)
    {
        Id = account.Id;
        Type = (int)GetTypeFromString(account.Type);
    }

    public static AccountType GetTypeFromString(string? type)
    {
        if (string.IsNullOrEmpty(type))
        {
            return AccountType.Any;
        }

        return type.ToLower() switch
        {
            "default" => AccountType.Default,
            "savings" => AccountType.Savings,
            _ => throw new InvalidAccountTypeException(type)
        };
    }
}
