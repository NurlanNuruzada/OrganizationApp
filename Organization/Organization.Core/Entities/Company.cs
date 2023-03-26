using Organization.Core.Interfaces;

namespace Organization.Core.Entities;
public class Company:IEntity
{
    public static int _counter=0;
    public int Id { get; }
    public string Name { get; set; }
    public DateTime DateCreated { get; set; }
    private Company[] _company;
    public Company()
    {
        Id = _counter++;
    }
    public Company(string name) : this()
    {
        Name = name;
        _company = new Company[_counter+1];
        Console.WriteLine(_counter);
        DateCreated= DateTime.Now;
    }

    public override string ToString()
    {
        Console.ForegroundColor= ConsoleColor.Cyan;
        return ($"\n-------------------------------Company # {Id + 1}--------------------------------" +
            $"\nCompanyId : {Id}\nName :{Name}" +
            $"\n--------------------------------------------------------------------------");
    }
    
}
