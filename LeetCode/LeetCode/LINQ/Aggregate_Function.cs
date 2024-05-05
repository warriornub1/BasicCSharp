using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LINQ
{
    public class Aggregate_Function
    {
        public Aggregate_Function()
        {
            // Part 3: Aggregate Functions
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int result1 = Numbers.Where(x => x % 2 == 0).Min();
            int sum = Numbers.Where(x => x % 2 == 0).Sum();
            double resul = Numbers.Average();

            string[] countries = { "India", "USA", "UK" };
            int length = countries.Min(country => country.Length);
        }
    }
}
