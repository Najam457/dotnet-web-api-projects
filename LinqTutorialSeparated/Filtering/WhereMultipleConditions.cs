using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Filtering;
public sealed class WhereMultipleConditionsExample : ILinqExample
{
    public string Title => "Filtering - Multiple Conditions";
    public void Run()
    {
        var result = SampleData.Employees.Where(emp => emp.Age > 24 && emp.Name.StartsWith("N"));
        foreach (var item in result) Console.WriteLine($"{item.Name} - {item.Age}");
    }
}
