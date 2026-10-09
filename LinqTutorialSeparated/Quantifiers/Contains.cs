using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Quantifiers;
public sealed class ContainsExample : ILinqExample
{
    public string Title => "Quantifier - Contains";
    public void Run()
    {
        Console.WriteLine(SampleData.Numbers.Contains(5));
    }
}
