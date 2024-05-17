using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1._Hashmap
{
    public class ContainsDuplicate
    {
        public ContainsDuplicate(int[] num)
        {
            HashSet<int> set = new HashSet<int>();
            foreach(int i in num)
            {
                if (set.Contains(i))
                {
                    Console.WriteLine("False");
                    return;
                }
                set.Add(i);
            }
            Console.WriteLine("True");

        }
    }
}
