using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.SelectMany;
public sealed class SelectManyQuerySyntaxExample : ILinqExample
{
    public string Title => "SelectMany - Query Syntax";
    public void Run()
    {
        var result = from emp in SampleData.Employees
                     from skill in emp.Programming
                     select skill;
        foreach (var item in result) Console.WriteLine(item);
    }
}
