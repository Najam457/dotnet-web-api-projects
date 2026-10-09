using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Projection;
public sealed class SelectAllExample : ILinqExample
{
    public string Title => "Projection - Select All";
    public void Run()
    {
        var query = (from emp in SampleData.Employees select emp).ToList();
        foreach (var item in query) Console.WriteLine($"Id = {item.Id}, Name = {item.Name}");
    }
}
