namespace Organization.Infrastructure.Utities.Exceptions;

public class NotFoundIdException:Exception
{
	public NotFoundIdException(string mesage):base(mesage)
	{ }
}
