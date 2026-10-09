using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Basics;
public sealed class MethodSyntaxExample : ILinqExample
{
    public string Title => "Basics - Method Syntax";
    public void Run()
    {
        var query = SampleData.Numbers.Where(number => number > 5);
        foreach (var item in query) Console.WriteLine(item);
    }
}
