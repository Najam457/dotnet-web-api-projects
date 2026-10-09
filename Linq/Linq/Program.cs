using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // part 3
            /*List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // part 4 & 6
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id=1, Name="John", Email = "john@gmail.com"},
                new Employee(){Id=2, Name="Jane", Email = "john@gmail.com"}

            };
            // select in linq (part 6)
            var basicQuery = (from emp in employees select emp).ToList();
            
            var basicMethod = employees.ToList();
            foreach (var item in basicMethod)
            {
                Console.WriteLine("Id = " + item.Id + " And Name = " + item.Name);
            }

            //operations 
            var basicPropQuery = (from emp in employees select emp.Id).ToList();

            //var basicPropQuery = (from emp in employees select emp.Id+1).ToList();

            //var basicPropQuery = (from emp in employees select emp.Id.ToString().ToList();

            var basicPropMethod = employees.Select(emp => emp.Id).ToList();

            // migrating data from employee to student using linq
            var selectQuery = (from emp in employees select new Student() 
                                { 
                                   StudentId =  emp.Id, 
                                   FullName = emp.Name, 
                                   StEmail = emp.Email 
                                }).ToList();
            var selectMethod = employees.Select(emp => new Student() 
                                { 
                                   StudentId =  emp.Id, 
                                   FullName = emp.Name, 
                                   StEmail = emp.Email 
                                }).ToList();
            // for using selectQuery replace with selectMethod in the below foreach loop
            foreach (var item in selectMethod)
            {
                Console.WriteLine("Id = " + item.StudentId +  " Name = "  + item.FullName + "Email = " + item.StEmail );
            }
            // get data with index using select in linq
            var query = employees.Select((emp, index) => new { Index = index, FullName = emp.Name}).ToList();*/

            // select many (part 7)

            /*List<string> strList = new List<string>() { "Ahmad", "Ali"};
            // method syntax
            var methodResult = strList.SelectMany(X=>X).ToList();

            // query syntax
            var queryResult = (from rec in strList
                              from ch in rec
                              select ch).ToList();*/
            var dataSource = new List<Employee>()
            {
                new Employee(){Id=1, Name="John", Email = "john@gmail.com", programming = new List<string>(){"C#","Java","Python"}},
                new Employee(){Id=2, Name="Jane", Email = "jane@gmail.com", programming = new List<string>(){"php","JavaScript","Python"}},
                new Employee(){Id=3, Name="Bob", Email = "bob@gmail.com", programming = new List<string>(){"C#","html","Python"}},
                new Employee(){Id=4, Name="Alice", Email = "alice@gmail.com", programming = new List<string>(){"C#","lua","Python"}},
                new Employee(){Id= 5, Name= "Joseph", Email = "joseph@gmail.com", programming = new List<string>(){"Python","XML", "SQL"} },
            };
            // method syntax
            var methodSyntax = dataSource.SelectMany(x => x.programming).ToList();

            Console.ReadLine();

            // query syntax (part 3)
            /*var querySyntax = from obj in numbers where obj > 2 select obj;
            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            
            //method syntax
            Console.WriteLine("Method Syntax");
            //mixed syntax
            var methodSyntax = numbers.Where(obj => obj > 2);
            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Mixed Syntax");
            var mixedSyntax = (from obj in numbers select obj).Max();
            Console.WriteLine("Max Value = " + mixedSyntax);
            Console.ReadLine();
            }*/

            //IEnumerable (To use this I've to comment var querySyntax code) (part 4)
            //IEnumerable<Employee> query = from emp in employees where emp.Id == 1 select emp;

            /*IQueryable<Employee> query1 = employees.AsQueryable().Where(x => x.Id == 1);
            foreach (var item in query1)
            {
                Console.WriteLine("Id = " + item.Id + " And Name = "+ item.Name);
            }
            IEnumerable<int> querySyntax = from obj in numbers where obj > 2 select obj;*/
        }
        
            class Employee
                {
                public int Id { get; set; }
                public string Name { get; set; }
                public string Email { get; set; }
            public List<string> programming { get; set; }
        }
        }
    }

