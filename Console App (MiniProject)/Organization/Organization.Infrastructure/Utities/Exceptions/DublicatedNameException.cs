namespace Organization.Infrastructure.Utities.Exceptions;
public class DublicatedNameException : Exception
{
    public DublicatedNameException(string mesage) : base(mesage) { }
}
