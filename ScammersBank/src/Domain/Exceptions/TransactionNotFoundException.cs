namespace Domain.Exceptions;

public class TransactionNotFoundException : Exception
{
    public TransactionNotFoundException() { }
    public TransactionNotFoundException(string id) : base($"Transaction id \"{id}\" not found") { }
}
