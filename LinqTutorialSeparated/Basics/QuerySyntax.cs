using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Basics;
public sealed class QuerySyntaxExample : ILinqExample
{
    public string Title => "Basics - Query Syntax";
    public void Run()
    {
        var query = from number in SampleData.Numbers
                    where number > 5
                    select number;
        foreach (var item in query) Console.WriteLine(item);
    }
}
