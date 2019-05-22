using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public static class MergeSort
    {
        public static void Merge(int[] arr)
        {
            int leftsize = arr.Length / 2;
            int rightsize = arr.Length - arr.Length / 2;
            int[] left = new int[leftsize];
            int[] right = new int[rightsize];
            Console.WriteLine();
            for (int i = 0; i < arr.Length / 2; i++)
            {

                left[i] = arr[i];

            }
            Console.WriteLine();
            int k = 0;
            for (int i = arr.Length / 2; i < arr.Length; i++)
            {

                right[k] = arr[i];
                k++;
            }

            if (leftsize > 1)
            {
                Merge(left);
            }


            if (rightsize > 1)
            {
                Merge(right);
            }

            MergeSort(arr, left, right);

        }
        public static void MergeSort(int[] arr, int[] left, int[] right)
        {
            int m = 0;
            int n = 0;
            while (m < left.Length && n < right.Length)
            {
                if (left[m] > right[n])
                {
                    arr[m + n] = right[n];
                    arr[m + n + 1] = left[m];
                    n++;
                }
                else
                {
                    arr[n + m] = left[m];
                    arr[n + m + 1] = right[n];
                    m++;
                }
            }
            if (m + n < arr.Length - 1)
            {
                if (n == right.Length)
                {
                    for (int i = 0; i <= arr.Length - 2 - m - n; i++)
                    {
                        arr[m + n + 1 + i] = right[m + 1 + i];
                    }
                }
                else if (m == right.Length)
                {
                    for (int i = 0; i <= arr.Length - 2 - m - n; i++)
                    {
                        arr[m + n + 1 + i] = right[n + 1 + i];
                    }
                }
            }
        }
    }
}
