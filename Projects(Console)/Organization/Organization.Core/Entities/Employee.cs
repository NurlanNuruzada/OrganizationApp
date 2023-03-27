using Organization.Core.Interfaces;
using System;

namespace Organization.Core.Entities;
public class Employee : IEntity
{
    private static int _counter=-1;
    public int Id { get; }
    public string Name { get; set; }
    public string SurName { get; set; }
    public double Salary { get; set; }
    public int DepartmentId { get; set; }
    Employee[] _employee;
    public Employee()
    {
        Id = _counter++;
    }
    public Employee(int department_id,string name, string surname, double salary ) : this()
    {
        Name = name;
        SurName = surname;
        Salary = salary;
        DepartmentId = department_id;
        _employee = new Employee[_counter+2];
    }
    public override string ToString()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        return ($"-------------------------------Employee # {Id+1}--------------------------------" +
            $"\nDepartmentId :{DepartmentId}" +
            $"\nEmployeeId : {Id}" +
            $"\nName :{Name}" +
            $"\nSurname :{SurName}" +
            $"\nSalary :{Salary}" +
            $"\n--------------------------------------------------------------------------");
    }

}
