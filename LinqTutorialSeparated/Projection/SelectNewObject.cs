using LinqTutorialSeparated.Data;
using LinqTutorialSeparated.Models;
namespace LinqTutorialSeparated.Projection;
public sealed class SelectNewObjectExample : ILinqExample
{
    public string Title => "Projection - Select New Object";
    public void Run()
    {
        var query = SampleData.Employees.Select(emp => new Student
        {
            StudentId = emp.Id, FullName = emp.Name, StEmail = emp.Email
        }).ToList();
        foreach (var item in query) Console.WriteLine($"Id: {item.StudentId}, Name: {item.FullName}, E-mail: {item.StEmail}");
    }
}
