using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.Projection;
public sealed class SelectAnonymousExample : ILinqExample
{
    public string Title => "Projection - Anonymous Type";
    public void Run()
    {
        var query = SampleData.Employees.Select(emp => new
        {
            CustomId = emp.Id, AnonymousName = emp.Name, CustomEmail = emp.Email
        });
        foreach (var item in query) Console.WriteLine($"Id: {item.CustomId}, Name: {item.AnonymousName}, E-mail: {item.CustomEmail}");
    }
}
