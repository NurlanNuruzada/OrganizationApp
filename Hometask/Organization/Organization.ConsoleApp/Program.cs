using Organization.Core.DBcontex;
using Organization.Core.Entities;
using Organization.Infrastructure.Services;
using Organization.Infrastructure.Utities.Exceptions;
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using static Organization.Infrastructure.Utities.Helper.HelperMenu;
using FormatException = System.FormatException;
CompanyService companyService = new CompanyService();
DepartmentService departmentService = new DepartmentService();
EmployeeService employeeService = new EmployeeService();
#region Menu Query
{
main:
    while (true)

    {
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(
            "------------------------OrganizationApp------------------------" +
            "\n     0 ->Exit" +
            "\n     1 ->Create Company" +
            "\n     2 ->List Companies" +
            "\n     3 ->Create Department" +
            "\n     4 ->List Departments" +
            "\n     5 ->Create Employee" +
            "\n     6 ->List Employee" +
            "\n     7 ->Get All Departments by Company ID" +
            "\n     8 ->Get  Employees By NameOrSurname" +
            "\n     9 ->Get Employees by Department NAME" +
            "\n     10 ->update Department's Name and Limit" +
            "\n---------------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Sellect Option : ");
        string? Input = Console.ReadLine();
        Console.Clear();
        int menu;
        try
        {
            ParseMenu(Input);
        }
        catch (OutOfMenuException ex)
        {
            Console.WriteLine(ex.Message);
            goto main;
        }
        catch (BellowZeroException ex)
        {
            Console.WriteLine(ex.Message);
            goto main;
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            goto main;
        }
        bool TryToInt = int.TryParse(Input, out menu);
        switch (menu)
        {
        #endregion
        #region Exit
            case (int)Menu.Exit:
                Environment.Exit(0);
                break;
            #endregion
            #region Add Company
            case (int)Menu.AddCompany:
            company_name:
                Console.ForegroundColor = ConsoleColor.Green;  
                Console.WriteLine("Enter Company Name :");
                string? company_name = Console.ReadLine();
                try
                {  
                    companyService.CreateCompany(company_name);
                    Console.Clear();
                    Console.WriteLine("\nSuccesfully Created!     ");
                }
                catch (NullParameterException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    goto company_name;
                }
                catch (DublicatedNameException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    goto company_name;
                }
                break;
            #endregion
            #region List Company
            case (int)Menu.ListCompany:
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    companyService.List();
                }
                catch (NotExistException ex)
                {
                    Console.WriteLine(ex.Message);
                #region Create Company Query
                QueryCompany:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(
                        "------------------------OrganizationApp------------------------" +
                        "\nDo You Wannt to Create Company?" +
                        "\n0 ->Return Menu" +
                        "\n1 -> Create one" +
                        "\n---------------------------------------------------------------");
                    string? InputQuery = Console.ReadLine();
                    try
                    {
                        PosParse(InputQuery);
                    }
                    catch (NullParameterException exc)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(exc.Message);
                        goto QueryCompany;
                    }
                    catch (Exception exc)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(exc.Message);
                        goto QueryCompany;
                    }
                    switch (Parser(InputQuery))
                    {
                        case (int)Query.No:
                            Console.Clear();
                            goto main;
                        case (int)Query.Yes:
                            Console.Clear();
                            goto company_name;
                        default:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please Enter Correct Format!");
                            goto QueryCompany;
                    }
                }
                break;
            #endregion
            #endregion
            #region AddDepatment
            case (int)Menu.AddDepartment:
            #region  Query Company
            InputQueryCompany:
                try
                {
                    companyService.List();
                    Console.Clear();
                }
                catch (NotExistException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(
                        "------------------------OrganizationApp------------------------" +
                        "\nDo You Wannt to Create Company?" +
                        "\n0 ->Return Menu" +
                        "\n1 -> Create one" +
                        "\n---------------------------------------------------------------");
                    string? InputQueryComp = Console.ReadLine();
                    try
                    {
                        PosParse(InputQueryComp);
                    }
                    catch (NullParameterException exc)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(exc.Message);
                        goto InputQueryCompany;
                    }
                    catch (Exception exc)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(exc.Message);
                        goto InputQueryCompany;
                    }
                    switch (Parser(InputQueryComp))
                    {
                        case (int)Query.No:
                            goto main;
                        case (int)Query.Yes:
                            goto company_name;
                        default:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please Enter Correct Format!");
                            goto InputQueryCompany;
                    }
                }
            #endregion
            DepartmentName:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter Department Name :");
                string? DepartmentName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(DepartmentName))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(("Department Name Cann't Be Null!"));
                    goto DepartmentName;
                }
            Company_id:
                companyService.List();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter Company Id :");
                string? company_id = Console.ReadLine();
                try
                {
                    PosParse(company_id);
                }
                catch (NotFoundIdException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Company_id;

                }
                catch (BellowZeroException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    goto Company_id;
                }
                catch (NullParameterException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    goto Company_id;
                }
                catch (FormatException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    goto Company_id;
                }
            department_limit:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter Department Limit :");

                string? department_limit = Console.ReadLine();
                try
                {
                    PosParse(department_limit);
                }
                catch (BellowZeroException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    goto department_limit;
                }
                catch (NullParameterException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    goto department_limit;
                }
                catch (FormatException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    goto department_limit;
                }
                try
                {
                    departmentService.CreateDepartment(PosParse(company_id),
                    DepartmentName.Trim(),
                    PosParse(department_limit));
                }
                catch (NullParameterException ex)
                {
                    Console.WriteLine((ex.Message));
                    goto Company_id;
                }
                catch (NotFoundIdException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Company_id;
                }
                catch (DublicatedNameException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto main;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Succesfully Created!");
                break;
            #endregion
            #region List Depatments
            case (int)Menu.ListDepartment:
                try
                {
                    departmentService.List();
                }
                catch (NotExistException ex)
                {
                    Console.WriteLine(ex.Message);
                QueryDepartment:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(
                        "------------------------OrganizationApp------------------------" +
                        "\nDo You Wannt to Create Department?" +
                        "\n0 ->Return Menu" +
                        "\n1 -> Create one" +
                        "\n---------------------------------------------------------------");
                    string? InputQuery2 = Console.ReadLine();
                    try
                    {
                        PosParse(InputQuery2);
                    }
                    catch (NullParameterException exc)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(exc.Message);
                        goto QueryDepartment;
                    }
                    catch (Exception exc)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(exc.Message);
                        goto QueryDepartment;
                    }
                    switch (Parser(InputQuery2))
                    {
                        case (int)Query.No:
                            Console.Clear();
                            goto main;
                        case (int)Query.Yes:
                            Console.Clear();
                            goto DepartmentName;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please Enter Correct Format!");
                            goto QueryDepartment;
                    }
                }
                break;
            #endregion
            #region AddEmoloyee
            case (int)Menu.AddEmployee:
            #region Query Create Department
            InputQuery:
                try
                {
                    departmentService.List();
                    Console.Clear();
                }
                catch (NotExistException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(
                        "------------------------OrganizationApp------------------------" +
                        "\nDo You Wannt to Create Department?" +
                        "\n0 ->Return Menu" +
                        "\n1 -> Create one" +
                        "\n---------------------------------------------------------------");
                    string? InputQuery = Console.ReadLine();
                    try
                    {
                        PosParse(InputQuery);
                    }
                    catch (NullParameterException exc)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(exc.Message);
                        goto InputQuery;
                    }
                    catch (Exception exc)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(exc.Message);
                        goto InputQuery;
                    }
                    switch (Parser(InputQuery))
                    {
                        case (int)Query.No:
                            goto main;
                        case (int)Query.Yes:
                            goto InputQueryCompany;
                        default:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please Enter Correct Format!");
                            goto InputQuery;
                    }
                }
            #endregion
            dempartment_id:
                departmentService.List();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter Department Id :");
                string? dempartment_id = Console.ReadLine();
                try
                {
                    int DepParseID = PosParse(dempartment_id);
                }
                catch (BellowZeroException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    goto dempartment_id;
                }
                catch (NullParameterException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    goto dempartment_id;
                }
                catch (FormatException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    goto dempartment_id;
                }
            employee_Name:
                int IsNum;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter Employee Name :");
                string? EmployeeName = Console.ReadLine();
                if (int.TryParse(EmployeeName, out IsNum))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Name Cann't be Number!");
                    goto employee_Name;
                }
                if (string.IsNullOrWhiteSpace(EmployeeName))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Employee Name Cann't Be Null!");
                    goto employee_Name;

                }
            employee_Surname:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter Employee Surname :");
                string? EmployeeSurname = Console.ReadLine();
                if (int.TryParse(EmployeeSurname, out IsNum))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Name Cann't be Number!");
                    goto employee_Surname;
                }
                if (string.IsNullOrWhiteSpace(EmployeeSurname))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(("Employee Name Cann't Be Null!"));
                    goto employee_Surname;

                }
            employee_salary:
                Console.ForegroundColor = ConsoleColor.Green;
                int EmployeeSalary;
                Console.WriteLine("Enter Employee Salary :");
                string? employee_salary = Console.ReadLine();
                try
                {
                    PosParse(employee_salary);
                }
                catch (BellowZeroException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    goto employee_salary;
                }
                catch (NullParameterException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    goto employee_salary;
                }
                catch (FormatException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    goto employee_salary;
                }
                int Salary = PosParse(employee_salary);
                try
                {
                    employeeService.AddEmployee(PosParse(dempartment_id), EmployeeName, EmployeeSurname, Salary);
                }
                catch (NameToNumException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto employee_Name;
                }
                catch (NullParameterException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto employee_Name;
                }
                catch (NotFoundIdException)
                {
                    Console.WriteLine("not found Departmend ID");
                    goto dempartment_id;
                }
                catch (CapacityLimitException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto main;
                }
                Console.WriteLine("Succesfully Added");
                break;
            #endregion
            #region List Employee
            case (int)Menu.ListEmployees:
                try
                {
                    employeeService.List();
                }
                catch (NotExistException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;
            #endregion
            #region GetAllDeaprtmentByID
            case (int)Menu.GetAllDepartments:
            GetALL:
                try
                {
                    companyService.List();
                }
                catch (NotExistException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto main;
                }
                Console.WriteLine("Insert ID");
                string Id = Console.ReadLine();
                try
                {
                    departmentService.GetAllByCompanyID(Id);
                    goto main;
                }
                catch (BellowZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto GetALL;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto GetALL;
                }
                catch (NullParameterException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto GetALL;
                }
                catch (NotExistException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto main;
                }
                break;
            #endregion
            #region GetByname
            case (int)Menu.GetByEmployeeNameSurname:
                Console.WriteLine("Enter nameOrSurname:");
                string? nameOrSurname = Console.ReadLine();
                try
                {
                    employeeService.GetByName(nameOrSurname);
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (NotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;
            #endregion
            #region GetEmployeesbyDepartmentName
            case (int)Menu.GetEmployeesbyDepartmentName:
                try
                {
                    departmentService.GetNames();
                }
                catch (NotExistException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto main;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter Department Name:");
                string? departmentName = Console.ReadLine();
                try
                {
                    employeeService.ListEmployeesByDepartmentName(departmentName);
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto main;
                }
                catch (NotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto main;
                }
                catch (NotExistException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto main;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;
            #endregion
            #region Updatedepartment
            case (int)Menu.Updatedepartment:
                try
                {
                    companyService.List();
                }
                catch (NotExistException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto main;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Insert ID");
                string? ComapanyId = Console.ReadLine();
                try
                {
                    departmentService.GetAllByCompanyID(ComapanyId);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto main;
                }
                OldName:
                Console.WriteLine("Enter Old Department Name:");
                string DepartmnetOldName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(DepartmnetOldName))
                {
                    Console.WriteLine("Department Name Cann't Be Null!");
                    goto OldName;
                }
                NewDepartment:
                Console.WriteLine("Enter New Department name:");
                string DepartmnetNewName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(DepartmnetNewName))
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Department Name Cann't Be Null!");
                    goto NewDepartment;
                }
                NewDepLimit:
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine("Enter New Department Limit:");
                string? DepartmnetNewLimit = (Console.ReadLine());
                if (string.IsNullOrWhiteSpace(DepartmnetNewLimit))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine("Department limit Cann't Be Null!");
                    goto NewDepLimit;
                }
                    try
                    {
                        PosParse(DepartmnetNewLimit);
                    }
                    catch (NullParameterException exc)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(exc.Message);
                        goto NewDepLimit;
                    }
                    catch (Exception exc)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(exc.Message);
                        goto NewDepLimit;
                    }
                try
                {
                    departmentService.Updade(DepartmnetOldName, DepartmnetNewName, PosParse(DepartmnetNewLimit));
                }
                catch (NotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto main;
                }
                catch (NullParameterException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto main;
                }
                catch (BellowZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto NewDepLimit;
                }
                catch (CapacityLimitException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    goto NewDepLimit;
                }
                catch (Exception ex)
                {
                    goto main;
                }
                break;
            default:
                break;
        }
    }
}
#endregion
     