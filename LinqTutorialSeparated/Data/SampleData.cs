using LinqTutorialSeparated.Models;
namespace LinqTutorialSeparated.Data;
public static class SampleData
{
    public static List<Employee> Employees => new()
    {
        new() { Id=1, Name="Nitish", Email="nitish@gmail.com", Age=27, DepartmentId=1, Programming=new(){"C#","Java","C++"}},
        new() { Id=2, Name="Rakesh", Email="rakesh@gmail.com", Age=25, DepartmentId=2, Programming=new(){"WCF","SQL","C#"}},
        new() { Id=3, Name="Mohan", Email="mohan@gmail.com", Age=29, DepartmentId=1, Programming=new(){"PHP","Laravel","C#"}},
        new() { Id=4, Name="Sonam", Email="sonam@gmail.com", Age=22, DepartmentId=3, Programming=new(){"Ruby","Java","C++"}},
        new() { Id=5, Name="Shalini", Email="shalini@gmail.com", Age=26, DepartmentId=2, Programming=new(){"SQL","VB.NET","C#"}}
    };
    public static List<Department> Departments => new()
    {
        new(){Id=1,Name="IT"}, new(){Id=2,Name="HR"}, new(){Id=3,Name="Payroll"}, new(){Id=4,Name="Admin"}
    };
    public static List<int> Numbers => new(){1,2,3,4,5,6,7,8,9,10};
}
