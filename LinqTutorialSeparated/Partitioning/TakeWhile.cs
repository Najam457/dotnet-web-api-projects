using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Partitioning;
public sealed class TakeWhileExample : ILinqExample
{
    public string Title => "Partitioning - TakeWhile";
    public void Run()
    {
        foreach(var item in SampleData.Numbers.TakeWhile(n => n < 6)) Console.WriteLine(item);
    }
}
