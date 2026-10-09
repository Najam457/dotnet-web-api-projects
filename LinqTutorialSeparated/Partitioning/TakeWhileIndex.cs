using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Partitioning;
public sealed class TakeWhileIndexExample : ILinqExample
{
    public string Title => "Partitioning - TakeWhile Index";
    public void Run()
    {
        foreach(var item in SampleData.Numbers.TakeWhile((n,index) => n > index)) Console.WriteLine(item);
    }
}
