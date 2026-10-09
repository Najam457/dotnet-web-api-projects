using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Projection;
public sealed class SelectPropertyExample : ILinqExample
{
    public string Title => "Projection - Select Property";
    public void Run()
    {
        var querySyntax = (from emp in SampleData.Employees select emp.Id.ToString()).ToList();
        var methodSyntax = SampleData.Employees.Select(emp => emp.Id.ToString()).ToList();
        foreach (var item in querySyntax) Console.WriteLine(item);
        Console.WriteLine("------");
        foreach (var item in methodSyntax) Console.WriteLine(item);
    }
}
