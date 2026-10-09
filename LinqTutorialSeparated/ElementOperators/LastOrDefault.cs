using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.ElementOperators;
public sealed class LastOrDefaultExample : ILinqExample
{
    public string Title => "Element - LastOrDefault";
    public void Run()
    {
        Console.WriteLine(SampleData.Numbers.LastOrDefault(n => n > 50));
    }
}
