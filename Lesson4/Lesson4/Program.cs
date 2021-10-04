using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
   
    class Program
    {
        private static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return ($"{firstName} {lastName} {patronymic}");
        }
        static void Main(string[] args)
        {
            /*
            Написать метод GetFullName(string firstName, string lastName, string patronymic), 
            принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО. 
            Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
            */
            string human1 = GetFullName("Иванов", "Владимир", "Иванович");
            string human2 = GetFullName("Тимощук", "Галина", "Васильевна");
            string human3 = GetFullName("Григорян", "Валерий", "Иванович");
            string human4 = GetFullName("Элтон", "Джон", " ");

            Console.WriteLine($"{human1}\n{human2}\n{human3}\n{human4}");
            Console.ReadLine();
        }
    }
}
