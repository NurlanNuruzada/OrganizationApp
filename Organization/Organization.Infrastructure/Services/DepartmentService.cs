using Organization.Core.DBcontex;
using Organization.Core.Entities;
using Organization.Infrastructure.Utities.Exceptions;
using System.Xml.Linq;

namespace Organization.Infrastructure.Services;

public class DepartmentService : CompanyService
{

    static int index_counter = 0;
    public void CreateDepartment(int companyId, string Name, int EmployeeLimit)
    {
        foreach (var company in AppDbContext.Companies)
        {
            if (company is null)
            {
                throw new NullParameterException("Not Found Company");
            }
            if (company.Id == companyId)
            {
                break;
            }
        }
        if (Name == null)
        {
            throw new NullParameterException("Department Name Cann't Be Null!");
        }
        bool isExtis = false;
        for (int i = 0; i < index_counter; i++)
        {
            if (AppDbContext.Departments[i].Name.ToUpper() == Name.ToUpper() && companyId == AppDbContext.Companies[i].Id)
            {
                isExtis = true;
                break;
            }
        }
        if (isExtis)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new DublicatedNameException("Dublicated Name In Same Company!");
        }
        Department new_department = new Department((companyId), Name, EmployeeLimit);
        AppDbContext.Departments[index_counter++] = new_department;
    }
    public void List()
    {
        bool IsExist = false;
        Console.WriteLine("List Of Departments:");
        for (int i = 0; i < index_counter; i++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(AppDbContext.Departments[i]);
            IsExist = true;
        }
        if (!IsExist)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new NotExistException("There Is No Department Created!");
        }
    }
    public void GetAllByCompanyID(string CompanyID)
    {
        bool IsExist = false;
        int ID;
        bool TryToInt = int.TryParse(CompanyID, out ID);
        if (!TryToInt)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new FormatException("Please Enter Correct Format!");
        }
        if (ID < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new BellowZeroException("Input Cann't be bellow Zero!");
        }
        Console.WriteLine("List Of Departments:");
        for (int i = 0; i < index_counter; i++)
        {
            String temp_company = String.Empty;
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (AppDbContext.Departments[i].CompanyId == ID)
            {
                temp_company = AppDbContext.Departments[ID].Name;
                Console.WriteLine($"\n BELONGS TO   : {temp_company}");
                Console.WriteLine(AppDbContext.Departments[i]);
                IsExist = true;
            }
        }
        if (!IsExist)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new NotExistException("There Is No Department Created With This ID!");
        }
    }
    public void GetNames()
    {
        int id = 0;
        bool IsExist = false;
        bool isSame = false;
        Console.WriteLine("List Of Departments Name:");
        for (int i = 0; i < index_counter; i++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("DepartmentName:" + AppDbContext.Departments[i].Name + "      id:" + AppDbContext.Departments[i].Id);
            IsExist = true;
        }
        if (!IsExist)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new NotExistException("There Is No Department Created!");
        }

    }
    public void Updade(string OldName, string NewName, int NewLimit)
    {
        bool Found = false;
        int FireEmploye = 0;
        if (OldName == null || NewName == null || NewLimit == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new NullParameterException("Input  Cann't Be Null!");
        }
        for (int i = 0; i < index_counter; i++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (AppDbContext.Departments[i].Name == OldName)
            {
                if (NewLimit < AppDbContext.Departments[i].DepartmentLimit)
                {
                    FireEmploye = AppDbContext.Departments[i].DepartmentLimit - NewLimit;

                    throw new CapacityLimitException("New Limit is Bellow than OldLimit!");
                }
                {
                    AppDbContext.Departments[i].Name = NewName;
                    AppDbContext.Departments[i].DepartmentLimit = NewLimit;
                    Console.WriteLine("Succelfuly Updated!");
                    Found = true;
                }
            }
        }
        if (!Found)
        {
            throw new NotFoundException("Department Not Found!");
        }
    }
}
