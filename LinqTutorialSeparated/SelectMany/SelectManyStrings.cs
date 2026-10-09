using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.SelectMany;
public sealed class SelectManyStringsExample : ILinqExample
{
    public string Title => "SelectMany - Character Collection";
    public void Run()
    {
        var names = new List<string>{"Nitish","Rakesh"};
        var result = names.SelectMany(name => name);
        foreach (var item in result) Console.WriteLine(item);
    }
}
