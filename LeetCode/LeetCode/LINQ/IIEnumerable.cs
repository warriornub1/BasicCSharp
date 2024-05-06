using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LINQ
{
    internal class IIEnumerable
    {
        public IIEnumerable()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<int> querySyntax = from obj in list
                                           where obj > 2
                                           select obj;




            List<Employee> employees = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Tom"},
                new Employee() {Id = 2, Name = "John"}
            };
            IEnumerable<Employee> query = from emp in employees
                                          where emp.Id == 1
                                          select emp;

            foreach (var item in query)
            {
                Console.WriteLine("Id = " + item.Id + " And Name = " + item.Name);
            }
        }

        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
