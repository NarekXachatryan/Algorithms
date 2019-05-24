using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Selection_Sort
{
    class Program
    {static int[] arr ;
        static Random rand = new Random();
        static int n;
        static void Main(string[] args)
        {
            
           
            n = Convert.ToInt32(Console.ReadLine());
            arr = new int[n];
                           
        }

        public static void RekursiaSelectionSort(int first,int last)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] = rand.Next(0, 100));
                Console.Write("  ");
            }
            Console.WriteLine();
            int min;
            if (first != last)
            {
                 min= arr[first];
            }
            else
            {
                return;
            }
            int j=first;
            for (int i = first+1; i < last; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    j = i;
                }
            }
            int temp = arr[first];
            arr[first] = arr[j];
            arr[j] = temp;
            RekursiaSelectionSort(first + 1, last);
        }      


        public static void SelectionSort()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] = rand.Next(0, 100));
                Console.Write("  ");
            }
            Console.WriteLine();
            int k = 0;
            for (int l = 0; l < n - 1; l++)
            {

                int min = arr[k];

                for (int i = k + 1; i < arr.Length; i++)
                {
                    if (min > arr[i])
                    {

                        int temp = arr[i];
                        arr[i] = arr[k];
                        arr[k] = temp;
                        min = arr[k];
                    }
                }
                k++;
            }
        }
    }
}
