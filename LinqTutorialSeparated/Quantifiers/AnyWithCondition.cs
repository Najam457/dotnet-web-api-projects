using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Quantifiers;
public sealed class AnyWithConditionExample : ILinqExample
{
    public string Title => "Quantifier - Any With Condition";
    public void Run()
    {
        Console.WriteLine(SampleData.Employees.Any(emp => emp.Age < 23));
    }
}
