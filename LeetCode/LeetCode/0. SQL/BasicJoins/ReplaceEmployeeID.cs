using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0._SQL.BasicJoins
{
    internal class ReplaceEmployeeID
    {
        public ReplaceEmployeeID()
        {
            List<Employees> employees = new List<Employees>
            {
                new Employees(1, "Alice"),
                new Employees(7, "Bob"),
                new Employees(11, "Meir"),
                new Employees(90, "Winston"),
                new Employees(3, "Jonathan"),
            };

            List<EmployeeUNI> employeeUNIs = new List<EmployeeUNI>
            {
                new EmployeeUNI(3, 1),
                new EmployeeUNI(11, 2),
                new EmployeeUNI(90, 3),
            };


            var result = from e in employees
                         join eu in employeeUNIs
                         on e.id equals eu.id
                         into EmployeeGroup
                         from employee in EmployeeGroup.DefaultIfEmpty()
                         select new
                         {

                             unique_id = employee.id == null ? default : employee.id,
                             name = e.name,

                         };




            var result1 = employees
                        .GroupJoin(employeeUNIs,
                                   employee => employee.id,
                                   employeeUni => employeeUni.id,
                                   (employee, employeeGroup) => new { employee, employeeGroup })
                        .SelectMany(
                            x => x.employeeGroup.DefaultIfEmpty(),
                            (x, subEmployeeUni) => new
                            {
                                x.employee.name,
                                unique_id = subEmployeeUni != null ? subEmployeeUni.unique_id : default
                            });



            foreach (var e in result)
            {
                Console.WriteLine($"{e.name}, {e.unique_id}");
            }

            foreach (var e in result)
            {
                Console.WriteLine($"{e.name}, {e.unique_id}");
            }
        }
        
    }

    public class Employees
    {
        public int id { get; set; }
        public string name { get; set; }

        public Employees(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }

    public class EmployeeUNI
    {
        public int id { get; set; }
        public int unique_id { get; set; }

        public EmployeeUNI(int id, int unique_id)
        {
            this.id = id;
            this.unique_id = unique_id;
        }
    }
}
