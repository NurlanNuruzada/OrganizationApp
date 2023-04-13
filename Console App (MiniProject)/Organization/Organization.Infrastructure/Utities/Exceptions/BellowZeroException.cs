namespace Organization.Infrastructure.Utities.Exceptions;

public class BellowZeroException : Exception
{
    public BellowZeroException(string message) : base(message) { }
}
