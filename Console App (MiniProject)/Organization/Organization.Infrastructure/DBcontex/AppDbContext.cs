using Organization.Core.Entities;

namespace Organization.Core.DBcontex;

public class AppDbContext
{
    public static Company[] Companies { get; set; } = new Company[1000000];
    public static Department[] Departments { get; set; } = new Department[100000];
    public static Employee[] Employees { get; set; } = new Employee[1000000];
}
