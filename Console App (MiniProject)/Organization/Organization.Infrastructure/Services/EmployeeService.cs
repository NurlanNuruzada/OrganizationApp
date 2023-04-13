using Organization.Core.DBcontex;
using Organization.Core.Entities;
using Organization.Infrastructure.Utities.Exceptions;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace Organization.Infrastructure.Services;

public class EmployeeService : Employee
{
    private static int _count = 0;
    static int index_counter = 0;
    public void AddEmployee(int department_id, string name, string surname, double salary)
    {
        foreach (var department in AppDbContext.Departments)
        {
            if (department is null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new NotFoundIdException("Not Found Department");
            }
            if (department.Id == department_id)
            {
                if (_count < department.DepartmentLimit)
                {
                    department.DepartmentLimit -= _count;
                    _count++;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new CapacityLimitException("Out Of Limit!");
                }
            }
        }
        foreach (var department in AppDbContext.Departments)
        {
            if (department.Id == department_id)
            {
                break;
            }
        }
        name.Trim();
        surname.Trim();
        int IsNum;

        if (int.TryParse(surname, out IsNum))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new NameToNumException("surname Cann't be Number!");
        }
        if (string.IsNullOrWhiteSpace(surname))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new NullParameterException("Employee surname Cann't Be Null!");
        }
        if (salary == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new NullParameterException("Salary Cann't Be Null!");
        }
        if (salary < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new BellowZeroException("Salary Cann't Be Bellow Zero!");
        }
        foreach (var Id in AppDbContext.Departments)
        {
            if (Id.Id == department_id)
            {
                break;
            }
        }
        Employee new_employee = new Employee(department_id, name, surname, salary);
        AppDbContext.Employees[index_counter++] = new_employee;
    }

    public void List()
    {
        bool IsExist = false;
        Console.WriteLine("List Of Employees:");
        for (int i = 0; i < index_counter; i++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(AppDbContext.Employees[i]);
            IsExist = true;
        }
        if (!IsExist)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new NotExistException("There Is No Employee Created with this name!");
        }
    }


    public void GetByName(string NameOrSurname)
    {
        if (String.IsNullOrEmpty(NameOrSurname))
        {
            throw new ArgumentNullException();
        }
        bool isExsist = false;
        string fullname = String.Empty;

        for (int i = 0; i < index_counter; i++)
        {
            fullname = AppDbContext.Employees[i].Name + " " + AppDbContext.Employees[i].SurName;
            if (fullname.ToUpper().Contains(NameOrSurname.ToUpper()))
            {
                isExsist = true;
                Console.WriteLine(AppDbContext.Employees[i]);
            }
        }
        if (!isExsist)
        {
            throw new NotFoundException("Employee " +"Not Found!");
        }
    }
    public void ListEmployeesByDepartmentName(string name)
    {
        bool departmentFound = false;
        foreach (var department in AppDbContext.Departments)
        {
            if (department.Name.ToUpper() == name.ToUpper())
            {
                Console.WriteLine("List Of Employees:");
                foreach (var employee in AppDbContext.Employees)
                {
                    if (employee != null && employee.DepartmentId == department.Id)
                    {
                        Console.WriteLine(employee);
                    }
                }
                departmentFound = true;
                break;
            }
        }
        if (!departmentFound)
        {
            throw new NotExistException("Department could not be found!");
        }
    }

}
