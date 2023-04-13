namespace Organization.Infrastructure.Utities.Exceptions;

public class CapacityLimitException : Exception
{
    public CapacityLimitException(string message):base(message) { }
}
