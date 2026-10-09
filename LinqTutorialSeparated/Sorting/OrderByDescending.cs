using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Sorting;
public sealed class OrderByDescendingExample : ILinqExample
{
    public string Title => "Sorting - OrderByDescending";
    public void Run()
    {
        var result = SampleData.Employees.OrderByDescending(emp => emp.Name);
        foreach (var item in result) Console.WriteLine($"{item.DepartmentId} - {item.Name}");
    }
}
