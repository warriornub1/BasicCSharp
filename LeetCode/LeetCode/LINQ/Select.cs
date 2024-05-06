using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LINQ
{
    public class Select
    {
        public Select()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ Id = 1, Name = "Tom", Email = "tom@gmail.com" },
                new Employee(){ Id = 2, Name = "John", Email = "john@gmail.com" },
                new Employee(){ Id = 3, Name = "Mark", Email = "mark@gmail.com" },
                new Employee(){ Id = 4, Name = "Kim", Email = "kim@gmail.com" },
                new Employee(){ Id = 5, Name = "Adam", Email = "adam@gmail.com" }
            };

            var basicQuery = (from emp in employees
                              select emp).ToList();

            // Same as 
            var basicMethod = employees.ToList();

            // Operations

            // Using LINQ query syntax
            var basicPropQuery = (from emp in employees
                                  select emp.Id.ToString()).ToList();
            // Other using lambda expressions and extension methods
            var basicPropMethod = employees.Select(emp => emp.Id).ToList();

            foreach(var item in basicMethod)
            {
                Console.WriteLine("Id = " + item.Id + " And Name = " + item.Name);
            }


            var selectQuery = (from emp in employees
                               select new Employee()
                               {
                                   Id = emp.Id,
                                   Name = emp.Name,
                                   Email = emp.Email,
                               }).ToList();

            var selectMethod = employees.Select(emp => new
            {
                Id = emp.Id,
                Name = emp.Name,
                Email = emp.Email,
            }).ToList();

            var query = employees.Select((emp, index) => new
            {
                Index = index,
                FullName = emp.Name
            }).ToList();

            foreach (var item in query)
            {
                Console.WriteLine("Id = " + item.Index + " And Name = " + item.FullName);
            }
        }
       
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
