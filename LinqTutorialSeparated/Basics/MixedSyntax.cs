using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Basics;
public sealed class MixedSyntaxExample : ILinqExample
{
    public string Title => "Basics - Mixed Syntax";
    public void Run()
    {
        var query = (from number in SampleData.Numbers
                     where number > 5
                     select number).Sum();
        Console.WriteLine(query);
    }
}
