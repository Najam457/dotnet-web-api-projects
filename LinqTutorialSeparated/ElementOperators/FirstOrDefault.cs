using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.ElementOperators;
public sealed class FirstOrDefaultExample : ILinqExample
{
    public string Title => "Element - FirstOrDefault";
    public void Run()
    {
        Console.WriteLine(SampleData.Numbers.FirstOrDefault(n => n > 50));
    }
}
