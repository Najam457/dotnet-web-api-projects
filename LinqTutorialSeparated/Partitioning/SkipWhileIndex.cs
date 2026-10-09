using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Partitioning;
public sealed class SkipWhileIndexExample : ILinqExample
{
    public string Title => "Partitioning - SkipWhile Index";
    public void Run()
    {
        foreach(var item in SampleData.Numbers.SkipWhile((n,index) => n > index)) Console.WriteLine(item);
    }
}
