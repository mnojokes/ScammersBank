namespace Domain.Exceptions;

public class InvalidAccountTypeException : Exception
{
    public InvalidAccountTypeException() { }
    public InvalidAccountTypeException(string type) : base($"Invalid account type \"{type}\" received") { }
}
