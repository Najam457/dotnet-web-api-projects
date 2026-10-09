using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Partitioning;
public sealed class SkipWhileExample : ILinqExample
{
    public string Title => "Partitioning - SkipWhile";
    public void Run()
    {
        foreach(var item in SampleData.Numbers.SkipWhile(n => n < 6)) Console.WriteLine(item);
    }
}
