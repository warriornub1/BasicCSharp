using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DataStructures.Searching
{
    internal class Linear_Search
    {
        public Linear_Search()
        {
            int[] searched = new int[] { 84, 21, 45, 96, 15 };

            Console.WriteLine("Starting linear search");
            Console.WriteLine(linersearch(searched, 45));

            Console.WriteLine("Starting BinsarySearch recursion");
            Console.WriteLine(binarySearch(searched, 45, 0, searched.Length));

        }
        public int linersearch(int[] A, int key)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == key)
                    return i;
            }
            return -1;
            /*
            int index = 0;
            while (index < A.Length)
            {
                if (A[index] == key)
                    return index;
                index++;
            }
            return -1;
            */
        }

        public int binarySearch(int[] A, int key, int l, int r)
        {
            if (l > r)
                return -1;

            int mid = (r - l) / 2 + l;
            if (A[mid] == key)
                return mid;
            else if (A[mid] > key)
                return binarySearch(A, key, l, mid - 1);
            else
                return binarySearch(A, key, mid + 1, r);
        }

        public int binarysearch1(int[] A, int key)
        {
            int l = 0;
            int r = A.Length - 1;

            while (l <= r )
            {
                int mid = (r - l ) / 2 + l;
                if (A[mid] == key)
                    return mid;
                else if (key > A[mid])
                    l = mid + 1;
                else
                    r = mid - 1;
            }
            return -1;
        }

    }

}
