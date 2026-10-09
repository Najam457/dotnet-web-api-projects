using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.ElementOperators;
public sealed class ElementAtOrDefaultExample : ILinqExample
{
    public string Title => "Element - ElementAtOrDefault";
    public void Run()
    {
        Console.WriteLine(SampleData.Numbers.ElementAtOrDefault(30));
    }
}
