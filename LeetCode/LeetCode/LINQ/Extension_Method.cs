using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LINQ
{
    public class Extension_Method
    {
        public Extension_Method()
        {
            // Part 2 : Extension Methods
            string strName = "pragim";
            string result = strName.ChangeFirstLetterCase();
            Console.WriteLine(result);

            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //IEnumerable<int> EvenNumbers = Numbers.Where(n => n % 2 == 0);
            IEnumerable<int> EvenNumbers = Enumerable.Where(Numbers, n => n % 2 == 0);
            foreach (int evenNumbers in EvenNumbers)
            {
                Console.WriteLine(evenNumbers);
            }
        }
    }
}
