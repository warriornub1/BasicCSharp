using LeetCode.LINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DataStructures.Sorting
{
    internal class MergeSort
    {
        public MergeSort() 
        {
            Console.WriteLine();
            Console.WriteLine("Merge Sort");
            Console.WriteLine("--------------------------------");

            int[] l1 = new int[] { 84, 21, 45, 96, 15 };
            int[] result = mergeSort(l1);
            Console.WriteLine(string.Join(", ", result));
        }

        public int[] mergeSort(int[] arr)
        {
            if(arr.Length <= 1) 
                return arr;

            int mid = arr.Length / 2;
            int[] left = new ArraySegment<int>(arr, 0, mid).ToArray();
            int[] right = new ArraySegment<int>(arr, mid, arr.Length - mid).ToArray();

            left = mergeSort(left);
            right = mergeSort(right);

            return merge(left, right);
        }

        public int[] merge(int[] l1, int[] l2)
        {
            int[] res = new int[l1.Length + l2.Length];
            int i = 0;
            int k = 0;
            int j = 0;
            while (i < l1.Length && k < l2.Length) 
            {
                if (l1[i] < l2[k])
                    res[j++] = l1[i++];
                else
                    res[j++] = l2[k++];
            }

            while(i < l1.Length)
            {
                res[j++] = l1[i++];
            }

            while(k < l2.Length)
            {
                res[j++] = l2[k++];
            }

            return res;

        }
    }
}
