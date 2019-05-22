using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] = rand.Next(0, 100));
                Console.Write("\t");
            }
            Console.WriteLine();
            MergeSort.Merge(arr);
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]);
                Console.Write("\t");
            }
        }
    }
}


