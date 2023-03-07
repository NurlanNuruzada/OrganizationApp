namespace ConsoleApp3;

class person:student
{

    public string time;
    public string cats;
    public person()
    {
        Console.WriteLine("contructor");
    }
    public person(string name, string surname, int age) : this()
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
    }
    public person(string name, string surname, int age, string grade, string id) : this(name, surname, age)
    {
        this.grade = grade;
        this.id = id;
    }
    public string About()
    {
        return name + surname + age;
    }
    public string AboutAll()
    {
        return (About() + grade + id);
    }

}
