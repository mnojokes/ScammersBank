namespace Domain.Exceptions;

public class UserNotFoundException : Exception
{
    public UserNotFoundException() { }
    public UserNotFoundException(string id) : base($"User id \"{id}\" not found") { }
}
