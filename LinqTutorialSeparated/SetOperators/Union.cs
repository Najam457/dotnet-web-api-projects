using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.SetOperators;
public sealed class UnionExample : ILinqExample
{
    public string Title => "Set - Union";
    public void Run()
    {
        var first = new[]{1,2,3,4,5}; var second = new[]{4,5,6,7};
        foreach(var item in first.Union(second)) Console.WriteLine(item);
    }
}
