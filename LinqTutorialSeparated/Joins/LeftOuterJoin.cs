using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Joins;
public sealed class LeftOuterJoinExample : ILinqExample
{
    public string Title => "Join - Left Outer Join";
    public void Run()
    {
        var result = from dept in SampleData.Departments
                     join emp in SampleData.Employees on dept.Id equals emp.DepartmentId into employeeGroup
                     from emp in employeeGroup.DefaultIfEmpty()
                     select new { Department=dept.Name, Employee=emp?.Name ?? "No employee" };
        foreach(var item in result) Console.WriteLine($"{item.Department} - {item.Employee}");
    }
}
