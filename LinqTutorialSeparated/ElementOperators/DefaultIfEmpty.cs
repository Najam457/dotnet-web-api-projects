using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.ElementOperators;
public sealed class DefaultIfEmptyExample : ILinqExample
{
    public string Title => "Element - DefaultIfEmpty";
    public void Run()
    {
        var empty = new List<int>();
        foreach(var item in empty.DefaultIfEmpty()) Console.WriteLine(item);
    }
}
