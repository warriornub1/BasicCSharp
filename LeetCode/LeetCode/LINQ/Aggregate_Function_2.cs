using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LINQ
{
    internal class Aggregate_Function_2
    {
        public Aggregate_Function_2()
        {
            Console.WriteLine("Aggregate Function 2");
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> evenNumbers = Numbers.Where(x => x % 2 == 0);

            IEnumerable<int> evenNumbers1 = from num in Numbers
                                            where num % 2 == 0
                                            select num;

            var result5 = Numbers
                .Select((num, index) => new { Number = num, Index = index })
                .Where(x => x.Number % 2 == 0);
                //.Select(x => x.Index);


            foreach (var item in result5)
            {
                Console.WriteLine(item.Number + " - " + item.Index);
            }
        }
    }
}
