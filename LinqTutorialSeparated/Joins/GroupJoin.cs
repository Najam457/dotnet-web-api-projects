using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Joins;
public sealed class GroupJoinExample : ILinqExample
{
    public string Title => "Join - Group Join";
    public void Run()
    {
        var result = SampleData.Departments.GroupJoin(SampleData.Employees,
            dept => dept.Id, emp => emp.DepartmentId,
            (dept, employees) => new { Department=dept.Name, Employees=employees });
        foreach(var group in result)
        {
            Console.WriteLine(group.Department);
            foreach(var emp in group.Employees) Console.WriteLine($"  {emp.Name}");
        }
    }
}
