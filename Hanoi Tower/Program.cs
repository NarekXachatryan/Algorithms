using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTower
{
    class Program
    {
       static System.Collections.Generic.Stack<int> a = new System.Collections.Generic.Stack<int>();
        
        static Stack<int> A = new Stack<int>();
        static Stack<int> B = new Stack<int>();
        static Stack<int> C = new Stack<int>();
        static void Main(string[] args)
        {
            
            for (int i = 25; i > 0; i--)
            {
                A.Push(i);
            }
            HanoiTower(A.Count, A, B, C);
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(  B.Pop()); 
            }
        }


        public static void HanoiTower(int count, Stack<int> A, Stack<int> B, Stack<int> C)
        {
            if (count == 1)
            {
                B.Push(A.Pop());
                return;
            }
            HanoiTower(count - 1, A, C, B);
            B.Push(A.Pop());
            HanoiTower(count - 1, C, B, A);
        }
    }
}
