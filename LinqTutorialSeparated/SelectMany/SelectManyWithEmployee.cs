using LinqTutorialSeparated.Data;
namespace LinqTutorialSeparated.SelectMany;
public sealed class SelectManyWithEmployeeExample : ILinqExample
{
    public string Title => "SelectMany - Result Selector";
    public void Run()
    {
        var result = SampleData.Employees.SelectMany(emp => emp.Programming,
            (employee, skill) => new { employee.Name, Skill = skill });
        foreach (var item in result) Console.WriteLine($"{item.Name} - {item.Skill}");
    }
}
