using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_T4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * «Морской бой» — вывести на экран массив 10х10, состоящий из символов X и O, 
            * где Х — элементы кораблей, а О — свободные клетки.
            */
            
            var SeeFight = new char[10, 10]

            {
                { 'O','O','O','O','O','O','O','O','O','O' },
                { 'O','O','O','O','O','O','O','O','O','O' },
                { 'O','O','O','X','O','O','X','O','O','O' },
                { 'O','O','O','O','X','X','O','O','O','O' },
                { 'O','O','O','O','X','X','O','O','O','O' },
                { 'O','O','O','X','O','O','X','O','O','O' },
                { 'O','O','O','O','O','O','O','O','O','O' },
                { 'O','O','O','O','O','O','O','O','O','O' },
                { 'O','O','O','O','O','O','O','O','O','O' },
                { 'O','O','O','O','O','O','O','O','O','O' },
            };


            for (int i = 0; i < SeeFight.GetLength(0); i++)
            {
                for (int j = 0; j < SeeFight.GetLength(1); j++)
                {
                    Console.Write($"{SeeFight[i, j]}  ");
                }
               
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
