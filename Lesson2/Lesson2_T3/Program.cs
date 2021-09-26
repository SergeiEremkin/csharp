using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Определить, является ли введённое пользователем число чётным.

            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"Число {number} четное ");
            }
            else
            {
                Console.WriteLine($"Число {number} нечетное");
            }
            Console.ReadLine();
        }
    }
}
