using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0._SQL
{
    internal class CustomerReferee
    {

        public CustomerReferee() 
        {
            List<Customer> customers = new List<Customer>
        {
            new Customer(1, "Will", null),
            new Customer(2, "Jane", null),
            new Customer(3, "Alex", 2),
            new Customer(4, "Bill", null),
            new Customer(5, "Zack", 1),
            new Customer(6, "mark", 2),
        };

            string[] names = customers.Where(x => x.referee_id != 2)
                                          .Select(x => x.name)
                                          .ToArray();

            var names1 = from c in customers
                             where c.referee_id != 2
                             select c.name;

            Console.WriteLine("Customer Referee");
            Console.WriteLine("----------------");
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine(string.Join(", ", names1));

        }

    }

    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? referee_id { get; set; }

        public Customer(int id, string name, int? referee_id)
        {
            this.id = id;
            this.name = name;
            this.referee_id = referee_id;
        }
    }
}
