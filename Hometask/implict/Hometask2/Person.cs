namespace Hometask2;

public class Person
{
    public string mane { get; set; }
    public string surmane { get; set; }
    public int Age { get; set; }

    public static bool operator >(Person p1, Person p2)
    {
        return p1.Age > p2.Age;
    }    public static bool operator <(Person p1, Person p2)
    {
        return p1.Age < p2.Age;
    }
}
