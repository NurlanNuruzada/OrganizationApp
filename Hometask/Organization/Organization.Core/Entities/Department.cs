using Organization.Core.Interfaces;

namespace Organization.Core.Entities;

public class Department:IEntity
{
    private static int _counter = 0;
    public int Id { get; }
    public int CompanyId { get; set; }
    public string Name { get; set; }
    public int DepartmentLimit { get; set; }
    private Department[] _department;
    public Department()
    {
        Id = _counter++;
    }
    public Department(int companyId,string name, int department_limit) : this()
    {
        Name = name;
        DepartmentLimit = department_limit;
        _department = new Department[_counter + 1];
        CompanyId = companyId;
    }
    public Department(string test)
    {
    }
    public override string ToString()
    {
        return ($"\n-------------------------------DEPARTMENT # {Id + 1}--------------------------------" +
            $"\nCompany Id : {CompanyId}" +
            $"\nDepartment Id : {Id}" +
            $"\nName :{Name}" +
            $"\nDepartment Employee Limit :{DepartmentLimit}" +
            "\n-----------------------------------------------------------------------------");
    }
}
