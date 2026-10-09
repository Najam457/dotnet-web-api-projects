using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Basics;
public sealed class IQueryableExample : ILinqExample
{
    public string Title => "Basics - IQueryable";
    public void Run()
    {
        IQueryable<int> query = SampleData.Numbers.AsQueryable().Where(number => number > 5);
        foreach (var item in query) Console.WriteLine(item);
    }
}
