using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Filtering;
public sealed class WhereExample : ILinqExample
{
    public string Title => "Filtering - Where";
    public void Run()
    {
        var result = SampleData.Numbers.Where(number => number > 5);
        foreach (var item in result) Console.WriteLine(item);
    }
}
