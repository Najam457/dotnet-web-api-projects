using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.SetOperators;
public sealed class ConcatExample : ILinqExample
{
    public string Title => "Set - Concat";
    public void Run()
    {
        var first = new[]{1,2,3}; var second = new[]{3,4,5};
        foreach(var item in first.Concat(second)) Console.WriteLine(item);
    }
}
