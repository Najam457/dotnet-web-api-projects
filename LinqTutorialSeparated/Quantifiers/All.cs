using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Quantifiers;
public sealed class AllExample : ILinqExample
{
    public string Title => "Quantifier - All";
    public void Run()
    {
        Console.WriteLine(SampleData.Employees.All(emp => emp.Age > 18));
    }
}
