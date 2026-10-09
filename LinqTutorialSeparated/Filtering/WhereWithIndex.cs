using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Filtering;
public sealed class WhereWithIndexExample : ILinqExample
{
    public string Title => "Filtering - Where With Index";
    public void Run()
    {
        var result = SampleData.Numbers.Where((number,index) => number <= index);
        foreach (var item in result) Console.WriteLine(item);
    }
}
