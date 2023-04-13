namespace Organization.Infrastructure.Utities.Exceptions;

public class NullParameterException:Exception
{
    public NullParameterException(string message) : base(message) { }
}

