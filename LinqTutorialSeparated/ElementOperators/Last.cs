using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.ElementOperators;
public sealed class LastExample : ILinqExample
{
    public string Title => "Element - Last";
    public void Run()
    {
        Console.WriteLine(SampleData.Numbers.Last());
    }
}
