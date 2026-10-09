using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Partitioning;
public sealed class TakeExample : ILinqExample
{
    public string Title => "Partitioning - Take";
    public void Run()
    {
        foreach(var item in SampleData.Numbers.Take(4)) Console.WriteLine(item);
    }
}
