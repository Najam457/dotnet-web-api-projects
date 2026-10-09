using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Sorting;
public sealed class ReverseExample : ILinqExample
{
    public string Title => "Sorting - Reverse";
    public void Run()
    {
        var result = SampleData.Numbers.AsEnumerable().Reverse();
        foreach (var item in result) Console.WriteLine(item);
    }
}
