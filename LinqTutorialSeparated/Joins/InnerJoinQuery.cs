using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Joins;
public sealed class InnerJoinQueryExample : ILinqExample
{
    public string Title => "Join - Inner Join Query";
    public void Run()
    {
        var result = from emp in SampleData.Employees
                     join dept in SampleData.Departments on emp.DepartmentId equals dept.Id
                     select new { EmployeeName=emp.Name, DepartmentName=dept.Name };
        foreach(var item in result) Console.WriteLine($"{item.EmployeeName} - {item.DepartmentName}");
    }
}
