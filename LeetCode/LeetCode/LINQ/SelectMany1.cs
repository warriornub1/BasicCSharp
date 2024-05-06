using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.LINQ.Techs;

namespace LeetCode.LINQ
{
    internal class SelectMany1
    {
        public SelectMany1()
        {
            List<string> strList = new List<string>() { "Whitney", "Mariah" };

            // Result : [0]: W, [1]: h, [2]: i
            var methodResult = strList.SelectMany(x => x).ToList();

            var queryResult = (from rec in strList
                              from ch in rec
                              select ch).ToList();

            //
            // 2 layers
            //
            Console.WriteLine(methodResult);

            var dataSource =new List<Employee1>()
            {
                new Employee1(){ Id = 1, Name = "Tom", Email = "tom@gmail.com", Programming = new List<string>() { "C#", "PHP", "JAVA" } },
                new Employee1(){ Id = 2, Name = "John", Email = "john@gmail.com", Programming = new List<string>() { "LINQ", "C#", "MVC" } },
                new Employee1(){ Id = 3, Name = "Mark", Email = "mark@gmail.com", Programming = new List<string>() { "Python", "VBA", "C++" } }
            };

            var methodSyntax = dataSource.SelectMany(emp => emp.Programming).ToList();

            var querySyntax = (from emp in dataSource
                               from skill in emp.Programming
                               select skill).ToList();

            foreach(var item in methodSyntax)
            {
                Console.WriteLine("Programming - " + item);
            }


            //
            // 3 layers
            //

            Employee2 employee1 = new Employee2
            {
                Id = 1,
                Name = "John Doe",
                Email = "john.doe@example.com",
                Programming = new List<Techs>
                {
                    new Techs { Technology = "C#" },
                    new Techs { Technology = "JavaScript" },
                    new Techs { Technology = "Python" }
                }
            };

            Employee2 employee2 = new Employee2
            {
                Id = 2,
                Name = "Jane Smith",
                Email = "jane.smith@example.com",
                Programming = new List<Techs>
                {
                    new Techs { Technology = "Java" },
                    new Techs { Technology = "C++" },
                    new Techs { Technology = "Ruby" }
                }
            };

            var datasource1 = new List<Employee2>();
            datasource1.Add(employee1);
            datasource1.Add(employee2);

            var methodSyntax1 = datasource1.SelectMany(emp => emp.Programming).ToList();

            var querySyntax1 = (from emp in datasource1
                               from skill in emp.Programming
                               select skill).ToList();

            Console.ReadLine();
        }
    }

    public class Employee1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> Programming { get; set; }
    }

    public class Techs
    {
        public string Technology { get; set; }
    }
    public class Employee2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Techs> Programming { get; set; }
    }

}


