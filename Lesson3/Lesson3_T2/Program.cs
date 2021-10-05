using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Написать программу — телефонный справочник — создать двумерный массив 5*2, 
             хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/e-mail.
             */

            var TelDirectory = new string[5, 2] 
            { 
                { "Валерий", "+78364567832" }, 
                { "Инокентий", "+78165743045 / kesha@mail.ru" }, 
                { "Ванесса","89346578656" },
                { "Джордж","bestpro@ya.ru" },
                { "Агния","4569865" } 
            };

            for (int i = 0; i <TelDirectory.GetLength(0); i++)
            {
                for (int j = 0; j < TelDirectory.GetLength(1); j++)
                {
                    Console.WriteLine($"\n{TelDirectory[i, j]}");
                }
            }
            Console.ReadLine();





        }





    }
}
