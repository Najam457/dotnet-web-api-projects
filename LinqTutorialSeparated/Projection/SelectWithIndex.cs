using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Projection;
public sealed class SelectWithIndexExample : ILinqExample
{
    public string Title => "Projection - Select With Index";
    public void Run()
    {
        var query = SampleData.Employees.Select((emp,index) => new { Index=index, FullName=emp.Name });
        foreach (var item in query) Console.WriteLine($"Index: {item.Index}, Name: {item.FullName}");
    }
}
