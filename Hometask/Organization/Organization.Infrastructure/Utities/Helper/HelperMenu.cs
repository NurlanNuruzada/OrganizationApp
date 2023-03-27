
using Organization.Infrastructure.Utities.Exceptions;

namespace Organization.Infrastructure.Utities.Helper;

public static class HelperMenu
{
    public static int input_parse;
    public enum Menu
    {
        Exit = 0,
        AddCompany,
        ListCompany,
        AddDepartment,
        ListDepartment,
        AddEmployee,
        ListEmployees,
        GetAllDepartments,
        GetByEmployeeNameSurname,
        GetEmployeesbyDepartmentName,
            Updatedepartment
    }
    public enum Query { No = 0, Yes }
    public static int Parser(string input)
    {
        if (input == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new ArgumentNullException("Input is Null!");
        }
        bool TryToInt = int.TryParse(input, out input_parse);
        if (!TryToInt)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new FormatException("Please Enter Correct Format!");
        }
        if (input_parse < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new BellowZeroException("Input Cann't be bellow Zero!");
        }
        return input_parse;

    }
    public static int PosParse(string Number)
    {
        int num = Parser(Number);
        if (int.IsPositive(num) == false)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new BellowZeroException("Please enter Positive number");
        }
        return num;
    }
    public static int ParseMenu(string input)
    {
        var LenghtOfMenu = Enum.GetNames(typeof(Menu)).Length;
        Parser(input);
        if (input_parse > LenghtOfMenu)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new OutOfMenuException("Out of Menu Range");
        }
        return input_parse;

    }
    public static DateTime DateCreated { get; set; }

    public static void TimeAndDate(string input)
    {

    }
}