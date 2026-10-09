using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Joins;
public sealed class InnerJoinMethodExample : ILinqExample
{
    public string Title => "Join - Inner Join Method";
    public void Run()
    {
        var result = SampleData.Employees.Join(SampleData.Departments,
            emp => emp.DepartmentId, dept => dept.Id,
            (emp,dept) => new { EmployeeName=emp.Name, DepartmentName=dept.Name });
        foreach(var item in result) Console.WriteLine($"{item.EmployeeName} - {item.DepartmentName}");
    }
}
