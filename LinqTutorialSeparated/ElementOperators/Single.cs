using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.ElementOperators;
public sealed class SingleExample : ILinqExample
{
    public string Title => "Element - Single";
    public void Run()
    {
        Console.WriteLine(SampleData.Numbers.Single(n => n == 5));
    }
}
