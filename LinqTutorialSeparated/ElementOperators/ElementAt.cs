using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.ElementOperators;
public sealed class ElementAtExample : ILinqExample
{
    public string Title => "Element - ElementAt";
    public void Run()
    {
        Console.WriteLine(SampleData.Numbers.ElementAt(3));
    }
}
