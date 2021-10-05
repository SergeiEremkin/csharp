using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запросить у пользователя порядковый номер текущего месяца и вывести его название.

            /*
             (*) Если пользователь указал месяц из зимнего периода, а средняя температура > 0, 
              вывести сообщение «Дождливая зима».
           */

            Console.WriteLine("Введите минимальную температуру: ");
            double min = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру: ");
            double max = Convert.ToDouble(Console.ReadLine());
            double mid = (min + max) / 2;
            Console.WriteLine($"Среднесуточная температура: {mid}");
            Console.WriteLine("\n\nВведите порядковый номер текущего месяца: ");
            int monthNumber = Convert.ToInt16(Console.ReadLine());
            string monthName = "";
            if (mid > 0)
            {
                switch (monthNumber)
                {
                    case 12:
                        monthName = "Декабрь";
                        Console.WriteLine($"Среднесуточная температура: {mid} C  - Дождливая зима");
                        break;
                    case 1:
                        monthName = "Январь";
                        Console.WriteLine($"Среднесуточная температура: {mid} C - Дождливая зима");
                        break;
                    case 2:
                        monthName = "Февраль";
                        Console.WriteLine($"Среднесуточная температура: {mid} C - Дождливая зима");
                        break;
                    case 3:
                        monthName = "Март";
                        break;
                    case 4:
                        monthName = "Апрель";
                        break;
                    case 5:
                        monthName = "Май";
                        break;
                    case 6:
                        monthName = "Июнь";
                        break;
                    case 7:
                        monthName = "Июль";
                        break;
                    case 8:
                        monthName = "Август";
                        break;
                    case 9:
                        monthName = "Сентябрь";
                        break;
                    case 10:
                        monthName = "Октябрь";
                        break;
                    case 11:
                        monthName = "Ноябрь";
                        break;

                    default:
                        Console.WriteLine("Укажите месяц от 1 до 12");
                        break;
                }
            }
            else
            {
                switch (monthNumber)
                {
                    case 12:
                        monthName = "Декабрь";
                        break;
                    case 1:
                        monthName = "Январь";
                        break;
                    case 2:
                        monthName = "Февраль";
                        break;
                    case 3:
                        monthName = "Март";
                        break;
                    case 4:
                        monthName = "Апрель";
                        break;
                    case 5:
                        monthName = "Май";
                        break;
                    case 6:
                        monthName = "Июнь";
                        break;
                    case 7:
                        monthName = "Июль";
                        break;
                    case 8:
                        monthName = "Август";
                        break;
                    case 9:
                        monthName = "Сентябрь";
                        break;
                    case 10:
                        monthName = "Октябрь";
                        break;
                    case 11:
                        monthName = "Ноябрь";
                        break;

                    default:
                        Console.WriteLine("Укажите месяц от 1 до 12");
                        break;
                }

            }
            Console.WriteLine($"Текущий месяц: {monthName}");
            Console.ReadLine();
        }
    }
}
