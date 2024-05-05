using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LINQ
{
    public class Aggregate_Function_1
    {
        public Aggregate_Function_1()
        {
            string[] countries1 = { "India", "US", "UK", "Canda", "Australia" };

            // Without LINQ
            string result2 = string.Empty;
            for (int i = 0; i < countries1.Length; i++)
            {
                result2 = result2 + countries1[i] + ", ";
            }

            int lastIndex = result2.LastIndexOf(", ");
            result2 = result2.Remove(lastIndex);

            // With LINQ
            string result3 = countries1.Aggregate((a, b) => a + ", " + b);
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result4 = Numbers.Aggregate(10, (a, b) => a * b);
        }

    }
}
