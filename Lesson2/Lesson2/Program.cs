using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.

            Console.WriteLine("Введите минимальную температуру: ");
            double min = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру: ");
            double max = Convert.ToDouble(Console.ReadLine());
            double mid = (min + max) / 2;
            Console.WriteLine($"\nСреднесуточная температура: {mid} C");
            Console.ReadLine();
            }
        }
    }


            


            
   



    
