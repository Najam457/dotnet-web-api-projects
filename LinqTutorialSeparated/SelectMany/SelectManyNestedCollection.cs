using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.SelectMany;
public sealed class SelectManyNestedCollectionExample : ILinqExample
{
    public string Title => "SelectMany - Nested Collection";
    public void Run()
    {
        var result = SampleData.Employees.SelectMany(emp => emp.Programming);
        foreach (var item in result) Console.WriteLine(item);
    }
}
