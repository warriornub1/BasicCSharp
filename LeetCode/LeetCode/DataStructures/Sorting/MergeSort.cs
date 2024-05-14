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
            int[] searched = new int[] { 84, 21, 45, 96, 15 };
            mergesort(searched, 0, searched.Length);
            Console.WriteLine(string.Join(", ", searched));
        }

        public void mergesort(int[] A, int left, int right)
        {
            if(left < right)
            {
                int mid = (right - left) / 2 + left;
                mergesort(A, left, mid);
                mergesort(A, mid + 1, right);
                mergesort(A, left, mid + 1);
                merge(A, left, mid, right);
            }
        }

        public void merge(int[] A, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int k = left;

            int[] B = new int[right + 1];
            while (i <= mid && j <= right)
            {
                if (A[i] < A[j])
                {
                    B[k] = A[i];
                    i++;
                }
                else
                {
                    B[k] = A[j];
                    j++;
                }
            }

            while(i <= mid)
            {
                B[k] = A[i];
                i++;
                k++;
            }
            while (j <= right)
            {
                B[k] = A[j];
                j++;
                k++;
            }
        }
    }
}
