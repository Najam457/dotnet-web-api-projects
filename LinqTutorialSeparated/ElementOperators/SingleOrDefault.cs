using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.ElementOperators;
public sealed class SingleOrDefaultExample : ILinqExample
{
    public string Title => "Element - SingleOrDefault";
    public void Run()
    {
        Console.WriteLine(SampleData.Numbers.SingleOrDefault(n => n == 50));
    }
}
