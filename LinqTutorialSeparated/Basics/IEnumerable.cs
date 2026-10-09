using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Basics;
public sealed class IEnumerableExample : ILinqExample
{
    public string Title => "Basics - IEnumerable";
    public void Run()
    {
        IEnumerable<int> query = SampleData.Numbers.Where(number => number > 5);
        foreach (var item in query) Console.WriteLine(item);
    }
}
