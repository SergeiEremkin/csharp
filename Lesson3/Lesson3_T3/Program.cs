using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, выводящую введенную пользователем строку в обратном порядке (olleH вместо Hello).

            var Word = "Hello";

            for (int i = Word.Length-1; i >= 0; i--)
            {
                Console.Write(Word[i]);
            }
            Console.ReadLine();
        }
    }
}
