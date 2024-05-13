using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Searching
{
    internal class Linear_Search
    {
        public Linear_Search() 
        {
            int[] searched = new int[] { 84, 21, 45, 96, 15 };

            Console.WriteLine("Starting linear search");
            Console.WriteLine(linersearch(searched, 45) );

            Console.WriteLine("Starting BinsarySearch recursion");
            Console.WriteLine(binarySearch(searched, 45, 0, searched.Length));

        }
        public int linersearch(int[] A, int key)
        {
            int index = 0;
            while (index < A.Length)
            {
                if (A[index] == key)
                    return index;
                index++;
            }
            return -1;
        }

        public int binarySearch(int[] A, int key, int l, int r)
        {
            if (l > r)
                return -1;
            else
            {
                int mid = (l + r) / 2;
                if (A[mid] == key)
                    return mid;
                else if (key < A[mid])
                    return binarySearch(A, key, l, mid - 1);
                else
                    return binarySearch(A, key, mid + 1, r);
            }
            return -1;
        }
    }

}
