using Domain.Exceptions;
using Domain.Interfaces;
using Domain.Objects.CustomTypes;
using Domain.Objects.DTO;
using Domain.Objects.Entity;
using System.Text.Json;
using Transaction = Domain.Objects.DTO.Transaction;

namespace Application.Services;

public class TransactionService
{
    private const decimal _transferFee = 1.0m;
    private readonly ITransactionRepository _transactionRepository;
    private readonly IAccountRepository _accountRepository;

    public TransactionService(ITransactionRepository transactionRepository, IAccountRepository accountRepository)
    {
        _transactionRepository = transactionRepository;
        _accountRepository = accountRepository;
    }

    public async Task<string> CreateCredit(CreateTransaction transaction)
    {
        TransactionEntity entity = new TransactionEntity() { AccountId = transaction.AccountId, Amount = transaction.Amount, Fees = _transferFee, Type = (int)TransactionType.Credit };
        int ret = await CreateTransaction(entity);
        return JsonSerializer.Serialize(new { id = ret.ToString() });
    }

    public async Task<string> CreateDebit(CreateTransaction transaction)
    {
        TransactionEntity entity = new TransactionEntity() { AccountId = transaction.AccountId, Amount = -transaction.Amount, Type = (int)TransactionType.Debit };
        int ret = await CreateTransaction(entity);
        return JsonSerializer.Serialize(new { id = ret.ToString() });
    }

    public async Task CreateTransfer(CreateTransfer transfer)
    {
        if (transfer.Amount <= 0.00m)
        {
            throw new InvalidOperationException("Transfer must contain amount > 0");
        }

        bool isOutgoingSuccessful = false;
        if (transfer.FromAccountId != null)
        {
            TransactionEntity entity = new TransactionEntity() { AccountId = (int)transfer.FromAccountId, Amount = transfer.Amount, Fees = _transferFee, Type = (int)TransactionType.Debit };
            isOutgoingSuccessful = await CreateTransaction(entity) != default;
            if (!isOutgoingSuccessful)
            {
                throw new InvalidOperationException("Failed to create transfer Debit transaction");
            }
        }
        if (transfer.ToAccountId != null && isOutgoingSuccessful)
        {
            TransactionEntity entity = new TransactionEntity() { AccountId = (int)transfer.ToAccountId, Amount = transfer.Amount, Type = (int)TransactionType.Credit };
            if (await CreateTransaction(entity) == default)
            {
                throw new InvalidOperationException("Failed to create transfer Credit transaction");
            }
        }
    }

    public async Task<Transaction> Get(int id)
    {
        TransactionEntity entity = await _transactionRepository.Get(id);
        if (entity.Id == default)
        {
            throw new TransactionNotFoundException(id.ToString());
        }
        return new Transaction(entity);
    }

    public async Task<List<Transaction>> Get()
    {
        var ret = await _transactionRepository.Get();
        return ret.Select(e => new Transaction(e)).ToList();
    }

    public async Task<List<Transaction>> GetForUser(int userId, string? type)
    {
        TransactionType t = TransactionEntity.GetTypeFromString(type);
        var ret = await _transactionRepository.GetAllForUser(userId, t);
        return ret.Select(e => new Transaction(e)).ToList();
    }

    public async Task<List<Transaction>> GetForAccount(int accountId, string? type)
    {
        TransactionType t = TransactionEntity.GetTypeFromString(type);
        var ret = await _transactionRepository.GetAllForAccount(accountId, t);
        return ret.Select(e => new Transaction(e)).ToList();
    }

    private async Task<int> CreateTransaction(TransactionEntity transaction)
    {
        AccountEntity acc = await _accountRepository.Get(transaction.AccountId);
        if (acc.IsClosed)
        {
            throw new InvalidOperationException($"Account id \"{transaction.AccountId}\" is closed. Cannot add transaction.");
        }
        int ret = await _transactionRepository.Create(transaction);
        await _accountRepository.AdjustBalance(transaction.AccountId, transaction.Amount - transaction.Fees);
        return ret;
    }
}
