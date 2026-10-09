using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Sorting;
public sealed class ThenByDescendingExample : ILinqExample
{
    public string Title => "Sorting - ThenByDescending";
    public void Run()
    {
        var result = SampleData.Employees.OrderBy(emp => emp.DepartmentId).ThenByDescending(emp => emp.Name);
        foreach (var item in result) Console.WriteLine($"{item.DepartmentId} - {item.Name}");
    }
}
