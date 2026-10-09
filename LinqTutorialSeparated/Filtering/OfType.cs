using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Filtering;
public sealed class OfTypeExample : ILinqExample
{
    public string Title => "Filtering - OfType";
    public void Run()
    {
        var data = new System.Collections.ArrayList { 1, "Two", 3, "Four", 5 };
        var result = data.OfType<int>();
        foreach (var item in result) Console.WriteLine(item);
    }
}
