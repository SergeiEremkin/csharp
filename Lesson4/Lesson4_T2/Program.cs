using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_T2
{
    class Program
    {
        public static string Ask()
        {
            Console.WriteLine("Введите цифры через пробелов");
            string NumbersQuestion = Console.ReadLine();
            return NumbersQuestion;
        }
        public static int SumNumbersInString(string Numbers)
        {
            string[] splitNum = Numbers.Split(' ');
            int[] intNum = new int[splitNum.Length];
            int counter = 0;
            int sum = 0;
            foreach (string split in splitNum)
            {
                intNum[counter++] = int.Parse(split);
            }
            for (int i = 0; i < intNum.Length; i++)
            {
                sum += intNum[i];
            }
            return sum;

        }

        static void Main(string[] args)
        {
            /*
            Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, 
            и возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести результат на экран.
             */
            Console.WriteLine($"\n Сумма всех чисел в строке: {SumNumbersInString(Ask())}");
            Console.ReadLine();
        }

    }
}
