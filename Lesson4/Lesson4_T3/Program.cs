using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_T3
{
    class Program
    {
        enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Automn,
        }
        public static void DetermineTheSeasonByMonthNumber(int monthNumber)
        {
                switch (monthNumber)
                {
                    case 12:
                    case 1:
                    case 2:
                        Console.WriteLine(Seasons.Winter);
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine(Seasons.Spring);
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine(Seasons.Summer);
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine(Seasons.Automn);
                        break;
                    default:
                        Console.WriteLine("Ошибка: введите число от 1 до 12");
                        break;
                }
        }
        static void Main(string[] args)
        {
            /*
            Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца. 
            На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn.
            
            Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень). 
            Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. 
            Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».

             */

            Console.WriteLine("Введите номер месяца от 1 до 12");
            int monthNumber = int.Parse(Console.ReadLine());
            DetermineTheSeasonByMonthNumber(monthNumber);
            Console.ReadLine();
        }
    }
}