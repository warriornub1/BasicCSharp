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

            int[] result = products.Where(x => x.IsLowFat == true && x.IsRecyclable == true)
                                    .Select(x => x.id)
                                    .ToArray();

            Console.WriteLine(String.Join(", ", result));

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
