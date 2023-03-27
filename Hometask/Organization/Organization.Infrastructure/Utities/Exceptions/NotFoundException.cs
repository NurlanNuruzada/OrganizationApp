namespace Organization.Infrastructure.Utities.Exceptions
{
    public  class NotFoundException:Exception
    {
        public NotFoundException(string mesage):base(mesage) { }
    }
}
