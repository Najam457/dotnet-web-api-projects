using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Quantifiers;
public sealed class AnyExample : ILinqExample
{
    public string Title => "Quantifier - Any";
    public void Run()
    {
        Console.WriteLine(SampleData.Employees.Any());
    }
}
