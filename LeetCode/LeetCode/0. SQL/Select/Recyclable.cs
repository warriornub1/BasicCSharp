using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0._SQL
{
    internal class Recyclable
    {
        public Recyclable() 
        {
            List<Product> products = new List<Product>
            {
                new Product(0,  true, false),
                new Product(1,  true, true),
                new Product(2,  false, true),
                new Product(3,  true, true),
                new Product(4,  false, false),
            };

            int[] result = products.Where(p => p.IsLowFat == true && p.IsRecyclable == true)
                                   .Select(p => p.id)
                                   .ToArray();


            IEnumerable<int> result1 = from p in products
                                       where p.IsLowFat == true && p.IsRecyclable == true
                                       select p.id;



            Console.WriteLine(String.Join(", ", result));
            Console.WriteLine(String.Join(", ", result1));

        }
    }
    public class Product
    {
        public int id { get; set; }
        public bool IsRecyclable { get; set; }
        public bool IsLowFat { get; set; }

        public Product(int Id, bool isLowFat, bool isRecyclable)
        {
            id = Id;
            IsRecyclable = isRecyclable;
            IsLowFat = isLowFat;
        }
    }
}
