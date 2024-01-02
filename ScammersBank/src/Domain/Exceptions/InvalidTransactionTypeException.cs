namespace Domain.Exceptions;

public class InvalidTransactionTypeException : Exception
{
    public InvalidTransactionTypeException() { }
    public InvalidTransactionTypeException(string type) : base($"Invalid transaction type \"{type}\" received") { }
}
