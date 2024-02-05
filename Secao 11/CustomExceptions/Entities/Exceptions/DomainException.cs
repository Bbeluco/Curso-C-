namespace CustomExceptions;

public class DomainException : ApplicationException
{
    public DomainException(string message) : base(message) {}
}
