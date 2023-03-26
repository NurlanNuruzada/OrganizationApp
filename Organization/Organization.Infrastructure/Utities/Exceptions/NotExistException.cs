namespace Organization.Infrastructure.Utities.Exceptions;

public class NotExistException:Exception
{
    public NotExistException(string message) : base(message) { }
}
