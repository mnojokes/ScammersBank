namespace Domain.Exceptions;

public class AccountNotFoundException : Exception
{
    public AccountNotFoundException() { }
    public AccountNotFoundException(string id) : base($"Account id \"{id}\" not found") { }
}
