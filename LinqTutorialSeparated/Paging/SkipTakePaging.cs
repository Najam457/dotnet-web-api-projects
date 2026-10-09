using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Paging;
public sealed class SkipTakePagingExample : ILinqExample
{
    public string Title => "Paging - Skip and Take";
    public void Run()
    {
        const int pageNumber = 2; const int pageSize = 3;
        var result = SampleData.Numbers.Skip((pageNumber-1)*pageSize).Take(pageSize);
        foreach(var item in result) Console.WriteLine(item);
    }
}
