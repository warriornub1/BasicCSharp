using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LINQ
{
    public class Practice1
    {
        public Practice1()
        {
            Console.WriteLine("Question 1");
            int[] data = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var result = from d in data
                         where d % 2 == 0
                         select d;

            var numbers = string.Join(", ", result);
            Console.WriteLine(numbers);


            Console.WriteLine("Question 2");
            int[] data1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var result1 = from d in data1
                          where d > 0
                          where d < 12
                          select d;

            var numbers1 = string.Join(", ", result1);
            Console.WriteLine(numbers1);


            Console.WriteLine("Question 3");
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };
            var result2 = from d in arr1
                          let SqrNo = Math.Pow(d, 2)
                          where SqrNo > 20
                          select new { d, SqrNo };

            foreach(var a in result2)
                Console.WriteLine(a);

            Console.WriteLine("Question 4");
            int[] arr2 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var result3 = from d in arr2
                          group d by d;
                          

            
            foreach( var a in result3)
                Console.WriteLine("Number {0} appears {1} times", a.Key, a.Count() );

        }

    }
}
