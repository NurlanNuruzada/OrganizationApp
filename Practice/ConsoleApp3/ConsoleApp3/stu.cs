using System.Drawing;

namespace ConsoleApp3;

class student
{
    public string name;
    public string surname;
    public int age;
    public string grade;
    public string id;
    public student()
    {
        Console.WriteLine("contructor");
    }
    public student(string name, string surname, int age):this()
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
    }
    public student(string name, string surname, int age, string grade, string id):this(name,surname,age) 
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


