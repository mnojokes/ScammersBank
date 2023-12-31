using Domain.Objects.CustomTypes;
using Domain.Objects.DTO;
using Domain.Objects.Entity;

namespace Application.Services;

public class TransactionService
{
    public async Task<string> CreateCredit(CreateTransaction transaction)
    {
        return await CreateTransaction(transaction, TransactionType.Credit);
    }

    public async Task<string> CreateDebit(CreateTransaction transaction)
    {
        return await CreateTransaction(transaction, TransactionType.Debit);
    }

    public async Task CreateTransfer(CreateTransfer transfer)
    {
        throw new NotImplementedException();
    }

    public async Task<Transaction> Get(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Transaction>> Get()
    {
        throw new NotImplementedException();
    }

    public async Task<List<Transaction>> GetForUser(int userId, string? type)
    {
        TransactionType t = DetermineType(type);
        throw new NotImplementedException();
    }

    public async Task<List<Transaction>> GetForAccount(int accountId, string? type)
    {
        TransactionType t = DetermineType(type);
        throw new NotImplementedException();
    }
    
    private async Task<string> CreateTransaction(CreateTransaction transaction, TransactionType type)
    {
        throw new NotImplementedException();
    }

    private TransactionType DetermineType(string? typeStr)
    {
        if (string.IsNullOrEmpty(typeStr))
        {
            return TransactionType.Any;
        }
        return typeStr.ToLower() switch
        {
            "credit" => TransactionType.Credit,
            "debit" => TransactionType.Debit,
            _ => throw new InvalidDataException($"Invalid transaction type \"{typeStr}\"")
        };
    }
}
