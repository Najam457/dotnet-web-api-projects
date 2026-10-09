using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.ElementOperators;
public sealed class FirstExample : ILinqExample
{
    public string Title => "Element - First";
    public void Run()
    {
        Console.WriteLine(SampleData.Numbers.First());
    }
}
