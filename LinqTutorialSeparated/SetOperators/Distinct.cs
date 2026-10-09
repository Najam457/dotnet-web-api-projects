using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.SetOperators;
public sealed class DistinctExample : ILinqExample
{
    public string Title => "Set - Distinct";
    public void Run()
    {
        var values = new[]{1,2,2,3,3,4,5};
        foreach(var item in values.Distinct()) Console.WriteLine(item);
    }
}
