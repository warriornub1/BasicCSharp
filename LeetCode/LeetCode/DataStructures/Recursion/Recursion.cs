using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DataStructures.Recursion
{
    internal class Recursion
    {
        public Recursion(int n)
        {
            Console.WriteLine("Starting calculate iterative");
            calculateiterative(n);
            Console.WriteLine("starting calculate recursive");
            calculaterecursive(n);
        }

        public void calculateiterative(int n)
        {
            while (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                n = n - 1;
            }
        }

        public void calculaterecursive(int n)
        {
            if (n < 0)
            {
                return;
            }
            else
            {
                int k = n * n;
                Console.WriteLine(k);
                calculaterecursive(n - 1);
            }
        }
    }
}
