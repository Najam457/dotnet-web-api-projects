using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Sorting;
public sealed class ThenByExample : ILinqExample
{
    public string Title => "Sorting - ThenBy";
    public void Run()
    {
        var result = SampleData.Employees.OrderBy(emp => emp.DepartmentId).ThenBy(emp => emp.Name);
        foreach (var item in result) Console.WriteLine($"{item.DepartmentId} - {item.Name}");
    }
}
