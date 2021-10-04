using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_T4
{
    class Program
    {
        private static int Fib(int n)
        {
            if (n <= 1) return n;

            if (memF[n] != 0) return memF[n];

            memF[n] = Fib(n - 2) + Fib(n - 1);
            return memF[n];
        }
        private static int[] memF = new int[100];
        static void Main(string[] args)
        {

            /*
            (*) Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом. 
 
            */
            Console.WriteLine(Fib(55));
            Console.ReadLine();

       
    }
    }
}
