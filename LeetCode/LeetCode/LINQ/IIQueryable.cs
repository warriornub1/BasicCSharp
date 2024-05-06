using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.LINQ.IIEnumerable;

namespace LeetCode.LINQ
{
    internal class IIQueryable
    {
        public IIQueryable() 
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Tom"},
                new Employee() {Id = 2, Name = "John"}
            };

            IQueryable<Employee> query = employees.AsQueryable()
                                          .Where(x => x.Id == 1);

            foreach( var item in query)
            {
                Console.WriteLine("Id = " + item.Id + " And Name = " + item.Name);
            }
        }
    }

}
