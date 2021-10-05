using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, выводящую элементы двухмерного массива по диагонали.

            var array = new int[5, 5] ;
            int next_string = 0;
            Random ran = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)

                {
                    array[i, j] = ran.Next(6, 9);
                    Console.WriteLine($"{new string(' ', next_string)}{array[i, j]}");
                    next_string++;
                   
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}
