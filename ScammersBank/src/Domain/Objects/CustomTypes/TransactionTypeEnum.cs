namespace Domain.Objects.CustomTypes;

public enum TransactionType
{
    Credit = 0,
    Debit,
    Last = Debit,
    Any
}
