using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class Program
    {
        static int[] Arr = new int[5];
        static Random r = new Random();
        static void Main(string args)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = r.Next(-10, 10);
            }
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write(Arr[i] + "    ");
            }
            Console.WriteLine();
            Insertion(0, Arr.Length);

            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write(Arr[i] + "    ");
            }

            for (int i = 0; i < Arr.Length - 1; i++)
            {
                if (Arr[i] > Arr[i + 1])
                {
                    Console.WriteLine("Error");
                    break;
                }
            }
        }
        public static void Insertion(int first, int last)
        {
            while (first != last) 
            {
                Insertion(first, last - 1);
                break;
            }

            int mid = first + (last - first) / 2;

            if (last != Arr.Length)
            {
                if (Arr[last] < Arr[mid])
                {
                    int temp = Arr[last];
                    Arr[last] = Arr[mid];
                    Arr[mid] = temp;
                    Insertion(first, mid);
                }

                else if (Arr[last] > Arr[mid])
                {
                    Insertion(mid + 1, last);
                    
                }
                else if(Arr[last] == Arr[mid] && first != last)
                {
                    int temp = Arr[last];
                    for (int i = last-1; i >=mid+1; i--)
                    {
                       
                        Arr[i + 1] = Arr[i];
                    }
                    Arr[mid + 1] = temp;
                }
            }
        }
    }
}
