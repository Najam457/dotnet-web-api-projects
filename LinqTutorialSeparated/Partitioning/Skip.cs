using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Partitioning;
public sealed class SkipExample : ILinqExample
{
    public string Title => "Partitioning - Skip";
    public void Run()
    {
        foreach(var item in SampleData.Numbers.Skip(4)) Console.WriteLine(item);
    }
}
