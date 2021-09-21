using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Написать программу, выводящую в консоль текст: «Привет, % имя пользователя %, сегодня % дата %». 
            Имя пользователя сохранить из консоли в промежуточную переменную. 
            Поставить точку останова и посмотреть значение этой переменной в режиме отладки.
            Запустить исполняемый файл через системный терминал.
            */

            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"\n\bПривет, {name}, сегодня {DateTime.Now}");
            Console.ReadKey();

            /*
            Начинающий произносит число «1», 
            и каждый следующий игрок прибавляет к предыдущему значению единицу.
            Когда число делится на три оно заменяется на fizz, если число делится на пять, 
            то произносится buzz.Числа, делящиеся на три и пять одновременно заменяются на fizz buzz. 
            Сделавший ошибку игрок исключается из игры.
            Типичная партия в fizz buzz выглядит так:
            1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, Fizz Buzz, 16, 17, Fizz, 19, Buzz, Fizz, 22, 23, Fizz, Buzz, 26, Fizz, 28, 29, Fizz Buzz, 31, 32, Fizz, 34, Buzz, Fizz, ...
            */

            for (int i = 1; i<=100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.Write($"\nbuzz fizz");
                }
                else if (i % 3 ==0)
                {
                    Console.Write($"\nfizz");
                }
                else if (i % 5 ==0)
                {
                    Console.Write($"\nbuzz");
                }
                else
                {
                    Console.Write($"\n{i}");
                }
            }
            Console.ReadKey();

        }
    }
}
