using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.SelectMany;
public sealed class SelectManyDistinctExample : ILinqExample
{
    public string Title => "SelectMany - Distinct Skills";
    public void Run()
    {
        var result = SampleData.Employees.SelectMany(emp => emp.Programming).Distinct();
        foreach (var item in result) Console.WriteLine(item);
    }
}
