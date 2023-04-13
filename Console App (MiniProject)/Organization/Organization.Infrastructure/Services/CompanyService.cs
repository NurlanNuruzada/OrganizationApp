using Organization.Core.DBcontex;
using Organization.Core.Entities;
using Organization.Infrastructure.Utities.Exceptions;
using System;
using System.ComponentModel.Design;

namespace Organization.Infrastructure.Services;
public class CompanyService
{
    protected static int index_counter = 0;
    public void CreateCompany(string? name)
    {

        if (string.IsNullOrWhiteSpace(name))
        {
            throw new NullParameterException("Company Name Cann't Be Null!");
        }
        bool IsExist = false;
        for (int i = 0; i < index_counter; i++)
        {
            if (AppDbContext.Companies[i].Name.ToUpper() == name.ToUpper())
            {
                IsExist = true;
                break;
            }
        }
        if (IsExist)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new DublicatedNameException("This Company Already Exist!");
        }
        Company new_company = new Company(name.Trim());
        AppDbContext.Companies[index_counter++] = new_company;
    }
    public void List()
    {
        bool IsExist = false;
        Console.ForegroundColor= ConsoleColor.Green;
        Console.WriteLine("List Of Companies:");
        for (int i = 0; i < index_counter; i++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(AppDbContext.Companies[i]);
            IsExist = true;
        }
        if (!IsExist)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new NotExistException("There Is No Company Created!");
        }
    }

}
