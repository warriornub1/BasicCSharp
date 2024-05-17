using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0._SQL.BasicJoins
{
    internal class ProductSales
    {
        public ProductSales() 
        {
            List<Sales> sales = new List<Sales>()
            {
                new Sales() { sale_id = 1, product_id = 100, year = 2008, quantity = 10, price = 5000},
                new Sales() { sale_id = 2, product_id = 100, year = 2009, quantity = 12, price = 5000},
                new Sales() { sale_id = 7, product_id = 200, year = 2011, quantity = 15, price = 9000},
            };

            List<Product> products = new List<Product>()
            {
                new Product() { product_id  = 100, product_name = "Nokia"},
                new Product() { product_id  = 200, product_name = "Apple"},
                new Product() { product_id  = 300, product_name = "Samsung"},
            };

            var result = from s in sales
                         join p in products
                         on s.product_id equals p.product_id
                         select new
                         {
                             product_id = p.product_id,
                             s.year,
                             s.price
                         };

            var result1 = sales.Join(products, 
                                    s => s.product_id, 
                                    p => p.product_id, 
                                    (s, p) => new {p.product_name, s.year, s.price});

        }
    }

    public class Sales
    {
        public int sale_id { get; set; }
        public int product_id { get; set; }
        public int year { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }

    }

    public class Product
    {
        public int product_id { get; set; }
        public string product_name { get; set; }
    }
}
